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
            components = new System.ComponentModel.Container();
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
            lblTotalAlunos = new Label();
            lblTotalCursos = new Label();
            lblTotalDocentes = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lInfo = new Label();
            statusStrip1 = new StatusStrip();
            lblStatusBD = new ToolStripStatusLabel();
            lblRelogio = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox4 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(75, 24);
            ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(117, 26);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // tabelasToolStripMenuItem
            // 
            tabelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, cursosToolStripMenuItem, unidadesCurricularesToolStripMenuItem, docentesToolStripMenuItem, anosLetivosToolStripMenuItem });
            tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            tabelasToolStripMenuItem.Size = new Size(72, 24);
            tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(235, 26);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click_1;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(235, 26);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // unidadesCurricularesToolStripMenuItem
            // 
            unidadesCurricularesToolStripMenuItem.Name = "unidadesCurricularesToolStripMenuItem";
            unidadesCurricularesToolStripMenuItem.Size = new Size(235, 26);
            unidadesCurricularesToolStripMenuItem.Text = "Unidades Curriculares";
            unidadesCurricularesToolStripMenuItem.Click += unidadesCurricularesToolStripMenuItem_Click;
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(235, 26);
            docentesToolStripMenuItem.Text = "Docentes";
            docentesToolStripMenuItem.Click += docentesToolStripMenuItem_Click;
            // 
            // anosLetivosToolStripMenuItem
            // 
            anosLetivosToolStripMenuItem.Name = "anosLetivosToolStripMenuItem";
            anosLetivosToolStripMenuItem.Size = new Size(235, 26);
            anosLetivosToolStripMenuItem.Text = "Anos Letivos";
            anosLetivosToolStripMenuItem.Click += anosLetivosToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem, tabelasToolStripMenuItem, gestãoToolStripMenuItem, consultasToolStripMenuItem, acercaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 2, 0, 2);
            menuStrip2.Size = new Size(914, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // gestãoToolStripMenuItem
            // 
            gestãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscriçõesToolStripMenuItem });
            gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            gestãoToolStripMenuItem.Size = new Size(69, 24);
            gestãoToolStripMenuItem.Text = "Gestão";
            // 
            // inscriçõesToolStripMenuItem
            // 
            inscriçõesToolStripMenuItem.Name = "inscriçõesToolStripMenuItem";
            inscriçõesToolStripMenuItem.Size = new Size(156, 26);
            inscriçõesToolStripMenuItem.Text = "Inscrições";
            inscriçõesToolStripMenuItem.Click += inscriçõesToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { turmasToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(86, 24);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(140, 26);
            turmasToolStripMenuItem.Text = "Turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // acercaToolStripMenuItem
            // 
            acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            acercaToolStripMenuItem.Size = new Size(68, 24);
            acercaToolStripMenuItem.Text = "Acerca";
            acercaToolStripMenuItem.Click += acercaToolStripMenuItem_Click;
            // 
            // lblTotalAlunos
            // 
            lblTotalAlunos.Anchor = AnchorStyles.None;
            lblTotalAlunos.AutoSize = true;
            lblTotalAlunos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAlunos.ForeColor = Color.CornflowerBlue;
            lblTotalAlunos.Location = new Point(11, 46);
            lblTotalAlunos.Margin = new Padding(2, 0, 2, 0);
            lblTotalAlunos.Name = "lblTotalAlunos";
            lblTotalAlunos.Size = new Size(234, 46);
            lblTotalAlunos.TabIndex = 4;
            lblTotalAlunos.Text = "Carregando...";
            lblTotalAlunos.Click += lblTotalAlunos_Click;
            // 
            // lblTotalCursos
            // 
            lblTotalCursos.AutoSize = true;
            lblTotalCursos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCursos.ForeColor = Color.CornflowerBlue;
            lblTotalCursos.Location = new Point(11, 49);
            lblTotalCursos.Margin = new Padding(2, 0, 2, 0);
            lblTotalCursos.Name = "lblTotalCursos";
            lblTotalCursos.Size = new Size(234, 46);
            lblTotalCursos.TabIndex = 5;
            lblTotalCursos.Text = "Carregando...";
            // 
            // lblTotalDocentes
            // 
            lblTotalDocentes.AutoSize = true;
            lblTotalDocentes.BackColor = Color.Transparent;
            lblTotalDocentes.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDocentes.ForeColor = Color.CornflowerBlue;
            lblTotalDocentes.Location = new Point(11, 49);
            lblTotalDocentes.Margin = new Padding(2, 0, 2, 0);
            lblTotalDocentes.Name = "lblTotalDocentes";
            lblTotalDocentes.Size = new Size(234, 46);
            lblTotalDocentes.TabIndex = 6;
            lblTotalDocentes.Text = "Carregando...";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(lblTotalAlunos);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(18, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestão de Alunos";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(lblTotalCursos);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(18, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oferta Formativa";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(lblTotalDocentes);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(18, 410);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Corpo Docente";
            // 
            // lInfo
            // 
            lInfo.Anchor = AnchorStyles.None;
            lInfo.AutoSize = true;
            lInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lInfo.Location = new Point(589, 451);
            lInfo.Name = "lInfo";
            lInfo.Size = new Size(294, 84);
            lInfo.TabIndex = 13;
            lInfo.Text = "Trabalho realizado por:\r\n-João Bento Nº82602\r\n-Rodrigo Manguinhas Nº82606";
            lInfo.Click += lInfo_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusBD, lblRelogio });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(914, 26);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatusBD
            // 
            lblStatusBD.Name = "lblStatusBD";
            lblStatusBD.Size = new Size(85, 20);
            lblStatusBD.Text = "A verificar...";
            // 
            // lblRelogio
            // 
            lblRelogio.Name = "lblRelogio";
            lblRelogio.Size = new Size(814, 20);
            lblRelogio.Spring = true;
            lblRelogio.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button1);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(351, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(532, 290);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Acesso Rápido";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(361, 96);
            button4.Name = "button4";
            button4.Size = new Size(162, 109);
            button4.TabIndex = 7;
            button4.Text = "Gerir Alunos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += alunosToolStripMenuItem_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(191, 96);
            button3.Name = "button3";
            button3.Size = new Size(164, 109);
            button3.TabIndex = 6;
            button3.Text = "Lançar Notas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += inscricoesToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 96);
            button1.Name = "button1";
            button1.Size = new Size(161, 109);
            button1.TabIndex = 5;
            button1.Text = "Nova Inscrição";
            button1.UseVisualStyleBackColor = true;
            button1.Click += inscriçõesToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            textBox1.Location = new Point(351, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 47);
            textBox1.TabIndex = 19;
            textBox1.Text = "SGA - Sistema de Gestão Académica";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBox1);
            Controls.Add(groupBox4);
            Controls.Add(statusStrip1);
            Controls.Add(lInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "SGA - Sistema de Gestão Académica";
            WindowState = FormWindowState.Maximized;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
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
        private Label lblTotalAlunos;
        private Label lblTotalCursos;
        private Label lblTotalDocentes;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lInfo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusBD;
        private ToolStripStatusLabel lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private GroupBox groupBox4;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
    }
}
