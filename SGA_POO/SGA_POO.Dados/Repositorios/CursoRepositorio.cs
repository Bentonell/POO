using SGA_POO.Dados.Entidades;
using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGA_POO.Dados.Repositorios
{
    public class CursoRepositorio : ICursoRepositorio
    {
        private readonly EscolaDBContext _context;

        public CursoRepositorio(EscolaDBContext context)
        {
            _context = context;
        }

        public List<Curso> ObterTodos()
        {
            return _context.Cursos.ToList();
        }

        public Curso ObterPorId(int referencia)
        {
            return _context.Cursos.Find(referencia);
        }

        public void Adicionar(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }

        public void Atualizar(Curso curso)
        {
            _context.Cursos.Update(curso);
            _context.SaveChanges();
        }

        public void Apagar(int referencia)
        {
            var curso = ObterPorId(referencia);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
        }
    }
}