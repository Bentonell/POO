using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    public interface IDocenteRepositorio
    {
        List<Docente> ObterTodos();
        // Estes métodos faltavam:
        Docente ObterPorId(int numero);
        void Adicionar(Docente docente);
        void Atualizar(Docente docente);
        void Apagar(int numero);
    }
}