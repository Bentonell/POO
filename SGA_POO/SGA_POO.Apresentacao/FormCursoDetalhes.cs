using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormCursoDetalhes : Form
    {
        private readonly ICursoRepositorio _repo;
        private Curso _cursoAtual;

        // Construtor para o Designer
        public FormCursoDetalhes()
        {
            InitializeComponent();
        }

        // Construtor para CRIAR novo curso
        public FormCursoDetalhes(ICursoRepositorio repo) : this()
        {
            _repo = repo;
            _cursoAtual = new Curso(); // Começa vazio
        }

        // Construtor para EDITAR curso existente
        public FormCursoDetalhes(ICursoRepositorio repo, Curso cursoParaEditar) : this()
        {
            _repo = repo;
            _cursoAtual = cursoParaEditar;

            // Preencher os campos com os dados existentes
            txtReferencia.Text = _cursoAtual.Referencia.ToString();
            txtReferencia.Enabled = false; // Não se deve mudar a chave primária
            txtNome.Text = _cursoAtual.Nome;
            txtSigla.Text = _cursoAtual.Sigla;
            dtpInicio.Value = _cursoAtual.DataInicio.ToDateTime(TimeOnly.MinValue);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Passar dados do Ecrã para o Objeto
                // Nota: A referência é int, temos de converter
                if (txtReferencia.Enabled)
                    _cursoAtual.Referencia = int.Parse(txtReferencia.Text);

                _cursoAtual.Nome = txtNome.Text;
                _cursoAtual.Sigla = txtSigla.Text;
                _cursoAtual.DataInicio = DateOnly.FromDateTime(dtpInicio.Value);

                // 2. Validar (Exemplo simples)
                if (string.IsNullOrEmpty(_cursoAtual.Nome))
                    throw new Exception("O nome é obrigatório.");

                // 3. Gravar na BD
                if (txtReferencia.Enabled)
                {
                    // Se o campo Referência está ativo, é um NOVO registo
                    _repo.Adicionar(_cursoAtual);
                }
                else
                {
                    // Se está inativo, é uma EDIÇÃO
                    _repo.Atualizar(_cursoAtual);
                }

                MessageBox.Show("Curso gravado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close(); // Fecha a janela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                // Importante: Não fechar a janela para o user corrigir
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}