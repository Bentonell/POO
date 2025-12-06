namespace SGA_POO.Apresentacao
{
    partial class FormUnidadeCurricularDetalhes
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
            txtNome = new TextBox();
            txtSigla = new TextBox();
            numCreditos = new NumericUpDown();
            numAno = new NumericUpDown();
            numSemestre = new NumericUpDown();
            cboDocente = new ComboBox();
            cboCurso = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            lNome = new Label();
            lSigla = new Label();
            lCreditos = new Label();
            lAno = new Label();
            lSemestre = new Label();
            lCurso = new Label();
            lDocente = new Label();
            ((System.ComponentModel.ISupportInitialize)numCreditos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSemestre).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(12, 92);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 1;
            // 
            // numCreditos
            // 
            numCreditos.DecimalPlaces = 1;
            numCreditos.Location = new Point(155, 27);
            numCreditos.Name = "numCreditos";
            numCreditos.Size = new Size(120, 23);
            numCreditos.TabIndex = 2;
            // 
            // numAno
            // 
            numAno.Location = new Point(155, 93);
            numAno.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAno.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(120, 23);
            numAno.TabIndex = 3;
            numAno.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numSemestre
            // 
            numSemestre.Location = new Point(155, 160);
            numSemestre.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSemestre.Name = "numSemestre";
            numSemestre.Size = new Size(120, 23);
            numSemestre.TabIndex = 4;
            numSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboDocente
            // 
            cboDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocente.FormattingEnabled = true;
            cboDocente.Location = new Point(12, 159);
            cboDocente.Name = "cboDocente";
            cboDocente.Size = new Size(121, 23);
            cboDocente.TabIndex = 5;
            // 
            // cboCurso
            // 
            cboCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(12, 224);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(121, 23);
            cboCurso.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(12, 273);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(200, 273);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lNome
            // 
            lNome.AutoSize = true;
            lNome.Location = new Point(12, 9);
            lNome.Name = "lNome";
            lNome.Size = new Size(40, 15);
            lNome.TabIndex = 9;
            lNome.Text = "Nome";
            // 
            // lSigla
            // 
            lSigla.AutoSize = true;
            lSigla.Location = new Point(12, 74);
            lSigla.Name = "lSigla";
            lSigla.Size = new Size(32, 15);
            lSigla.TabIndex = 10;
            lSigla.Text = "Sigla";
            // 
            // lCreditos
            // 
            lCreditos.AutoSize = true;
            lCreditos.Location = new Point(155, 9);
            lCreditos.Name = "lCreditos";
            lCreditos.Size = new Size(51, 15);
            lCreditos.TabIndex = 11;
            lCreditos.Text = "Creditos";
            // 
            // lAno
            // 
            lAno.AutoSize = true;
            lAno.Location = new Point(155, 72);
            lAno.Name = "lAno";
            lAno.Size = new Size(29, 15);
            lAno.TabIndex = 12;
            lAno.Text = "Ano";
            // 
            // lSemestre
            // 
            lSemestre.AutoSize = true;
            lSemestre.Location = new Point(155, 138);
            lSemestre.Name = "lSemestre";
            lSemestre.Size = new Size(55, 15);
            lSemestre.TabIndex = 13;
            lSemestre.Text = "Semestre";
            // 
            // lCurso
            // 
            lCurso.AutoSize = true;
            lCurso.Location = new Point(12, 206);
            lCurso.Name = "lCurso";
            lCurso.Size = new Size(38, 15);
            lCurso.TabIndex = 14;
            lCurso.Text = "Curso";
            // 
            // lDocente
            // 
            lDocente.AutoSize = true;
            lDocente.Location = new Point(12, 141);
            lDocente.Name = "lDocente";
            lDocente.Size = new Size(51, 15);
            lDocente.TabIndex = 15;
            lDocente.Text = "Docente";
            // 
            // FormUnidadeCurricularDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 392);
            Controls.Add(lDocente);
            Controls.Add(lCurso);
            Controls.Add(lSemestre);
            Controls.Add(lAno);
            Controls.Add(lCreditos);
            Controls.Add(lSigla);
            Controls.Add(lNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cboCurso);
            Controls.Add(cboDocente);
            Controls.Add(numSemestre);
            Controls.Add(numAno);
            Controls.Add(numCreditos);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Name = "FormUnidadeCurricularDetalhes";
            Text = "FormUnidadeCurricularDetalhes";
            Load += FormUnidadeCurricularDetalhes_Load;
            ((System.ComponentModel.ISupportInitialize)numCreditos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSemestre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSigla;
        private NumericUpDown numCreditos;
        private NumericUpDown numAno;
        private NumericUpDown numSemestre;
        private ComboBox cboDocente;
        private ComboBox cboCurso;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lNome;
        private Label lSigla;
        private Label lCreditos;
        private Label lAno;
        private Label lSemestre;
        private Label lCurso;
        private Label lDocente;
    }
}