using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using SGA_POO.Negocio.Servicos; // <--- Importante para o Gestor
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormInscricoes : Form
    {
        // Repositórios necessários
        private readonly IInscricaoRepositorio _repoInscricao;
        private readonly IAlunoRepositorio _repoAluno;
        private readonly IUnidadeCurricularRepositorio _repoUC;
        private readonly IAnoLetivoRepositorio _repoAno;

        // O Gestor de Regras (O "Juiz")
        private readonly GestorInscricoes _gestor;

        // Construtor Vazio (para o Designer)
        public FormInscricoes()
        {
            InitializeComponent();
        }

        // Construtor com Injeção de Dependência (O Program.cs usa este)
        public FormInscricoes(
            IInscricaoRepositorio repoI,
            IAlunoRepositorio repoA,
            IUnidadeCurricularRepositorio repoU,
            IAnoLetivoRepositorio repoAno,
            GestorInscricoes gestor) : this() // <--- Recebemos o Gestor aqui
        {
            _repoInscricao = repoI;
            _repoAluno = repoA;
            _repoUC = repoU;
            _repoAno = repoAno;
            _gestor = gestor;
        }

        private void FormInscricoes_Load(object sender, EventArgs e)
        {
            CarregarGrelha();
        }

        private void CarregarGrelha()
        {
            try
            {
                dgvInscricoes.DataSource = null;
                dgvInscricoes.DataSource = _repoInscricao.ObterTodas();

                // Formatação opcional da grelha
                if (dgvInscricoes.Columns["NumeroAlunoNavigation"] != null)
                    dgvInscricoes.Columns["NumeroAlunoNavigation"].Visible = false;
                if (dgvInscricoes.Columns["IdUnidadeCurricularNavigation"] != null)
                    dgvInscricoes.Columns["IdUnidadeCurricularNavigation"].Visible = false;
                if (dgvInscricoes.Columns["IdEpocaAvaliacaoNavigation"] != null)
                    dgvInscricoes.Columns["IdEpocaAvaliacaoNavigation"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar inscrições: " + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // AQUI ESTAVA O ERRO: Agora passamos o _gestor para o formulário filho
            var formDetalhes = new FormInscricaoDetalhes(
                _repoInscricao,
                _repoAluno,
                _repoUC,
                _repoAno,
                _gestor // <--- A Chave Nova!
            );

            if (formDetalhes.ShowDialog() == DialogResult.OK)
            {
                CarregarGrelha();
            }
        }

        // Caso tenhas um botão de apagar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInscricoes.SelectedRows.Count == 0) return;

            var inscricao = (Inscricao)dgvInscricoes.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("Apagar inscrição?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repoInscricao.Apagar(
                        inscricao.NumeroAluno,
                        inscricao.IdUnidadeCurricular,
                        inscricao.IdAnoLetivo,
                        inscricao.IdEpocaAvaliacao
                    );
                    CarregarGrelha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar: " + ex.Message);
                }
            }
        }

        private void btnLancarNota_Click(object sender, EventArgs e)
        {
            if (dgvInscricoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma inscrição.");
                return;
            }

            // Obter a linha selecionada
            var linha = (Inscricao)dgvInscricoes.SelectedRows[0].DataBoundItem;

            // Abrir a janelinha de pedir a nota
            var formNota = new FormLancarNota();
            if (formNota.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Chamar o Gestor para processar a "Regra de Ouro"
                    _gestor.LancarNota(
                        linha.NumeroAluno,
                        linha.IdUnidadeCurricular,
                        linha.IdAnoLetivo,
                        linha.IdEpocaAvaliacao,
                        formNota.Nota,
                        formNota.Presenca
                    );

                    MessageBox.Show("Nota lançada com sucesso!");

                    // Se houve reprovação em EFRE, o gestor criou ENEX. 
                    // Atualizamos a grelha para ver a nova inscrição a aparecer sozinha!
                    CarregarGrelha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao lançar nota: " + ex.Message);
                }
            }
        }
    }
}