using Microsoft.Extensions.DependencyInjection;
using SGA_POO.Negocio.Interfaces; // Necessário para os repositórios
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;

        // Repositórios para o Dashboard
        private readonly IAlunoRepositorio _alunoRepo = null!;
        private readonly ICursoRepositorio _cursoRepo = null!;
        private readonly IDocenteRepositorio _docenteRepo = null!;

        // Construtor vazio (Necessário para o Visual Studio Designer não dar erro)
        public Form1()
        {
            InitializeComponent();
        }

        // Construtor com Injeção de Dependência (Este é o que o programa usa)
        // O Program.cs vai preencher estes parâmetros automaticamente!
        public Form1(IServiceProvider serviceProvider,
                     IAlunoRepositorio alunoRepo,
                     ICursoRepositorio cursoRepo,
                     IDocenteRepositorio docenteRepo) : this()
        {
            _serviceProvider = serviceProvider;
            _alunoRepo = alunoRepo;
            _cursoRepo = cursoRepo;
            _docenteRepo = docenteRepo;
        }

        // Este evento corre assim que a janela abre
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 1. Atualiza os contadores do meio
            AtualizarDashboard();

            // 2. Atualiza a barra de estado em baixo
            ConfigurarRodape();

        }

        private void AtualizarDashboard()
        {
            try
            {
                if (_alunoRepo != null)
                {
                    // Contar
                    int qtdAlunos = _alunoRepo.ObterTodos().Count;
                    int qtdCursos = _cursoRepo.ObterTodos().Count;
                    int qtdDocentes = _docenteRepo.ObterTodos().Count;

                    // Atualizar Labels com Emojis e Texto
                    if (lblTotalAlunos != null)
                        lblTotalAlunos.Text = $"{qtdAlunos}";

                    if (lblTotalCursos != null)
                        lblTotalCursos.Text = $"{qtdCursos}";

                    if (lblTotalDocentes != null)
                        lblTotalDocentes.Text = $"{qtdDocentes}";
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, não mostra MessageBox para não chatear no arranque,
                // apenas escreve na label de erro (se tivesses uma) ou ignora.
            }
        }

        private void ConfigurarRodape()
        {
            // 1. Configurar o estado da Base de Dados
            try
            {
                // Teste simples: se conseguirmos contar alunos, a BD está ligada
                if (_alunoRepo != null)
                {
                    int teste = _alunoRepo.ObterTodos().Count;
                    lblStatusBD.Text = "Base de Dados: ONLINE (Docker)";
                    lblStatusBD.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch
            {
                lblStatusBD.Text = "Base de Dados: DESLIGADA";
                lblStatusBD.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Este é o evento do Timer (que corre a cada segundo)
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // --- MÉTODOS DOS MENUS (Mantive a tua lógica original) ---

        private void alunosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormAlunos>();
            form.MdiParent = this;
            form.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormCursos>();
            form.MdiParent = this;
            form.Show();
        }

        private void unidadesCurricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormUnidadesCurriculares>();
            form.MdiParent = this;
            form.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormDocentes>();
            form.MdiParent = this;
            form.Show();
        }

        private void anosLetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormAnosLetivos>();
            form.MdiParent = this;
            form.Show();
        }

        private void inscricoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormInscricoes>();
            form.MdiParent = this;
            form.Show();
        }

        // Repetido no teu código original, mantive por segurança
        private void inscriçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inscricoesToolStripMenuItem_Click(sender, e);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormTurmas>();
            form.MdiParent = this;
            form.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAcerca();
            form.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void lblTotalAlunos_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lInfo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}