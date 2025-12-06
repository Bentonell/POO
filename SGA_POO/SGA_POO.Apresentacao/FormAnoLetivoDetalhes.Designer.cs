namespace SGA_POO.Apresentacao
{
    partial class FormAnoLetivoDetalhes
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
            lID = new Label();
            lAnoInicial = new Label();
            lAnoFinal = new Label();
            txtId = new TextBox();
            numAnoInicial = new NumericUpDown();
            btnGravar = new Button();
            numAnoFinal = new NumericUpDown();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numAnoInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnoFinal).BeginInit();
            SuspendLayout();
            // 
            // lID
            // 
            lID.AutoSize = true;
            lID.Location = new Point(12, 5);
            lID.Name = "lID";
            lID.Size = new Size(18, 15);
            lID.TabIndex = 0;
            lID.Text = "ID";
            // 
            // lAnoInicial
            // 
            lAnoInicial.AutoSize = true;
            lAnoInicial.Location = new Point(12, 58);
            lAnoInicial.Name = "lAnoInicial";
            lAnoInicial.Size = new Size(63, 15);
            lAnoInicial.TabIndex = 1;
            lAnoInicial.Text = "Ano Inicial";
            // 
            // lAnoFinal
            // 
            lAnoFinal.AutoSize = true;
            lAnoFinal.Location = new Point(167, 58);
            lAnoFinal.Name = "lAnoFinal";
            lAnoFinal.Size = new Size(57, 15);
            lAnoFinal.TabIndex = 2;
            lAnoFinal.Text = "Ano Final";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // numAnoInicial
            // 
            numAnoInicial.Location = new Point(12, 76);
            numAnoInicial.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAnoInicial.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAnoInicial.Name = "numAnoInicial";
            numAnoInicial.Size = new Size(120, 23);
            numAnoInicial.TabIndex = 4;
            numAnoInicial.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            numAnoInicial.ValueChanged += numAnoInicial_ValueChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(57, 130);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // numAnoFinal
            // 
            numAnoFinal.Enabled = false;
            numAnoFinal.Location = new Point(167, 76);
            numAnoFinal.Maximum = new decimal(new int[] { 2101, 0, 0, 0 });
            numAnoFinal.Minimum = new decimal(new int[] { 2001, 0, 0, 0 });
            numAnoFinal.Name = "numAnoFinal";
            numAnoFinal.ReadOnly = true;
            numAnoFinal.Size = new Size(120, 23);
            numAnoFinal.TabIndex = 6;
            numAnoFinal.Value = new decimal(new int[] { 2001, 0, 0, 0 });
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(167, 130);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAnoLetivoDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 199);
            Controls.Add(btnCancelar);
            Controls.Add(numAnoFinal);
            Controls.Add(btnGravar);
            Controls.Add(numAnoInicial);
            Controls.Add(txtId);
            Controls.Add(lAnoFinal);
            Controls.Add(lAnoInicial);
            Controls.Add(lID);
            Name = "FormAnoLetivoDetalhes";
            Text = "FormAnoLetivoDetalhes";
            ((System.ComponentModel.ISupportInitialize)numAnoInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnoFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lID;
        private Label lAnoInicial;
        private Label lAnoFinal;
        private TextBox txtId;
        private NumericUpDown numAnoInicial;
        private Button btnGravar;
        private NumericUpDown numAnoFinal;
        private Button btnCancelar;
    }
}