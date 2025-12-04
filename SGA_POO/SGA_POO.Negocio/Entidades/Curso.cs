using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class Curso
{
    public int Referencia { get; set; }

    public string Nome { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public DateOnly DataInicio { get; set; }

    public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

    public virtual ICollection<UnidadeCurricular> UnidadeCurriculars { get; set; } = new List<UnidadeCurricular>();
}
