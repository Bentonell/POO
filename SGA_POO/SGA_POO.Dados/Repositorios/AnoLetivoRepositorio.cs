using SGA_POO.Dados.Entidades;
using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGA_POO.Dados.Repositorios
{
    public class AnoLetivoRepositorio : IAnoLetivoRepositorio
    {
        private readonly EscolaDBContext _context;

        public AnoLetivoRepositorio(EscolaDBContext context)
        {
            _context = context;
        }

        public List<AnoLetivo> ObterTodos()
        {
            return _context.AnoLetivos.ToList();
        }

        public AnoLetivo ObterPorId(int id)
        {
            // O Find aceita short (smallint) se a chave for desse tipo
            return _context.AnoLetivos.Find((short)id);
        }

        public void Adicionar(AnoLetivo ano)
        {
            _context.AnoLetivos.Add(ano);
            _context.SaveChanges();
        }

        public void Atualizar(AnoLetivo ano)
        {
            _context.AnoLetivos.Update(ano);
            _context.SaveChanges();
        }

        public void Apagar(int id)
        {
            var ano = ObterPorId(id);
            if (ano != null)
            {
                _context.AnoLetivos.Remove(ano);
                _context.SaveChanges();
            }
        }
    }
}