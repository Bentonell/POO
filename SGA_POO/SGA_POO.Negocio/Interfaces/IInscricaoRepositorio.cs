using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    public interface IInscricaoRepositorio
    {
        List<Inscricao> ObterTodas();
        List<Inscricao> ObterPorUC(int idUC);
        bool ExisteInscricao(int idAluno, int idUC, int idAno, string idEpoca);
        void Adicionar(Inscricao inscricao);
        void Apagar(int idAluno, int idUC, int idAno, string idEpoca);
    }
}