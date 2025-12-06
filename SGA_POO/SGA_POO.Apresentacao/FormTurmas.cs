using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormTurmas : Form
    {
        private readonly ICursoRepositorio _repoCursos;
        private readonly IUnidadeCurricularRepositorio _repoUCs;
        private readonly IInscricaoRepositorio _repoInscricoes;
        private List<UnidadeCurricular> _todasUCs;

        public FormTurmas(ICursoRepositorio repoC, IUnidadeCurricularRepositorio repoU, IInscricaoRepositorio repoI) : this()
        {
            _repoCursos = repoC;
            _repoUCs = repoU;
            _repoInscricoes = repoI;
        }

        public FormTurmas() { InitializeComponent(); }

        private void FormTurmas_Load(object sender, EventArgs e)
        {
            ConfigurarInterface();

            // 1. CARREGAR UCS PRIMEIRO (Para a variável _todasUCs deixar de ser null)
            _todasUCs = _repoUCs.ObterTodas();

            // 2. Só depois configurar a ComboBox
            // Assim, se o evento disparar, a lista _todasUCs já existe!
            cboCursos.DisplayMember = "Nome";
            cboCursos.ValueMember = "Referencia";
            cboCursos.DataSource = _repoCursos.ObterTodos();

            // 3. Ligar restantes eventos manuais (se não estiverem no Designer)
            cboCursos.SelectedIndexChanged += Filtros_Changed;
            numAno.ValueChanged += Filtros_Changed;
            numSemestre.ValueChanged += Filtros_Changed;
            dgvUCs.SelectionChanged += DgvUCs_SelectionChanged;
            dgvAlunos.SelectionChanged += DgvAlunos_SelectionChanged;

            AtualizarListaUCs();
        }

        private void ConfigurarInterface()
        {
            dgvUCs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUCs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUCs.MultiSelect = false;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunos.MultiSelect = false;

            numAno.Minimum = 0; numAno.Maximum = 3;
            numSemestre.Minimum = 0; numSemestre.Maximum = 2;
        }

        private void Filtros_Changed(object sender, EventArgs e)
        {
            AtualizarListaUCs();
        }

        private void AtualizarListaUCs()
        {
            // Proteção contra crash inicial
            if (cboCursos.SelectedValue == null || !(cboCursos.SelectedValue is int)) return;

            int idCurso = (int)cboCursos.SelectedValue;
            int ano = (int)numAno.Value;
            int sem = (int)numSemestre.Value;

            var ucs = _todasUCs.Where(u => u.ReferenciaCurso == idCurso &&
                (ano == 0 || u.Ano == ano.ToString()) &&
                (sem == 0 || u.Semestre == sem.ToString())).ToList();

            dgvUCs.DataSource = null;
            dgvUCs.DataSource = ucs;

            OcultarColunas(dgvUCs, "ReferenciaCursoNavigation", "NumeroDocenteNavigation", "Inscricaos", "Cursos");

            dgvAlunos.DataSource = null;
            pbFotoAluno.Image = null;
        }

        private void DgvUCs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUCs.SelectedRows.Count == 0) return;
            var uc = (UnidadeCurricular)dgvUCs.SelectedRows[0].DataBoundItem;

            var inscricoes = _repoInscricoes.ObterPorUC(uc.Id);

            dgvAlunos.DataSource = inscricoes.Select(i => new {
                Obj = i.NumeroAlunoNavigation, // Objeto oculto
                Numero = i.NumeroAluno,
                Nome = i.NumeroAlunoNavigation.NomeProprio + " " + i.NumeroAlunoNavigation.Apelido,
                Nota = i.Nota,
                Estado = i.IdEstadoEpoca
            }).ToList();

            if (dgvAlunos.Columns["Obj"] != null) dgvAlunos.Columns["Obj"].Visible = false;
        }

        private void DgvAlunos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0) { pbFotoAluno.Image = null; return; }

            dynamic linha = dgvAlunos.SelectedRows[0].DataBoundItem;
            Aluno aluno = linha.Obj;

            if (aluno.Foto != null && aluno.Foto.Length > 0)
            {
                using (var ms = new MemoryStream(aluno.Foto)) pbFotoAluno.Image = Image.FromStream(ms);
            }
            else pbFotoAluno.Image = null;
        }

        private void OcultarColunas(DataGridView dgv, params string[] cols)
        {
            foreach (var c in cols) if (dgv.Columns[c] != null) dgv.Columns[c].Visible = false;
        }
    }
}