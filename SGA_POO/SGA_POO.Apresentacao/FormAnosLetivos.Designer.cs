namespace SGA_POO.Apresentacao
{
    partial class FormAnosLetivos
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
            dgvAnos = new DataGridView();
            btnNovo = new Button();
            btnApagar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAnos
            // 
            dgvAnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnos.Location = new Point(-5, 0);
            dgvAnos.Name = "dgvAnos";
            dgvAnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnos.Size = new Size(991, 620);
            dgvAnos.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNovo.Location = new Point(12, 626);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnApagar.Location = new Point(174, 626);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(93, 626);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormAnosLetivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(btnEditar);
            Controls.Add(btnApagar);
            Controls.Add(btnNovo);
            Controls.Add(dgvAnos);
            Name = "FormAnosLetivos";
            Text = "FormAnosLetivos";
            WindowState = FormWindowState.Maximized;
            Load += FormAnosLetivos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAnos;
        private Button btnNovo;
        private Button btnApagar;
        private Button btnEditar;
    }
}