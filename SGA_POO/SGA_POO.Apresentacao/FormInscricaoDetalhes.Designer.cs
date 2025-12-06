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
            txtNota = new TextBox();
            chkPresenca = new CheckBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cboAluno
            // 
            cboAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAluno.FormattingEnabled = true;
            cboAluno.Location = new Point(12, 25);
            cboAluno.Name = "cboAluno";
            cboAluno.Size = new Size(121, 23);
            cboAluno.TabIndex = 0;
            // 
            // cboUC
            // 
            cboUC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUC.FormattingEnabled = true;
            cboUC.Location = new Point(12, 74);
            cboUC.Name = "cboUC";
            cboUC.Size = new Size(121, 23);
            cboUC.TabIndex = 1;
            // 
            // cboAno
            // 
            cboAno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAno.FormattingEnabled = true;
            cboAno.Location = new Point(173, 25);
            cboAno.Name = "cboAno";
            cboAno.Size = new Size(121, 23);
            cboAno.TabIndex = 2;
            // 
            // cboEpoca
            // 
            cboEpoca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEpoca.FormattingEnabled = true;
            cboEpoca.Location = new Point(173, 74);
            cboEpoca.Name = "cboEpoca";
            cboEpoca.Size = new Size(121, 23);
            cboEpoca.TabIndex = 3;
            // 
            // lAluno
            // 
            lAluno.AutoSize = true;
            lAluno.Location = new Point(12, 7);
            lAluno.Name = "lAluno";
            lAluno.Size = new Size(39, 15);
            lAluno.TabIndex = 4;
            lAluno.Text = "Aluno";
            // 
            // lAno
            // 
            lAno.AutoSize = true;
            lAno.Location = new Point(173, 9);
            lAno.Name = "lAno";
            lAno.Size = new Size(29, 15);
            lAno.TabIndex = 5;
            lAno.Text = "Ano";
            // 
            // lEpoca
            // 
            lEpoca.AutoSize = true;
            lEpoca.Location = new Point(173, 56);
            lEpoca.Name = "lEpoca";
            lEpoca.Size = new Size(39, 15);
            lEpoca.TabIndex = 6;
            lEpoca.Text = "Epoca";
            // 
            // lUC
            // 
            lUC.AutoSize = true;
            lUC.Location = new Point(12, 56);
            lUC.Name = "lUC";
            lUC.Size = new Size(23, 15);
            lUC.TabIndex = 7;
            lUC.Text = "UC";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(12, 118);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 8;
            // 
            // chkPresenca
            // 
            chkPresenca.AutoSize = true;
            chkPresenca.Location = new Point(12, 162);
            chkPresenca.Name = "chkPresenca";
            chkPresenca.Size = new Size(112, 19);
            chkPresenca.TabIndex = 9;
            chkPresenca.Text = "Esteve Presente?";
            chkPresenca.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(58, 214);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(164, 214);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormInscricaoDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 281);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(chkPresenca);
            Controls.Add(txtNota);
            Controls.Add(lUC);
            Controls.Add(lEpoca);
            Controls.Add(lAno);
            Controls.Add(lAluno);
            Controls.Add(cboEpoca);
            Controls.Add(cboAno);
            Controls.Add(cboUC);
            Controls.Add(cboAluno);
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
        private TextBox txtNota;
        private CheckBox chkPresenca;
        private Button btnGravar;
        private Button btnCancelar;
    }
}