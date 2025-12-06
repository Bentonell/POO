using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormUnidadesCurriculares : Form
    {
        // Precisamos dos 3 repositórios para passar à janela de detalhes
        private readonly IUnidadeCurricularRepositorio _repoUC;
        private readonly ICursoRepositorio _repoCurso;
        private readonly IDocenteRepositorio _repoDocente;

        public FormUnidadesCurriculares() { InitializeComponent(); }

        public FormUnidadesCurriculares(
            IUnidadeCurricularRepositorio repoUC,
            ICursoRepositorio repoCurso,
            IDocenteRepositorio repoDocente) : this()
        {
            _repoUC = repoUC;
            _repoCurso = repoCurso;
            _repoDocente = repoDocente;
        }

        private void FormUnidadesCurriculares_Load(object sender, EventArgs e)
        {
            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            dgvUCs.DataSource = null;
            dgvUCs.DataSource = _repoUC.ObterTodas();

            // Esconder colunas de navegação (objetos ligados)
            string[] colunasEsconder = { "ReferenciaCursoNavigation", "NumeroDocenteNavigation", "Inscricaos" };
            foreach (var col in colunasEsconder)
            {
                if (dgvUCs.Columns[col] != null) dgvUCs.Columns[col].Visible = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Passamos TUDO para a janela de detalhes
            var form = new FormUnidadeCurricularDetalhes(_repoUC, _repoCurso, _repoDocente);
            if (form.ShowDialog() == DialogResult.OK) AtualizarGrelha();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUCs.SelectedRows.Count == 0) return;
            var uc = (UnidadeCurricular)dgvUCs.SelectedRows[0].DataBoundItem;

            var form = new FormUnidadeCurricularDetalhes(_repoUC, _repoCurso, _repoDocente, uc);
            if (form.ShowDialog() == DialogResult.OK) AtualizarGrelha();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // 1. Verificar se selecionou alguém
            if (dgvUCs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma UC para apagar.");
                return;
            }

            // 2. Obter a UC selecionada
            var uc = (UnidadeCurricular)dgvUCs.SelectedRows[0].DataBoundItem;

            // 3. Confirmar
            var resposta = MessageBox.Show(
                $"Tem a certeza que quer apagar a disciplina '{uc.Nome}'?",
                "Apagar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    // 4. Apagar e Atualizar
                    _repoUC.Apagar(uc.Id);
                    AtualizarGrelha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível apagar. Verifique se existem alunos inscritos nesta disciplina.\nErro: " + ex.Message);
                }
            }
        }

    }
}