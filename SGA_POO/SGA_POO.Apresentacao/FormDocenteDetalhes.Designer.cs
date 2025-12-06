namespace SGA_POO.Apresentacao
{
    partial class FormDocenteDetalhes
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
            txtNumero = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            txtApelido = new TextBox();
            txtExtensao = new TextBox();
            numSalario = new NumericUpDown();
            btnGravar = new Button();
            btnCancelar = new Button();
            lNumero = new Label();
            lNome = new Label();
            lEmail = new Label();
            lApelido = new Label();
            lTelefone = new Label();
            lExtensao = new Label();
            lSalario = new Label();
            ((System.ComponentModel.ISupportInitialize)numSalario).BeginInit();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 152);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(118, 94);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(100, 23);
            txtApelido.TabIndex = 4;
            // 
            // txtExtensao
            // 
            txtExtensao.Location = new Point(118, 152);
            txtExtensao.Name = "txtExtensao";
            txtExtensao.Size = new Size(100, 23);
            txtExtensao.TabIndex = 5;
            // 
            // numSalario
            // 
            numSalario.DecimalPlaces = 2;
            numSalario.Location = new Point(12, 213);
            numSalario.Name = "numSalario";
            numSalario.Size = new Size(120, 23);
            numSalario.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(10, 268);
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
            btnCancelar.Location = new Point(143, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lNumero
            // 
            lNumero.AutoSize = true;
            lNumero.Location = new Point(12, 20);
            lNumero.Name = "lNumero";
            lNumero.Size = new Size(51, 15);
            lNumero.TabIndex = 9;
            lNumero.Text = "Numero";
            // 
            // lNome
            // 
            lNome.AutoSize = true;
            lNome.Location = new Point(10, 76);
            lNome.Name = "lNome";
            lNome.Size = new Size(40, 15);
            lNome.TabIndex = 10;
            lNome.Text = "Nome";
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Location = new Point(118, 20);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(36, 15);
            lEmail.TabIndex = 11;
            lEmail.Text = "Email";
            // 
            // lApelido
            // 
            lApelido.AutoSize = true;
            lApelido.Location = new Point(118, 76);
            lApelido.Name = "lApelido";
            lApelido.Size = new Size(48, 15);
            lApelido.TabIndex = 12;
            lApelido.Text = "Apelido";
            // 
            // lTelefone
            // 
            lTelefone.AutoSize = true;
            lTelefone.Location = new Point(10, 134);
            lTelefone.Name = "lTelefone";
            lTelefone.Size = new Size(51, 15);
            lTelefone.TabIndex = 13;
            lTelefone.Text = "Telefone";
            // 
            // lExtensao
            // 
            lExtensao.AutoSize = true;
            lExtensao.Location = new Point(118, 134);
            lExtensao.Name = "lExtensao";
            lExtensao.Size = new Size(54, 15);
            lExtensao.TabIndex = 14;
            lExtensao.Text = "Extensao";
            // 
            // lSalario
            // 
            lSalario.AutoSize = true;
            lSalario.Location = new Point(12, 195);
            lSalario.Name = "lSalario";
            lSalario.Size = new Size(42, 15);
            lSalario.TabIndex = 15;
            lSalario.Text = "Salario";
            // 
            // FormDocenteDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 323);
            Controls.Add(lSalario);
            Controls.Add(lExtensao);
            Controls.Add(lTelefone);
            Controls.Add(lApelido);
            Controls.Add(lEmail);
            Controls.Add(lNome);
            Controls.Add(lNumero);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(numSalario);
            Controls.Add(txtExtensao);
            Controls.Add(txtApelido);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNumero);
            Name = "FormDocenteDetalhes";
            Text = "FormDocenteDetalhes";
            ((System.ComponentModel.ISupportInitialize)numSalario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private TextBox txtApelido;
        private TextBox txtExtensao;
        private NumericUpDown numSalario;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lNumero;
        private Label lNome;
        private Label lEmail;
        private Label lApelido;
        private Label lTelefone;
        private Label lExtensao;
        private Label lSalario;
    }
}