using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    public interface ICursoRepositorio
    {
        List<Curso> ObterTodos();
        Curso ObterPorId(int referencia);
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
        void Apagar(int referencia);
    }
}