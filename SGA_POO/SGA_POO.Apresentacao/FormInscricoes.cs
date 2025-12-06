using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormInscricoes : Form
    {
        // Precisamos de injetar TUDO para passar ao formulário de detalhes
        private readonly IInscricaoRepositorio _repoI;
        private readonly IAlunoRepositorio _repoA;
        private readonly IUnidadeCurricularRepositorio _repoU;
        private readonly IAnoLetivoRepositorio _repoAno;

        public FormInscricoes() { InitializeComponent(); }

        public FormInscricoes(
            IInscricaoRepositorio repoI,
            IAlunoRepositorio repoA,
            IUnidadeCurricularRepositorio repoU,
            IAnoLetivoRepositorio repoAno) : this()
        {
            _repoI = repoI;
            _repoA = repoA;
            _repoU = repoU;
            _repoAno = repoAno;
        }

        private void FormInscricoes_Load(object sender, EventArgs e)
        {
            AtualizarGrelha();
        }

        private void AtualizarGrelha()
        {
            var lista = _repoI.ObterTodas();

            // Transformar objetos complexos em colunas simples para a grelha
            var listaVisivel = lista.Select(i => new {
                Aluno = i.NumeroAlunoNavigation?.NomeProprio + " " + i.NumeroAlunoNavigation?.Apelido,
                Disciplina = i.IdUnidadeCurricularNavigation?.Sigla,
                Ano = i.IdAnoLetivo,
                Epoca = i.IdEpocaAvaliacao,
                Nota = i.Nota
            }).ToList();

            dgvInscricoes.DataSource = listaVisivel;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Passar a "equipa toda" para o formulário de criar
            var form = new FormInscricaoDetalhes(_repoI, _repoA, _repoU, _repoAno);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrelha();
            }
        }
    }
}