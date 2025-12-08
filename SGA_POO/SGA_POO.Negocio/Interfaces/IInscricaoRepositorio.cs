using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    public interface IInscricaoRepositorio
    {
        List<Inscricao> ObterTodas();
        List<Inscricao> ObterPorUC(int idUC);
        List<Inscricao> ObterPorAlunoEUnidade(int idAluno, int idUC);
        bool ExisteInscricao(int idAluno, int idUC, int idAno, string idEpoca);
        void Adicionar(Inscricao inscricao);
        void Apagar(int idAluno, int idUC, int idAno, string idEpoca);
        // Novos métodos necessários para lançar notas
        Inscricao ObterPorChave(int idAluno, int idUC, int idAno, string idEpoca);
        void Atualizar(Inscricao inscricao);
    }
}