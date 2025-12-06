using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormDocentes : Form
    {
        private readonly IDocenteRepositorio _repo;

        // Construtor Visual (para o Designer não crashar)
        public FormDocentes()
        {
            InitializeComponent();
        }

        // Construtor com Injeção (o que o programa usa)
        public FormDocentes(IDocenteRepositorio repo) : this()
        {
            _repo = repo;
        }

        // Ao abrir a janela, carrega os dados
        private void FormDocentes_Load(object sender, EventArgs e)
        {
            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            dgvDocentes.DataSource = null;
            dgvDocentes.DataSource = _repo.ObterTodos();

            // Esconder colunas técnicas (opcional)
            if (dgvDocentes.Columns["UnidadeCurriculars"] != null)
                dgvDocentes.Columns["UnidadeCurriculars"].Visible = false;
        }

        // --- BOTÕES ---

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Abre a janela de detalhes em modo NOVO
            var form = new FormDocenteDetalhes(_repo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrelha();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count == 0) return;

            // Pesca o docente selecionado
            var docente = (Docente)dgvDocentes.SelectedRows[0].DataBoundItem;

            // Abre a janela de detalhes em modo EDIÇÃO (passando o docente)
            var form = new FormDocenteDetalhes(_repo, docente);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrelha();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count == 0) return;

            var docente = (Docente)dgvDocentes.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Tem a certeza que quer apagar o docente {docente.NomeProprio}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _repo.Apagar(docente.Numero);
                    AtualizarGrelha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar: " + ex.Message);
                }
            }
        }
    }
}