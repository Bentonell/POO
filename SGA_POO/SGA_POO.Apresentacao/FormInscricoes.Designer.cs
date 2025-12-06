namespace SGA_POO.Apresentacao
{
    partial class FormInscricoes
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
            dgvInscricoes = new DataGridView();
            btnNovo = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscricoes).BeginInit();
            SuspendLayout();
            // 
            // dgvInscricoes
            // 
            dgvInscricoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInscricoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscricoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscricoes.Location = new Point(1, -1);
            dgvInscricoes.Name = "dgvInscricoes";
            dgvInscricoes.Size = new Size(986, 617);
            dgvInscricoes.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNovo.Location = new Point(12, 622);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(93, 622);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormInscricoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(button2);
            Controls.Add(btnNovo);
            Controls.Add(dgvInscricoes);
            Name = "FormInscricoes";
            Text = "FormInscricoes";
            Load += FormInscricoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscricoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscricoes;
        private Button btnNovo;
        private Button button2;
    }
}