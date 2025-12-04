using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class Docente
{
    public int Numero { get; set; }

    public string NomeProprio { get; set; } = null!;

    public string Apelido { get; set; } = null!;

    public DateOnly? DataNascimento { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public string? Extensao { get; set; }

    public decimal Salario { get; set; }

    public virtual ICollection<UnidadeCurricular> UnidadeCurriculars { get; set; } = new List<UnidadeCurricular>();
}
