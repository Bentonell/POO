using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormAnoLetivoDetalhes : Form
    {
        private readonly IAnoLetivoRepositorio _repo;
        private AnoLetivo _anoAtual;

        public FormAnoLetivoDetalhes() { InitializeComponent(); }

        public FormAnoLetivoDetalhes(IAnoLetivoRepositorio repo, AnoLetivo ano = null) : this()
        {
            _repo = repo;
            _anoAtual = ano ?? new AnoLetivo();

            if (_anoAtual.Id != 0) // Edição
            {
                txtId.Text = _anoAtual.Id.ToString();
                txtId.Enabled = false; // PK fixa
                numAnoInicial.Value = _anoAtual.AnoInicial;
                numAnoFinal.Value = _anoAtual.AnoFinal;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Enabled)
                    _anoAtual.Id = short.Parse(txtId.Text); // ID Manual (ex: 2021)

                _anoAtual.AnoInicial = (short)numAnoInicial.Value;
                _anoAtual.AnoFinal = (short)numAnoFinal.Value;

                if (txtId.Enabled)
                    _repo.Adicionar(_anoAtual);
                else
                    _repo.Atualizar(_anoAtual);

                MessageBox.Show("Ano Letivo gravado!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private void numAnoInicial_ValueChanged(object sender, EventArgs e)
        {
            numAnoFinal.Value = numAnoInicial.Value + 1;
        }
    }
}