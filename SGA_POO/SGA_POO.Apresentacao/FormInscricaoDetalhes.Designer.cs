namespace SGA_POO.Apresentacao
{
    partial class FormInscricaoDetalhes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboAluno = new ComboBox();
            cboUC = new ComboBox();
            cboAno = new ComboBox();
            cboEpoca = new ComboBox();
            lAluno = new Label();
            lAno = new Label();
            lEpoca = new Label();
            lUC = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cboAluno
            // 
            cboAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAluno.FormattingEnabled = true;
            cboAluno.Location = new Point(14, 33);
            cboAluno.Margin = new Padding(3, 4, 3, 4);
            cboAluno.Name = "cboAluno";
            cboAluno.Size = new Size(138, 28);
            cboAluno.TabIndex = 0;
            // 
            // cboUC
            // 
            cboUC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUC.FormattingEnabled = true;
            cboUC.Location = new Point(14, 99);
            cboUC.Margin = new Padding(3, 4, 3, 4);
            cboUC.Name = "cboUC";
            cboUC.Size = new Size(138, 28);
            cboUC.TabIndex = 1;
            // 
            // cboAno
            // 
            cboAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAno.FormattingEnabled = true;
            cboAno.Location = new Point(198, 33);
            cboAno.Margin = new Padding(3, 4, 3, 4);
            cboAno.Name = "cboAno";
            cboAno.Size = new Size(138, 28);
            cboAno.TabIndex = 2;
            // 
            // cboEpoca
            // 
            cboEpoca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEpoca.FormattingEnabled = true;
            cboEpoca.Location = new Point(198, 99);
            cboEpoca.Margin = new Padding(3, 4, 3, 4);
            cboEpoca.Name = "cboEpoca";
            cboEpoca.Size = new Size(138, 28);
            cboEpoca.TabIndex = 3;
            // 
            // lAluno
            // 
            lAluno.AutoSize = true;
            lAluno.Location = new Point(14, 9);
            lAluno.Name = "lAluno";
            lAluno.Size = new Size(48, 20);
            lAluno.TabIndex = 4;
            lAluno.Text = "Aluno";
            // 
            // lAno
            // 
            lAno.AutoSize = true;
            lAno.Location = new Point(198, 12);
            lAno.Name = "lAno";
            lAno.Size = new Size(36, 20);
            lAno.TabIndex = 5;
            lAno.Text = "Ano";
            // 
            // lEpoca
            // 
            lEpoca.AutoSize = true;
            lEpoca.Location = new Point(198, 75);
            lEpoca.Name = "lEpoca";
            lEpoca.Size = new Size(50, 20);
            lEpoca.TabIndex = 6;
            lEpoca.Text = "Epoca";
            // 
            // lUC
            // 
            lUC.AutoSize = true;
            lUC.Location = new Point(14, 75);
            lUC.Name = "lUC";
            lUC.Size = new Size(28, 20);
            lUC.TabIndex = 7;
            lUC.Text = "UC";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(66, 285);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 31);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(187, 285);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormInscricaoDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 375);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lUC);
            Controls.Add(lEpoca);
            Controls.Add(lAno);
            Controls.Add(lAluno);
            Controls.Add(cboEpoca);
            Controls.Add(cboAno);
            Controls.Add(cboUC);
            Controls.Add(cboAluno);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInscricaoDetalhes";
            Text = "FormInscricaoDetalhes";
            Load += FormInscricaoDetalhes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboAluno;
        private ComboBox cboUC;
        private ComboBox cboAno;
        private ComboBox cboEpoca;
        private Label lAluno;
        private Label lAno;
        private Label lEpoca;
        private Label lUC;
        private Button btnGravar;
        private Button btnCancelar;
    }
}