namespace SGA_POO.Apresentacao
{
    partial class FormLancarNota
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
            txtNota = new TextBox();
            chkPresenca = new CheckBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.Location = new Point(100, 35);
            txtNota.Margin = new Padding(2, 2, 2, 2);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(121, 27);
            txtNota.TabIndex = 0;
            // 
            // chkPresenca
            // 
            chkPresenca.AutoSize = true;
            chkPresenca.Location = new Point(238, 39);
            chkPresenca.Margin = new Padding(2, 2, 2, 2);
            chkPresenca.Name = "chkPresenca";
            chkPresenca.Size = new Size(140, 24);
            chkPresenca.TabIndex = 1;
            chkPresenca.Text = "Esteve Presente?";
            chkPresenca.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(102, 85);
            btnGravar.Margin = new Padding(2, 2, 2, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(90, 27);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(214, 85);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 27);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormLancarNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(chkPresenca);
            Controls.Add(txtNota);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormLancarNota";
            Text = "FormLancarNota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
        private CheckBox chkPresenca;
        private Button btnGravar;
        private Button btnCancelar;
    }
}