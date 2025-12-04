using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class EstadoEpoca
{
    public short Id { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Inscricao> Inscricaos { get; set; } = new List<Inscricao>();
}
