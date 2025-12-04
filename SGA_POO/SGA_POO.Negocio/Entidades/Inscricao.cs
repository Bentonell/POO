using System;
using System.Collections.Generic;

namespace SGA_POO.Negocio.Entidades;

public partial class Inscricao
{
    public int NumeroAluno { get; set; }

    public int IdUnidadeCurricular { get; set; }

    public short IdAnoLetivo { get; set; }

    public string IdEpocaAvaliacao { get; set; } = null!;

    public short? IdEstadoEpoca { get; set; }

    public string? Presenca { get; set; }

    public short? Nota { get; set; }

    public virtual AnoLetivo IdAnoLetivoNavigation { get; set; } = null!;

    public virtual EpocaAvaliacao IdEpocaAvaliacaoNavigation { get; set; } = null!;

    public virtual EstadoEpoca? IdEstadoEpocaNavigation { get; set; }

    public virtual UnidadeCurricular IdUnidadeCurricularNavigation { get; set; } = null!;

    public virtual Aluno NumeroAlunoNavigation { get; set; } = null!;
}
