using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class UnidadeCurricular
{
    public int Id { get; set; }

    public int ReferenciaCurso { get; set; }

    public int NumeroDocente { get; set; }

    public string Nome { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public decimal Creditos { get; set; }

    public string Ano { get; set; } = null!;

    public string Semestre { get; set; } = null!;

    public virtual ICollection<Inscricao> Inscricaos { get; set; } = new List<Inscricao>();

    public virtual Docente NumeroDocenteNavigation { get; set; } = null!;

    public virtual Curso ReferenciaCursoNavigation { get; set; } = null!;
}
