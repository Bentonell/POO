using Microsoft.EntityFrameworkCore;
using SGA_POO.Dados.Entidades;
using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGA_POO.Dados.Repositorios
{
    public class InscricaoRepositorio : IInscricaoRepositorio
    {
        private readonly EscolaDBContext _context;

        public InscricaoRepositorio(EscolaDBContext context)
        {
            _context = context;
        }

        public List<Inscricao> ObterTodas()
        {
            // Traz os dados relacionados para podermos mostrar nomes na grelha
            return _context.Inscricaos
                .Include(i => i.NumeroAlunoNavigation)
                .Include(i => i.IdUnidadeCurricularNavigation)
                .Include(i => i.IdEpocaAvaliacaoNavigation)
                .ToList();
        }

        public List<Inscricao> ObterPorUC(int idUC)
        {
            return _context.Inscricaos
                .Include(i => i.NumeroAlunoNavigation)
                .Where(i => i.IdUnidadeCurricular == idUC)
                .ToList();
        }

        public List<Inscricao> ObterPorAlunoEUnidade(int idAluno, int idUC)
        {
            // Vai à BD buscar todas as inscrições deste aluno nesta cadeira (histórico)
            return _context.Inscricaos
                .Where(i => i.NumeroAluno == idAluno && i.IdUnidadeCurricular == idUC)
                .ToList();
        }

        public bool ExisteInscricao(int idAluno, int idUC, int idAno, string idEpoca)
        {
            // Verifica se este aluno já está inscrito nesta UC neste ano/época
            return _context.Inscricaos.Any(i =>
                i.NumeroAluno == idAluno &&
                i.IdUnidadeCurricular == idUC &&
                i.IdAnoLetivo == (short)idAno &&
                i.IdEpocaAvaliacao == idEpoca);
        }

        public void Adicionar(Inscricao inscricao)
        {
            _context.Inscricaos.Add(inscricao);
            _context.SaveChanges();
        }

        public void Apagar(int idAluno, int idUC, int idAno, string idEpoca)
        {
            // A chave primária é composta por 4 campos!
            var inscricao = _context.Inscricaos.Find(idAluno, idUC, (short)idAno, idEpoca);
            if (inscricao != null)
            {
                _context.Inscricaos.Remove(inscricao);
                _context.SaveChanges();
            }
        }

        public Inscricao ObterPorChave(int idAluno, int idUC, int idAno, string idEpoca)
        {
            // Busca a inscrição específica (sem tracking para ser mais leve, ou com se quisermos editar direto)
            return _context.Inscricaos.FirstOrDefault(i =>
                i.NumeroAluno == idAluno &&
                i.IdUnidadeCurricular == idUC &&
                i.IdAnoLetivo == (short)idAno &&
                i.IdEpocaAvaliacao == idEpoca);
        }

        public void Atualizar(Inscricao inscricao)
        {
            _context.Inscricaos.Update(inscricao);
            _context.SaveChanges();
        }
    }
}