using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        // Construtor vazio para o Designer não dar erro
        public Form1()
        {
            InitializeComponent();
        }

        // Construtor real que recebe os serviços do Program.cs
        public Form1(IServiceProvider serviceProvider) : this()
        {
            _serviceProvider = serviceProvider;
        }

        private void alunosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Pede uma nova janela de alunos à "fábrica"
            var formAlunos = _serviceProvider.GetRequiredService<FormAlunos>();

            // Define que esta janela é "filha" do Menu Principal (MDI)
            formAlunos.MdiParent = this;

            // Mostra a janela
            formAlunos.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // Pedir o formulário de Cursos à mochila
                var formCursos = _serviceProvider.GetRequiredService<FormCursos>();

                // Dizer que fica dentro desta janela principal
                formCursos.MdiParent = this;

                // Mostrar
                formCursos.Show();
            }
        }

        private void unidadesCurricularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // 1. Pedir a janela de UCs à "mochila" de serviços
                // (Nota: Se der erro vermelho aqui, é porque falta criar o FormUnidadesCurriculares ou registá-lo no Program.cs)
                var formUCs = _serviceProvider.GetRequiredService<FormUnidadesCurriculares>();

                // 2. Definir que abre dentro desta janela principal
                formUCs.MdiParent = this;

                // 3. Mostrar a janela
                formUCs.Show();
            }
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // 1. Pedir a janela de Docentes à "mochila"
                var formDocentes = _serviceProvider.GetRequiredService<FormDocentes>();

                // 2. Definir que abre dentro desta janela principal
                formDocentes.MdiParent = this;

                // 3. Mostrar
                formDocentes.Show();
            }
        }

        private void anosLetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // 1. Pedir a janela de Anos Letivos à "mochila" de serviços
                var formAnos = _serviceProvider.GetRequiredService<FormAnosLetivos>();

                // 2. Definir que abre dentro desta janela principal (MDI)
                formAnos.MdiParent = this;

                // 3. Mostrar a janela
                formAnos.Show();
            }
        }

        private void inscricoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // 1. Pedir a janela de Inscrições à "mochila"
                var formInscricoes = _serviceProvider.GetRequiredService<FormInscricoes>();

                // 2. Definir que esta janela "filha" abre dentro da janela principal (MDI)
                formInscricoes.MdiParent = this;

                // 3. Mostrar a janela
                formInscricoes.Show();
            }
        }

        private void inscriçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // 1. Pedir a janela de Inscrições à "mochila"
                var formInscricoes = _serviceProvider.GetRequiredService<FormInscricoes>();

                // 2. Definir que esta janela "filha" abre dentro da janela principal (MDI)
                formInscricoes.MdiParent = this;

                // 3. Mostrar a janela
                formInscricoes.Show();
            }
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_serviceProvider != null)
            {
                // 1. Pedir o ecrã de Turmas (Master-Detail) à mochila
                var formTurmas = _serviceProvider.GetRequiredService<FormTurmas>();

                // 2. Definir que abre dentro da janela principal
                formTurmas.MdiParent = this;

                // 3. Mostrar
                formTurmas.Show();
            }
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar a janela manualmente
            var form = new FormAcerca();

            // Abrir como janela "modal" (bloqueia a de trás até fechar)
            form.ShowDialog();
        }
    }
}