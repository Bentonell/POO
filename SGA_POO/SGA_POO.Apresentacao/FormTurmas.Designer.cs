namespace SGA_POO.Apresentacao
{
    partial class FormTurmas
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
            cboCursos = new ComboBox();
            lCurso = new Label();
            dgvUCs = new DataGridView();
            dgvAlunos = new DataGridView();
            lAno = new Label();
            numAno = new NumericUpDown();
            lSemestre = new Label();
            numSemestre = new NumericUpDown();
            pbFotoAluno = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUCs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoAluno).BeginInit();
            SuspendLayout();
            // 
            // cboCursos
            // 
            cboCursos.AllowDrop = true;
            cboCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCursos.FormattingEnabled = true;
            cboCursos.Location = new Point(66, 6);
            cboCursos.Name = "cboCursos";
            cboCursos.Size = new Size(121, 23);
            cboCursos.TabIndex = 0;
            cboCursos.SelectedIndexChanged += Filtros_Changed;
            cboCursos.Click += Filtros_Changed;
            // 
            // lCurso
            // 
            lCurso.AutoSize = true;
            lCurso.Location = new Point(22, 9);
            lCurso.Name = "lCurso";
            lCurso.Size = new Size(38, 15);
            lCurso.TabIndex = 1;
            lCurso.Text = "Curso";
            // 
            // dgvUCs
            // 
            dgvUCs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUCs.Location = new Point(-1, 65);
            dgvUCs.MultiSelect = false;
            dgvUCs.Name = "dgvUCs";
            dgvUCs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUCs.Size = new Size(1527, 363);
            dgvUCs.TabIndex = 2;
            dgvUCs.SelectionChanged += DgvUCs_SelectionChanged;
            // 
            // dgvAlunos
            // 
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(-1, 434);
            dgvAlunos.MultiSelect = false;
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunos.Size = new Size(1140, 306);
            dgvAlunos.TabIndex = 3;
            dgvAlunos.SelectionChanged += DgvAlunos_SelectionChanged;
            // 
            // lAno
            // 
            lAno.AutoSize = true;
            lAno.Location = new Point(22, 38);
            lAno.Name = "lAno";
            lAno.Size = new Size(32, 15);
            lAno.TabIndex = 4;
            lAno.Text = "Ano:";
            // 
            // numAno
            // 
            numAno.Location = new Point(66, 35);
            numAno.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAno.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAno.Name = "numAno";
            numAno.Size = new Size(120, 23);
            numAno.TabIndex = 5;
            numAno.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numAno.ValueChanged += Filtros_Changed;
            // 
            // lSemestre
            // 
            lSemestre.AutoSize = true;
            lSemestre.Location = new Point(270, 37);
            lSemestre.Name = "lSemestre";
            lSemestre.Size = new Size(58, 15);
            lSemestre.TabIndex = 6;
            lSemestre.Text = "Semestre:";
            // 
            // numSemestre
            // 
            numSemestre.Location = new Point(334, 35);
            numSemestre.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSemestre.Name = "numSemestre";
            numSemestre.Size = new Size(120, 23);
            numSemestre.TabIndex = 7;
            numSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSemestre.ValueChanged += Filtros_Changed;
            // 
            // pbFotoAluno
            // 
            pbFotoAluno.Location = new Point(1145, 434);
            pbFotoAluno.Name = "pbFotoAluno";
            pbFotoAluno.Size = new Size(368, 291);
            pbFotoAluno.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoAluno.TabIndex = 8;
            pbFotoAluno.TabStop = false;
            // 
            // FormTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 737);
            Controls.Add(pbFotoAluno);
            Controls.Add(numSemestre);
            Controls.Add(lSemestre);
            Controls.Add(numAno);
            Controls.Add(lAno);
            Controls.Add(dgvAlunos);
            Controls.Add(dgvUCs);
            Controls.Add(lCurso);
            Controls.Add(cboCursos);
            Name = "FormTurmas";
            Text = "FormTurmas";
            Load += FormTurmas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUCs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCursos;
        private Label lCurso;
        private DataGridView dgvUCs;
        private DataGridView dgvAlunos;
        private Label lAno;
        private NumericUpDown numAno;
        private Label lSemestre;
        private NumericUpDown numSemestre;
        private PictureBox pbFotoAluno;
    }
}