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
            btnEliminar = new Button();
            btnLancarNota = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscricoes).BeginInit();
            SuspendLayout();
            // 
            // dgvInscricoes
            // 
            dgvInscricoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInscricoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscricoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscricoes.Location = new Point(1, -2);
            dgvInscricoes.Margin = new Padding(3, 4, 3, 4);
            dgvInscricoes.Name = "dgvInscricoes";
            dgvInscricoes.RowHeadersWidth = 62;
            dgvInscricoes.Size = new Size(1127, 822);
            dgvInscricoes.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNovo.Location = new Point(14, 788);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(86, 30);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(106, 788);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLancarNota
            // 
            btnLancarNota.Location = new Point(198, 788);
            btnLancarNota.Margin = new Padding(2, 2, 2, 2);
            btnLancarNota.Name = "btnLancarNota";
            btnLancarNota.Size = new Size(91, 30);
            btnLancarNota.TabIndex = 4;
            btnLancarNota.Text = "Lançar Nota";
            btnLancarNota.UseVisualStyleBackColor = true;
            btnLancarNota.Click += btnLancarNota_Click;
            // 
            // FormInscricoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 840);
            Controls.Add(btnLancarNota);
            Controls.Add(btnEliminar);
            Controls.Add(btnNovo);
            Controls.Add(dgvInscricoes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInscricoes";
            Text = "FormInscricoes";
            Load += FormInscricoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscricoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscricoes;
        private Button btnNovo;
        private Button btnEliminar;
        private Button button1;
        private Button btnLancarNota;
    }
}