using SGA_POO.Dados.Entidades;
using SGA_POO.Negocio.Entidades;
using SGA_POO.Negocio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGA_POO.Dados.Repositorios
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        // Precisamos do Contexto para falar com a BD
        private readonly EscolaDBContext _context;

        // Injeção de Dependência: O "context" entra automaticamente aqui
        public AlunoRepositorio(EscolaDBContext context)
        {
            _context = context;
        }

        public List<Aluno> ObterTodos()
        {
            // Tradução: "Select * From Aluno"
            return _context.Alunos.ToList();
        }

        public Aluno ObterPorNumero(int numeroAluno)
        {
            // Procura o primeiro aluno com este número
            return _context.Alunos.FirstOrDefault(a => a.Numero == numeroAluno);
        }

        public void Adicionar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges(); // O "Commit" na base de dados
        }

        public void Editar(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }

        public void Apagar(int numeroAluno)
        {
            var alunoParaApagar = ObterPorNumero(numeroAluno);
            if (alunoParaApagar != null)
            {
                _context.Alunos.Remove(alunoParaApagar);
                _context.SaveChanges();
            }
        }
    }
}