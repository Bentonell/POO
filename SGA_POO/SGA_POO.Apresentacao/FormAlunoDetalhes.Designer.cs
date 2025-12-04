namespace SGA_POO.Apresentacao
{
    partial class FormAlunoDetalhes
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblApelido = new Label();
            txtApelido = new TextBox();
            lblMorada = new Label();
            txtMorada = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCurso = new Label();
            txtCurso = new TextBox();
            lblData = new Label();
            dtpDataNascimento = new DateTimePicker();
            picFoto = new PictureBox();
            btnCarregarFoto = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(24, 40);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(81, 25);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(150, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(97, 25);
            lblNome.TabIndex = 2;
            lblNome.Text = "N. Próprio:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(150, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 3;
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(24, 135);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(78, 25);
            lblApelido.TabIndex = 4;
            lblApelido.Text = "Apelido:";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(150, 135);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(150, 31);
            txtApelido.TabIndex = 5;
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Location = new Point(27, 183);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(78, 25);
            lblMorada.TabIndex = 6;
            lblMorada.Text = "Morada:";
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(150, 183);
            txtMorada.Multiline = true;
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(150, 31);
            txtMorada.TabIndex = 7;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(24, 230);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(81, 25);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(150, 230);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 31);
            txtTelefone.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 279);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 279);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 11;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(24, 328);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(104, 25);
            lblCurso.TabIndex = 12;
            lblCurso.Text = "Cód. Curso:";
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(150, 328);
            txtCurso.Multiline = true;
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(150, 31);
            txtCurso.TabIndex = 13;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(423, 171);
            lblData.Name = "lblData";
            lblData.Size = new Size(152, 25);
            lblData.TabIndex = 14;
            lblData.Text = "Data Nascimento:";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(608, 171);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(135, 31);
            dtpDataNascimento.TabIndex = 15;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.Fixed3D;
            picFoto.Location = new Point(608, 33);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(150, 75);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 17;
            picFoto.TabStop = false;
            // 
            // btnCarregarFoto
            // 
            btnCarregarFoto.Location = new Point(408, 53);
            btnCarregarFoto.Name = "btnCarregarFoto";
            btnCarregarFoto.Size = new Size(167, 34);
            btnCarregarFoto.TabIndex = 18;
            btnCarregarFoto.Text = "Carregar Foto...";
            btnCarregarFoto.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(466, 394);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 34);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(650, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(167, 34);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAlunoDetalhes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCarregarFoto);
            Controls.Add(picFoto);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblData);
            Controls.Add(txtCurso);
            Controls.Add(lblCurso);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtMorada);
            Controls.Add(lblMorada);
            Controls.Add(txtApelido);
            Controls.Add(lblApelido);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "FormAlunoDetalhes";
            Text = "FormAlunoDetalhes";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblApelido;
        private TextBox txtApelido;
        private Label lblMorada;
        private TextBox txtMorada;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCurso;
        private TextBox txtCurso;
        private Label lblData;
        private DateTimePicker dtpDataNascimento;
        private PictureBox picFoto;
        private Button btnCarregarFoto;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}