using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormLancarNota : Form
    {
        // Propriedades públicas para devolver os valores ao formulário pai
        public short Nota { get; private set; }
        public string Presenca { get; private set; }

        public FormLancarNota()
        {
            InitializeComponent();
            chkPresenca.Checked = true; // Assume presença por defeito
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Validar se é número
            if (short.TryParse(txtNota.Text, out short notaDigitada))
            {
                if (notaDigitada < 0 || notaDigitada > 20)
                {
                    MessageBox.Show("A nota deve ser entre 0 e 20.");
                    return;
                }

                Nota = notaDigitada;
                Presenca = chkPresenca.Checked ? "P" : "F";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduza uma nota válida.");
            }
        }
    }
}