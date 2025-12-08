namespace SGA_POO.Apresentacao
{
    partial class FormAcerca
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
            lTitulo = new Label();
            lInfo = new Label();
            lVersão = new Label();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTitulo.Location = new Point(259, 35);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(424, 32);
            lTitulo.TabIndex = 0;
            lTitulo.Text = "SGA - Sistema de Gestão Académica";
            // 
            // lInfo
            // 
            lInfo.AutoSize = true;
            lInfo.Location = new Point(14, 528);
            lInfo.Name = "lInfo";
            lInfo.Size = new Size(205, 60);
            lInfo.TabIndex = 1;
            lInfo.Text = "Trabalho realizado por:\r\nJoão Bento nº82602\r\nRodrigo Manguinhas nº82606";
            // 
            // lVersão
            // 
            lVersão.AutoSize = true;
            lVersão.Location = new Point(833, 568);
            lVersão.Name = "lVersão";
            lVersão.Size = new Size(75, 20);
            lVersão.TabIndex = 2;
            lVersão.Text = "versão 1.0";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(418, 557);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(86, 31);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormAcerca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnFechar);
            Controls.Add(lVersão);
            Controls.Add(lInfo);
            Controls.Add(lTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAcerca";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAcerca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTitulo;
        private Label lInfo;
        private Label lVersão;
        private Button btnFechar;
    }
}