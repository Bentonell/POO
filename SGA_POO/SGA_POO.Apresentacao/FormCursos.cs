using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormCursos : Form
    {
        // Guardamos o repositório para usar nos botões mais tarde
        private readonly ICursoRepositorio _repo;

        // Construtor 1: Para o Designer não dar erro
        public FormCursos()
        {
            InitializeComponent();
        }

        // Construtor 2: Recebe a ferramenta de acesso aos dados (Injeção)
        public FormCursos(ICursoRepositorio repo) : this()
        {
            _repo = repo;
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            // Truque para limpar e recarregar a lista
            dgvCursos.DataSource = null;
            dgvCursos.DataSource = _repo.ObterTodos();

            // Ocultar colunas chatas (opcional)
            if (dgvCursos.Columns["Alunos"] != null) dgvCursos.Columns["Alunos"].Visible = false;
            if (dgvCursos.Columns["UnidadeCurriculars"] != null) dgvCursos.Columns["UnidadeCurriculars"].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Criar a janela de detalhes, passando o repositório
            // Nota: Como estamos dentro do FormCursos, já temos o _repo disponível!
            var formDetalhes = new FormCursoDetalhes(_repo);

            // Abrir como "Dialog" (janela modal que bloqueia a de trás)
            if (formDetalhes.ShowDialog() == DialogResult.OK)
            {
                // Se gravou com sucesso, atualiza a lista
                AtualizarGrelha();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // 1. Verificar se há alguma linha selecionada
            if (dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso para apagar.");
                return;
            }

            // 2. Obter o objeto/ID da linha selecionada
            var cursoSelecionado = (Curso)dgvCursos.SelectedRows[0].DataBoundItem;

            // 3. Confirmar com o utilizador
            var resposta = MessageBox.Show(
                $"Tem a certeza que deseja apagar o curso '{cursoSelecionado.Nome}'?",
                "Confirmar Remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    // 4. Mandar apagar na BD
                    _repo.Apagar(cursoSelecionado.Referencia);

                    // 5. Atualizar a lista visual
                    AtualizarGrelha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar: " + ex.Message);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1. Validar se selecionou alguma linha
            if (dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um curso para editar.");
                return;
            }

            // 2. Pescar o objeto Curso da linha selecionada
            var cursoSelecionado = (Curso)dgvCursos.SelectedRows[0].DataBoundItem;

            // 3. Abrir o form de detalhes, mas ENVIANDO o curso (Usa o 2º construtor)
            var formDetalhes = new FormCursoDetalhes(_repo, cursoSelecionado);

            // 4. Se o utilizador gravou, atualizamos a grelha
            if (formDetalhes.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrelha();
            }
        }
    }
}