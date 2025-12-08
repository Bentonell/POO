using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using SGA_POO.Negocio.Servicos; // <--- NOVO: Necessário para aceder às regras
using System;
using System.Windows.Forms;

namespace SGA_POO.Apresentacao
{
    public partial class FormInscricaoDetalhes : Form
    {
        private readonly IInscricaoRepositorio _repoInscricao;
        private readonly IAlunoRepositorio _repoAluno;
        private readonly IUnidadeCurricularRepositorio _repoUC;
        private readonly IAnoLetivoRepositorio _repoAno;

        // O nosso "Juiz" das regras
        private readonly GestorInscricoes _gestor;

        public FormInscricaoDetalhes() { InitializeComponent(); }

        // Construtor atualizado com o GestorInscricoes
        public FormInscricaoDetalhes(
            IInscricaoRepositorio repoI,
            IAlunoRepositorio repoA,
            IUnidadeCurricularRepositorio repoU,
            IAnoLetivoRepositorio repoAno,
            GestorInscricoes gestor) : this() // <--- O Program.cs vai injetar isto aqui
        {
            _repoInscricao = repoI;
            _repoAluno = repoA;
            _repoUC = repoU;
            _repoAno = repoAno;
            _gestor = gestor;
        }

        private void FormInscricaoDetalhes_Load(object sender, EventArgs e)
        {
            CarregarListas();
        }

        private void CarregarListas()
        {
            // 1. Alunos
            cboAluno.DataSource = _repoAluno.ObterTodos();
            cboAluno.DisplayMember = "NomeProprio";
            cboAluno.ValueMember = "Numero";

            // 2. UCs
            cboUC.DataSource = _repoUC.ObterTodas();
            cboUC.DisplayMember = "Nome";
            cboUC.ValueMember = "Id";

            // 3. Anos Letivos
            cboAno.DataSource = _repoAno.ObterTodos();
            cboAno.DisplayMember = "Id";
            cboAno.ValueMember = "Id";

            // 4. Épocas
            cboEpoca.Items.Clear(); // Limpar para garantir
            cboEpoca.Items.Add("EFRE"); // Frequência
            cboEpoca.Items.Add("ENEX"); // Normal
            cboEpoca.Items.Add("EREC"); // Recurso
            cboEpoca.Items.Add("EESP"); // Especial
            cboEpoca.SelectedIndex = 0;

            // --- Ligar os eventos ---
            // Sempre que o utilizador muda a escolha, verificamos as regras
            cboAluno.SelectedIndexChanged += (s, e) => VerificarRegraPrimeiraInscricao();
            cboUC.SelectedIndexChanged += (s, e) => VerificarRegraPrimeiraInscricao();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar preenchimento básico
                if (cboAluno.SelectedValue == null || cboUC.SelectedValue == null || cboAno.SelectedValue == null)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                // Preparar o objeto
                var novaInscricao = new Inscricao();
                novaInscricao.NumeroAluno = (int)cboAluno.SelectedValue;
                novaInscricao.IdUnidadeCurricular = (int)cboUC.SelectedValue;
                novaInscricao.IdAnoLetivo = Convert.ToInt16(cboAno.SelectedValue); // Mais seguro que o cast direto
                novaInscricao.IdEpocaAvaliacao = cboEpoca.Text;
                //novaInscricao.Presenca = chkPresenca.Checked ? "P" : "F";
                novaInscricao.IdEstadoEpoca = 10; // 10 = Admitido

                //if (!string.IsNullOrEmpty(txtNota.Text) && short.TryParse(txtNota.Text, out short nota))
                  //  novaInscricao.Nota = nota;

                // 2. VALIDAR REGRAS DE NEGÓCIO (O "Cérebro" atua aqui!)
                // Se a regra falhar, o Gestor lança uma exceção e o código salta para o 'catch'
                _gestor.ValidarInscricao(
                    novaInscricao.NumeroAluno,
                    novaInscricao.IdUnidadeCurricular,
                    novaInscricao.IdAnoLetivo,
                    novaInscricao.IdEpocaAvaliacao
                );

                // 3. Verificar duplicados (Validação técnica)
                // Nota: O método ExisteInscricao tem de existir na tua Interface/Repositório
                if (_repoInscricao.ExisteInscricao(novaInscricao.NumeroAluno, novaInscricao.IdUnidadeCurricular, novaInscricao.IdAnoLetivo, novaInscricao.IdEpocaAvaliacao))
                {
                    MessageBox.Show("Inscrição duplicada! Este aluno já está inscrito nesta época.");
                    return;
                }

                // 4. Gravar
                _repoInscricao.Adicionar(novaInscricao);

                MessageBox.Show("Inscrição realizada com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Aqui apanhamos os erros do Gestor (ex: "Não pode ir a Recurso sem ir a Normal")
                MessageBox.Show("Regra de Negócio: " + ex.Message, "Inscrição Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VerificarRegraPrimeiraInscricao()
        {
            // Só validamos se tivermos valores selecionados
            if (cboAluno.SelectedValue != null && cboUC.SelectedValue != null)
            {
                try
                {
                    int idAluno = (int)cboAluno.SelectedValue;
                    int idUC = (int)cboUC.SelectedValue;

                    // Perguntar ao Gestor se é a primeira vez
                    if (_gestor.EPrimeiraInscricao(idAluno, idUC))
                    {
                        // REGRA ATIVADA: Forçar "Frequência"
                        cboEpoca.SelectedItem = "EFRE";
                        cboEpoca.Enabled = false; // Bloqueia a caixa para não se poder mudar
                    }
                    else
                    {
                        // Se já não é a primeira vez, deixa escolher livremente
                        cboEpoca.Enabled = true;
                    }
                }
                catch
                {
                    // Ignorar erros durante a seleção visual
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}