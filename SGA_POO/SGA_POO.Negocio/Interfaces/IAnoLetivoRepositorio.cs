using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    public interface IAnoLetivoRepositorio
    {
        List<AnoLetivo> ObterTodos();
        AnoLetivo ObterPorId(int id);
        void Adicionar(AnoLetivo ano);
        void Atualizar(AnoLetivo ano);
        void Apagar(int id);
    }
}