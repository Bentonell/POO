using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormUnidadeCurricularDetalhes : Form
    {
        // Precisamos de 3 repositórios! Um para gravar a UC, e dois para carregar as listas.
        private readonly IUnidadeCurricularRepositorio _repoUC;
        private readonly ICursoRepositorio _repoCurso;
        private readonly IDocenteRepositorio _repoDocente;

        private UnidadeCurricular _ucAtual;

        // Construtor para o Designer
        public FormUnidadeCurricularDetalhes()
        {
            InitializeComponent();
        }

        // Construtor principal (Novo ou Editar)
        public FormUnidadeCurricularDetalhes(
            IUnidadeCurricularRepositorio repoUC,
            ICursoRepositorio repoCurso,
            IDocenteRepositorio repoDocente,
            UnidadeCurricular ucParaEditar = null) : this()
        {
            _repoUC = repoUC;
            _repoCurso = repoCurso;
            _repoDocente = repoDocente;

            // Se veio null, é NOVO. Se veio objeto, é EDITAR.
            _ucAtual = ucParaEditar ?? new UnidadeCurricular();
        }

        private void FormUnidadeCurricularDetalhes_Load(object sender, EventArgs e)
        {
            CarregarListas();
            PreencherDados();
        }

        private void CarregarListas()
        {
            // 1. Carregar Cursos na ComboBox
            cboCurso.DataSource = _repoCurso.ObterTodos();
            cboCurso.DisplayMember = "Nome";       // O que o utilizador vê
            cboCurso.ValueMember = "Referencia";   // O valor real (ID) escondido

            // 2. Carregar Docentes na ComboBox
            cboDocente.DataSource = _repoDocente.ObterTodos();
            cboDocente.DisplayMember = "NomeProprio"; // Podes juntar Apelido se quiseres na classe Docente
            cboDocente.ValueMember = "Numero";
        }

        private void PreencherDados()
        {
            // Se for uma UC nova (ID = 0), não fazemos nada
            if (_ucAtual.Id == 0) return;

            txtNome.Text = _ucAtual.Nome;
            txtSigla.Text = _ucAtual.Sigla;
            numCreditos.Value = _ucAtual.Creditos;

            // Converter string para número (porque na BD pode estar como char)
            if (int.TryParse(_ucAtual.Ano, out int ano)) numAno.Value = ano;
            if (int.TryParse(_ucAtual.Semestre, out int sem)) numSemestre.Value = sem;

            // Selecionar os itens certos nas Combos
            cboCurso.SelectedValue = _ucAtual.ReferenciaCurso;
            cboDocente.SelectedValue = _ucAtual.NumeroDocente;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar seleção
                if (cboCurso.SelectedValue == null || cboDocente.SelectedValue == null)
                {
                    MessageBox.Show("Tem de selecionar um Curso e um Docente.");
                    return;
                }

                // Passar do Ecrã para o Objeto
                // Nota: O ID é gerado automaticamente na BD se for Identity, 
                // senão terias de ter uma textbox para o ID. Vamos assumir que crias o ID ou é auto.
                // Se o ID não for auto-incremento, precisas de um txtId!
                if (_ucAtual.Id == 0)
                {
                    // Gera um ID provisório ou pede ao user (depende da tua BD)
                    // O script da BD diz que o ID NÃO é Identity, logo temos de pedir ou gerar!
                    // Por agora, vamos gerar um aleatório para testar:
                    _ucAtual.Id = new Random().Next(10000, 99999);
                }

                _ucAtual.Nome = txtNome.Text;
                _ucAtual.Sigla = txtSigla.Text;
                _ucAtual.Creditos = numCreditos.Value;
                _ucAtual.Ano = numAno.Value.ToString();
                _ucAtual.Semestre = numSemestre.Value.ToString();

                // Guardar as chaves estrangeiras
                _ucAtual.ReferenciaCurso = (int)cboCurso.SelectedValue;
                _ucAtual.NumeroDocente = (int)cboDocente.SelectedValue;

                // Gravar
                if (_repoUC.ObterPorId(_ucAtual.Id) == null)
                    _repoUC.Adicionar(_ucAtual);
                else
                    _repoUC.Atualizar(_ucAtual);

                MessageBox.Show("Unidade Curricular gravada!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}