namespace SGA_POO.Apresentacao
{
    partial class FormUnidadesCurriculares
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
            dgvUCs = new DataGridView();
            btnNovo = new Button();
            btnEditar = new Button();
            btnApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUCs).BeginInit();
            SuspendLayout();
            // 
            // dgvUCs
            // 
            dgvUCs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUCs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUCs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUCs.Location = new Point(2, -1);
            dgvUCs.Name = "dgvUCs";
            dgvUCs.Size = new Size(980, 621);
            dgvUCs.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNovo.Location = new Point(2, 626);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(83, 626);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnApagar.Location = new Point(164, 626);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 3;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // FormUnidadesCurriculares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(dgvUCs);
            Name = "FormUnidadesCurriculares";
            Text = "FormUnidadesCurriculares";
            Load += FormUnidadesCurriculares_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUCs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUCs;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnApagar;
    }
}