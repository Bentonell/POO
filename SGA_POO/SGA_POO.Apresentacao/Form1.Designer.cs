namespace SGA_POO.Apresentacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ficheiroToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            tabelasToolStripMenuItem = new ToolStripMenuItem();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            unidadesCurricularesToolStripMenuItem = new ToolStripMenuItem();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            anosLetivosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            gestãoToolStripMenuItem = new ToolStripMenuItem();
            inscriçõesToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            acercaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(61, 20);
            ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // tabelasToolStripMenuItem
            // 
            tabelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, cursosToolStripMenuItem, unidadesCurricularesToolStripMenuItem, docentesToolStripMenuItem, anosLetivosToolStripMenuItem });
            tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            tabelasToolStripMenuItem.Size = new Size(57, 20);
            tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(189, 22);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click_1;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(189, 22);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // unidadesCurricularesToolStripMenuItem
            // 
            unidadesCurricularesToolStripMenuItem.Name = "unidadesCurricularesToolStripMenuItem";
            unidadesCurricularesToolStripMenuItem.Size = new Size(189, 22);
            unidadesCurricularesToolStripMenuItem.Text = "Unidades Curriculares";
            unidadesCurricularesToolStripMenuItem.Click += unidadesCurricularesToolStripMenuItem_Click;
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(189, 22);
            docentesToolStripMenuItem.Text = "Docentes";
            docentesToolStripMenuItem.Click += docentesToolStripMenuItem_Click;
            // 
            // anosLetivosToolStripMenuItem
            // 
            anosLetivosToolStripMenuItem.Name = "anosLetivosToolStripMenuItem";
            anosLetivosToolStripMenuItem.Size = new Size(189, 22);
            anosLetivosToolStripMenuItem.Text = "Anos Letivos";
            anosLetivosToolStripMenuItem.Click += anosLetivosToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem, tabelasToolStripMenuItem, gestãoToolStripMenuItem, consultasToolStripMenuItem, acercaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // gestãoToolStripMenuItem
            // 
            gestãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscriçõesToolStripMenuItem });
            gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            gestãoToolStripMenuItem.Size = new Size(55, 20);
            gestãoToolStripMenuItem.Text = "Gestão";
            // 
            // inscriçõesToolStripMenuItem
            // 
            inscriçõesToolStripMenuItem.Name = "inscriçõesToolStripMenuItem";
            inscriçõesToolStripMenuItem.Size = new Size(126, 22);
            inscriçõesToolStripMenuItem.Text = "Inscrições";
            inscriçõesToolStripMenuItem.Click += inscriçõesToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { turmasToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(180, 22);
            turmasToolStripMenuItem.Text = "Turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // acercaToolStripMenuItem
            // 
            acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            acercaToolStripMenuItem.Size = new Size(55, 20);
            acercaToolStripMenuItem.Text = "Acerca";
            acercaToolStripMenuItem.Click += acercaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "SGA - Sistema de Gestão Académica";
            WindowState = FormWindowState.Maximized;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem tabelasToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem cursosToolStripMenuItem;
        private ToolStripMenuItem unidadesCurricularesToolStripMenuItem;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem anosLetivosToolStripMenuItem;
        private ToolStripMenuItem gestãoToolStripMenuItem;
        private ToolStripMenuItem inscriçõesToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
        private ToolStripMenuItem acercaToolStripMenuItem;
    }
}
