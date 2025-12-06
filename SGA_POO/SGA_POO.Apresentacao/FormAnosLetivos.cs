using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormAnosLetivos : Form
    {
        private readonly IAnoLetivoRepositorio _repo;

        public FormAnosLetivos() { InitializeComponent(); }
        public FormAnosLetivos(IAnoLetivoRepositorio repo) : this() { _repo = repo; }

        private void FormAnosLetivos_Load(object sender, EventArgs e) { AtualizarGrelha(); }

        private void AtualizarGrelha()
        {
            dgvAnos.DataSource = null;
            dgvAnos.DataSource = _repo.ObterTodos();
            if (dgvAnos.Columns["Inscricaos"] != null) dgvAnos.Columns["Inscricaos"].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var form = new FormAnoLetivoDetalhes(_repo);
            if (form.ShowDialog() == DialogResult.OK) AtualizarGrelha();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAnos.SelectedRows.Count == 0) return;
            var ano = (AnoLetivo)dgvAnos.SelectedRows[0].DataBoundItem;

            var form = new FormAnoLetivoDetalhes(_repo, ano);
            if (form.ShowDialog() == DialogResult.OK) AtualizarGrelha();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvAnos.SelectedRows.Count == 0) return;
            var ano = (AnoLetivo)dgvAnos.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show("Apagar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { _repo.Apagar(ano.Id); AtualizarGrelha(); }
                catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
            }
        }
    }
}