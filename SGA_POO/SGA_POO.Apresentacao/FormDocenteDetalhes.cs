using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormDocenteDetalhes : Form
    {
        private readonly IDocenteRepositorio _repo;
        private Docente _docenteAtual;

        // Construtor Visual
        public FormDocenteDetalhes() { InitializeComponent(); }

        // Construtor Lógico (Novo ou Editar)
        public FormDocenteDetalhes(IDocenteRepositorio repo, Docente docente = null) : this()
        {
            _repo = repo;
            _docenteAtual = docente ?? new Docente();

            if (_docenteAtual.Numero != 0) // Modo Edição
            {
                txtNumero.Text = _docenteAtual.Numero.ToString();
                txtNumero.Enabled = false; // Não deixar mudar a chave primária
                txtNome.Text = _docenteAtual.NomeProprio;
                txtApelido.Text = _docenteAtual.Apelido;
                txtEmail.Text = _docenteAtual.Email;
                txtTelefone.Text = _docenteAtual.Telefone;
                txtExtensao.Text = _docenteAtual.Extensao;
                numSalario.Value = _docenteAtual.Salario;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Preencha o Número e o Nome.");
                    return;
                }

                // Passar dados do Ecrã para o Objeto
                // Nota: Se for novo, lemos o número. Se for edição, usamos o que já tinha.
                if (txtNumero.Enabled)
                    _docenteAtual.Numero = int.Parse(txtNumero.Text);

                _docenteAtual.NomeProprio = txtNome.Text;
                _docenteAtual.Apelido = txtApelido.Text;
                _docenteAtual.Email = txtEmail.Text;
                _docenteAtual.Telefone = txtTelefone.Text;
                _docenteAtual.Extensao = txtExtensao.Text;
                _docenteAtual.Salario = numSalario.Value;

                // Gravar
                if (txtNumero.Enabled) // É novo? (Textbox ativa)
                    _repo.Adicionar(_docenteAtual);
                else
                    _repo.Atualizar(_docenteAtual);

                MessageBox.Show("Docente gravado!");
                this.DialogResult = DialogResult.OK; // AVISAR A LISTA QUE GRAVOU
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}