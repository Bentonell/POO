using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class Aluno
{
    public int Numero { get; set; }

    public int ReferenciaCurso { get; set; }

    public string NomeProprio { get; set; } = null!;

    public string Apelido { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public string Morada { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Telefone { get; set; }

    public byte[]? Foto { get; set; }

    public virtual ICollection<Inscricao> Inscricaos { get; set; } = new List<Inscricao>();

    public virtual Curso ReferenciaCursoNavigation { get; set; } = null!;
}
