using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System;
using System.Linq;

namespace SGA_POO.Negocio.Servicos
{
    public class GestorInscricoes
    {
        private readonly IInscricaoRepositorio _inscricaoRepo;

        // Construtor: Apenas inicializa as variáveis
        public GestorInscricoes(IInscricaoRepositorio inscricaoRepo)
        {
            _inscricaoRepo = inscricaoRepo;
        }

        /// <summary>
        /// Verifica se é a primeira vez que o aluno se inscreve nesta UC.
        /// </summary>
        public bool EPrimeiraInscricao(int numeroAluno, int idUC)
        {
            // Usa o método que criámos há pouco no repositório
            var historico = _inscricaoRepo.ObterPorAlunoEUnidade(numeroAluno, idUC);

            // Se a lista estiver vazia (Count == 0), é a primeira vez!
            return historico.Count == 0;
        }

        /// <summary>
        /// Valida se um aluno pode inscrever-se numa determinada época.
        /// Regras: Precedência de épocas e aprovação.
        /// </summary>
        public void ValidarInscricao(int numeroAluno, int idUC, int anoLetivo, string idEpoca)
        {
            // 1. Obter o histórico de inscrições deste aluno nesta UC
            var inscricoesDoAluno = _inscricaoRepo.ObterPorAlunoEUnidade(numeroAluno, idUC);

            // Filtra apenas para o ano letivo atual (opcional, depende da regra da escola)
            var inscricoesNoAno = inscricoesDoAluno.Where(i => i.IdAnoLetivo == anoLetivo).ToList();

            // 2. Regra para Época de Recurso (EREC)
            if (idEpoca == "EREC")
            {
                // Verifica se existe alguma inscrição na Época Normal (ENEX) ou Frequência (EFRE)
                bool foiANormal = inscricoesNoAno.Any(i => i.IdEpocaAvaliacao == "ENEX" || i.IdEpocaAvaliacao == "EFRE");

                if (!foiANormal)
                {
                    throw new Exception("Regra de Precedência: O aluno não pode inscrever-se em Recurso sem ter estado inscrito na Época Normal/Frequência.");
                }
            }

            // 3. Regra para Época Especial (EESP)
            if (idEpoca == "EESP")
            {
                // Verifica se foi a Recurso
                bool foiARecurso = inscricoesNoAno.Any(i => i.IdEpocaAvaliacao == "EREC");

                if (!foiARecurso)
                {
                    throw new Exception("Regra de Precedência: A Época Especial só está disponível após a Época de Recurso.");
                }
            }

            // 4. Regra de Aprovados (Não pode repetir se já passou)
            bool jaPassou = inscricoesDoAluno.Any(i => i.Nota >= 10);
            if (jaPassou)
            {
                throw new Exception("O aluno já obteve aprovação a esta Unidade Curricular.");
            }
        }

        /// <summary>
        /// Lança a nota de um aluno e aplica as regras de transição de época automática.
        /// </summary>
        public void LancarNota(int idAluno, int idUC, int idAno, string idEpoca, short nota, string presenca)
        {
            // 1. Buscar a inscrição original
            var inscricao = _inscricaoRepo.ObterPorChave(idAluno, idUC, idAno, idEpoca);

            if (inscricao == null)
                throw new Exception("Inscrição não encontrada.");

            // 2. Atualizar os dados
            inscricao.Nota = nota;
            inscricao.Presenca = presenca; // "P" ou "F"

            // 3. Determinar o Estado (Aprovado / Reprovado)
            if (nota >= 10 && presenca == "P")
            {
                inscricao.IdEstadoEpoca = 30; // 30 = Aprovado (conforme Charter)
            }
            else
            {
                inscricao.IdEstadoEpoca = 20; // 20 = Reprovado

                // --- REGRA DE OURO: AUTOMAÇÃO ---
                // Se chumbou na Frequência (EFRE), inscreve automaticamente na Normal (ENEX)
                if (idEpoca == "EFRE")
                {
                    // Verificar se já não existe a inscrição em ENEX (para não duplicar)
                    bool jaExisteNormal = _inscricaoRepo.ExisteInscricao(idAluno, idUC, idAno, "ENEX");

                    if (!jaExisteNormal)
                    {
                        var novaInscricao = new Inscricao
                        {
                            NumeroAluno = idAluno,
                            IdUnidadeCurricular = idUC,
                            IdAnoLetivo = (short)idAno,
                            IdEpocaAvaliacao = "ENEX", // <--- A Magia: Época Normal
                            IdEstadoEpoca = 10,       // 10 = Admitido
                            Presenca = "F",           // Reset
                            Nota = null               // Sem nota ainda
                        };

                        _inscricaoRepo.Adicionar(novaInscricao);
                    }
                }
            }

            // 4. Gravar alterações na inscrição original
            _inscricaoRepo.Atualizar(inscricao);
        }
    }
}