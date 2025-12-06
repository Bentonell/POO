using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormInscricaoDetalhes : Form
    {
        private readonly IInscricaoRepositorio _repoInscricao;
        private readonly IAlunoRepositorio _repoAluno;
        private readonly IUnidadeCurricularRepositorio _repoUC;
        private readonly IAnoLetivoRepositorio _repoAno;

        public FormInscricaoDetalhes() { InitializeComponent(); }

        // Injetamos TODOS os repositórios necessários
        public FormInscricaoDetalhes(
            IInscricaoRepositorio repoI,
            IAlunoRepositorio repoA,
            IUnidadeCurricularRepositorio repoU,
            IAnoLetivoRepositorio repoAno) : this()
        {
            _repoInscricao = repoI;
            _repoAluno = repoA;
            _repoUC = repoU;
            _repoAno = repoAno;
        }

        private void FormInscricaoDetalhes_Load(object sender, EventArgs e)
        {
            CarregarListas();
        }

        private void CarregarListas()
        {
            // 1. Alunos
            cboAluno.DataSource = _repoAluno.ObterTodos();
            cboAluno.DisplayMember = "NomeProprio"; // Podes concatenar no ToString da classe Aluno se quiseres
            cboAluno.ValueMember = "Numero";

            // 2. UCs
            cboUC.DataSource = _repoUC.ObterTodas();
            cboUC.DisplayMember = "Nome";
            cboUC.ValueMember = "Id";

            // 3. Anos Letivos
            cboAno.DataSource = _repoAno.ObterTodos();
            cboAno.DisplayMember = "Id";
            cboAno.ValueMember = "Id";

            // 4. Épocas (Manual, pois são fixas)
            cboEpoca.Items.Add("EFRE");
            cboEpoca.Items.Add("ENEX");
            cboEpoca.Items.Add("EREC");
            cboEpoca.SelectedIndex = 0;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar seleções
                if (cboAluno.SelectedValue == null || cboUC.SelectedValue == null || cboAno.SelectedValue == null)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                var novaInscricao = new Inscricao();

                // Ler IDs
                novaInscricao.NumeroAluno = (int)cboAluno.SelectedValue;
                novaInscricao.IdUnidadeCurricular = (int)cboUC.SelectedValue;
                novaInscricao.IdAnoLetivo = (short)cboAno.SelectedValue; // Cast para short (smallint)
                novaInscricao.IdEpocaAvaliacao = cboEpoca.Text;

                // Outros dados
                novaInscricao.Presenca = chkPresenca.Checked ? "P" : "F";
                novaInscricao.IdEstadoEpoca = 10; // 10 = Admitido (Valor default)

                if (!string.IsNullOrEmpty(txtNota.Text) && short.TryParse(txtNota.Text, out short nota))
                    novaInscricao.Nota = nota;

                // Verificar duplicados
                if (_repoInscricao.ExisteInscricao(novaInscricao.NumeroAluno, novaInscricao.IdUnidadeCurricular, novaInscricao.IdAnoLetivo, novaInscricao.IdEpocaAvaliacao))
                {
                    MessageBox.Show("Inscrição duplicada! Este aluno já está inscrito nesta época.");
                    return;
                }

                _repoInscricao.Adicionar(novaInscricao);

                MessageBox.Show("Inscrição realizada!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
    }
}