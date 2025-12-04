using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormAlunos : Form
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        // O Construtor recebe o repositório via Injeção de Dependência
        public FormAlunos(IAlunoRepositorio alunoRepositorio)
        {
            InitializeComponent();
            _alunoRepositorio = alunoRepositorio;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CarregarAlunos();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            // Associar o clique dos botões aos métodos
            btnEliminar.Click += BtnEliminar_Click;
            btnNovo.Click += BtnNovo_Click;
            btnEditar.Click += BtnEditar_Click;
        }

        private void CarregarAlunos()
        {
            try
            {
                // 1. Obter dados
                var listaAlunos = _alunoRepositorio.ObterTodos();
                dgvAlunos.DataSource = listaAlunos;

                // 2. Formatar a Grelha (Só depois de haver dados)
                if (dgvAlunos.Columns.Count > 0)
                {
                    // Esconder colunas técnicas ou pesadas
                    dgvAlunos.Columns["Foto"].Visible = false; // Binário da imagem não deve aparecer
                    dgvAlunos.Columns["ReferenciaCursoNavigation"].Visible = false; // Propriedade de navegação do EF
                    dgvAlunos.Columns["Inscricaos"].Visible = false; // Lista de inscrições

                    // Melhorar títulos
                    dgvAlunos.Columns["Numero"].HeaderText = "Nº Aluno";
                    dgvAlunos.Columns["NomeProprio"].HeaderText = "Nome";
                    dgvAlunos.Columns["ReferenciaCurso"].HeaderText = "Cód. Curso";

                    // Ajustar larguras
                    dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            // Verificar se há alguma linha selecionada
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para eliminar.");
                return;
            }

            // Obter o objeto Aluno da linha selecionada
            // (O "DataBoundItem" é a linha real da lista de alunos que está por trás da grelha)
            var alunoSelecionado = (Aluno)dgvAlunos.SelectedRows[0].DataBoundItem;

            // Confirmar com o utilizador
            var resposta = MessageBox.Show(
                $"Tem a certeza que deseja eliminar o aluno {alunoSelecionado.NomeProprio} {alunoSelecionado.Apelido}?",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    // Mandar o Repositório apagar
                    _alunoRepositorio.Apagar(alunoSelecionado.Numero);

                    // Recarregar a lista para ver as alterações
                    CarregarAlunos();
                    MessageBox.Show("Aluno eliminado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível eliminar (o aluno pode ter inscrições associadas).\nErro: " + ex.Message);
                }
            }
        }

        private void BtnNovo_Click(object? sender, EventArgs e)
        {
            // Criar o formulário de detalhes passando APENAS o repositório (modo Novo)
            var formDetalhes = new FormAlunoDetalhes(_alunoRepositorio);

            // Se o utilizador gravou (DialogResult.OK), atualizamos a lista
            if (formDetalhes.ShowDialog() == DialogResult.OK)
            {
                CarregarAlunos();
            }
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para editar.");
                return;
            }

            // Obter o aluno selecionado
            var alunoSelecionado = (Aluno)dgvAlunos.SelectedRows[0].DataBoundItem;

            // Criar o formulário passando o Repositório E o Aluno (modo Edição)
            var formDetalhes = new FormAlunoDetalhes(_alunoRepositorio, alunoSelecionado);

            if (formDetalhes.ShowDialog() == DialogResult.OK)
            {
                CarregarAlunos();
            }
        }
    }
}