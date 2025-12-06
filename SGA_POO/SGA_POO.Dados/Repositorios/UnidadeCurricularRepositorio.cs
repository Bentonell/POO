using Microsoft.EntityFrameworkCore; // Importante para o Include
using SGA_POO.Dados.Entidades;
using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGA_POO.Dados.Repositorios
{
    public class UnidadeCurricularRepositorio : IUnidadeCurricularRepositorio
    {
        private readonly EscolaDBContext _context;

        public UnidadeCurricularRepositorio(EscolaDBContext context)
        {
            _context = context;
        }

        public List<UnidadeCurricular> ObterTodas()
        {
            // O .Include traz os dados do Curso e Docente (tipo JOIN)
            return _context.UnidadeCurriculars
                .Include(uc => uc.ReferenciaCursoNavigation)
                .Include(uc => uc.NumeroDocenteNavigation)
                .ToList();
        }

        public UnidadeCurricular ObterPorId(int id)
        {
            return _context.UnidadeCurriculars.Find(id);
        }

        public void Adicionar(UnidadeCurricular uc)
        {
            _context.UnidadeCurriculars.Add(uc);
            _context.SaveChanges();
        }

        public void Atualizar(UnidadeCurricular uc)
        {
            _context.UnidadeCurriculars.Update(uc);
            _context.SaveChanges();
        }

        public void Apagar(int id)
        {
            var uc = ObterPorId(id);
            if (uc != null)
            {
                _context.UnidadeCurriculars.Remove(uc);
                _context.SaveChanges();
            }
        }
    }
}