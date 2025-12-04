using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class AnoLetivo
{
    public short Id { get; set; }

    public short AnoInicial { get; set; }

    public short AnoFinal { get; set; }

    public virtual ICollection<Inscricao> Inscricaos { get; set; } = new List<Inscricao>();
}
