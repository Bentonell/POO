using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    public interface IUnidadeCurricularRepositorio
    {
        List<UnidadeCurricular> ObterTodas();
        UnidadeCurricular ObterPorId(int id);
        void Adicionar(UnidadeCurricular uc);
        void Atualizar(UnidadeCurricular uc);
        void Apagar(int id);
    }
}