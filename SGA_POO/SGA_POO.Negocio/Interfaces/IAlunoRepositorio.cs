using SGA_POO.Negocio.Entidades;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Interfaces
{
    // Interface: É um contrato. Quem quiser ser um "AlunoRepositorio"
    // é OBRIGADO a saber fazer estas 5 coisas.
    public interface IAlunoRepositorio
    {
        List<Aluno> ObterTodos();
        Aluno ObterPorNumero(int numeroAluno);
        void Adicionar(Aluno aluno);
        void Editar(Aluno aluno);
        void Apagar(int numeroAluno);
    }
}