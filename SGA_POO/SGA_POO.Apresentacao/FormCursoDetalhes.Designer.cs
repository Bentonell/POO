namespace SGA_POO.Apresentacao
{
    partial class FormCursoDetalhes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtReferencia = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            dtpInicio = new DateTimePicker();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Referência";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 26);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Sigla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 93);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Início";
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(12, 44);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(100, 23);
            txtReferencia.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(118, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(12, 111);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(100, 23);
            txtSigla.TabIndex = 6;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(118, 111);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(100, 23);
            dtpInicio.TabIndex = 7;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(12, 175);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 23);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(118, 175);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCursoDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 233);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(dtpInicio);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtReferencia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCursoDetalhes";
            Text = "FormCursoDetalhes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtReferencia;
        private TextBox txtNome;
        private TextBox txtSigla;
        private DateTimePicker dtpInicio;
        private Button btnGravar;
        private Button btnCancelar;
    }
}