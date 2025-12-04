using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class EpocaAvaliacao
{
    public string Id { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Inscricao> Inscricaos { get; set; } = new List<Inscricao>();
}
