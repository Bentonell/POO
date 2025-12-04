using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormAlunoDetalhes : Form
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private Aluno _alunoAtual; // Guarda o aluno que estamos a editar (ou null se for novo)
        private bool _modoEdicao;  // true = Editar, false = Novo

        // Construtor
        public FormAlunoDetalhes(IAlunoRepositorio alunoRepositorio, Aluno alunoParaEditar = null)
        {
            InitializeComponent();
            _alunoRepositorio = alunoRepositorio;

            // Se vier um aluno, estamos em modo Edição. Se vier null, é Novo.
            _alunoAtual = alunoParaEditar;
            _modoEdicao = (alunoParaEditar != null);

            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Botões
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => Close();
            btnCarregarFoto.Click += BtnCarregarFoto_Click;

            if (_modoEdicao)
            {
                Text = "Editar Aluno";
                txtNumero.Enabled = false; // Não se pode mudar o número de um aluno existente (Chave Primária)
                PreencherCampos();
            }
            else
            {
                Text = "Novo Aluno";
                txtNumero.Enabled = true;
                _alunoAtual = new Aluno(); // Prepara um aluno vazio
            }
        }

        private void PreencherCampos()
        {
            txtNumero.Text = _alunoAtual.Numero.ToString();
            txtNome.Text = _alunoAtual.NomeProprio;
            txtApelido.Text = _alunoAtual.Apelido;
            txtMorada.Text = _alunoAtual.Morada;
            txtTelefone.Text = _alunoAtual.Telefone;
            txtEmail.Text = _alunoAtual.Email;
            txtCurso.Text = _alunoAtual.ReferenciaCurso.ToString();

            // <--- CORREÇÃO AQUI: Converter DateOnly para DateTime
            if (_alunoAtual.DataNascimento != null)
            {
                // Converte a data da BD para DateTime (adicionando 00:00h como hora)
                dtpDataNascimento.Value = _alunoAtual.DataNascimento.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dtpDataNascimento.Value = DateTime.Now;
            }

            // Carregar Foto se existir
            if (_alunoAtual.Foto != null && _alunoAtual.Foto.Length > 0)
            {
                using (var ms = new MemoryStream(_alunoAtual.Foto))
                {
                    picFoto.Image = Image.FromStream(ms);
                }
            }
        }

        private void BtnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                // 1. Validar dados obrigatórios
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("O Número e o Nome são obrigatórios.");
                    return;
                }

                // 2. Preencher o objeto
                _alunoAtual.Numero = int.Parse(txtNumero.Text);
                _alunoAtual.NomeProprio = txtNome.Text;
                _alunoAtual.Apelido = txtApelido.Text;
                _alunoAtual.Morada = txtMorada.Text;
                _alunoAtual.Telefone = txtTelefone.Text;
                _alunoAtual.Email = txtEmail.Text;

                // <--- CORREÇÃO AQUI: Converter DateTime para DateOnly
                _alunoAtual.DataNascimento = DateOnly.FromDateTime(dtpDataNascimento.Value);

                // Validar Curso
                if (int.TryParse(txtCurso.Text, out int idCurso))
                {
                    _alunoAtual.ReferenciaCurso = idCurso;
                }
                else
                {
                    MessageBox.Show("O código do curso deve ser um número.");
                    return;
                }

                // 3. Gravar na Base de Dados
                if (_modoEdicao)
                {
                    _alunoRepositorio.Editar(_alunoAtual);
                }
                else
                {
                    if (_alunoRepositorio.ObterPorNumero(_alunoAtual.Numero) != null)
                    {
                        MessageBox.Show("Já existe um aluno com esse número!");
                        return;
                    }
                    _alunoRepositorio.Adicionar(_alunoAtual);
                }

                MessageBox.Show("Aluno guardado com sucesso!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar: " + ex.Message);
            }
        }

        private void BtnCarregarFoto_Click(object? sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Mostrar no ecrã
                picFoto.Image = Image.FromFile(ofd.FileName);

                // Converter para bytes para guardar na BD
                using (MemoryStream ms = new MemoryStream())
                {
                    picFoto.Image.Save(ms, picFoto.Image.RawFormat);
                    _alunoAtual.Foto = ms.ToArray();
                }
            }
        }
    }
}