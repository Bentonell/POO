using SGA_POO.Dados.Entidades;
using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGA_POO.Dados.Repositorios
{
    public class DocenteRepositorio : IDocenteRepositorio
    {
        private readonly EscolaDBContext _context;

        public DocenteRepositorio(EscolaDBContext context)
        {
            _context = context;
        }

        public List<Docente> ObterTodos()
        {
            return _context.Docentes.ToList();
        }

        // Implementação dos novos métodos
        public Docente ObterPorId(int numero)
        {
            return _context.Docentes.Find(numero);
        }

        public void Adicionar(Docente docente)
        {
            _context.Docentes.Add(docente);
            _context.SaveChanges();
        }

        public void Atualizar(Docente docente)
        {
            _context.Docentes.Update(docente);
            _context.SaveChanges();
        }

        public void Apagar(int numero)
        {
            var docente = ObterPorId(numero);
            if (docente != null)
            {
                _context.Docentes.Remove(docente);
                _context.SaveChanges();
            }
        }
    }
}