using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SGA_POO.Negocio.Entidades;

namespace SGA_POO.Dados.Entidades;

public partial class EscolaDBContext : DbContext
{
    public EscolaDBContext()
    {
    }

    public EscolaDBContext(DbContextOptions<EscolaDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<AnoLetivo> AnoLetivos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<EpocaAvaliacao> EpocaAvaliacaos { get; set; }

    public virtual DbSet<EstadoEpoca> EstadoEpocas { get; set; }

    public virtual DbSet<Inscricao> Inscricaos { get; set; }

    public virtual DbSet<UnidadeCurricular> UnidadeCurriculars { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK_Aluno_numero");

            entity.ToTable("Aluno");

            entity.Property(e => e.Numero)
                .ValueGeneratedNever()
                .HasColumnName("numero");
            entity.Property(e => e.Apelido)
                .HasMaxLength(150)
                .HasColumnName("apelido");
            entity.Property(e => e.DataNascimento).HasColumnName("dataNascimento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Foto)
                .HasColumnType("image")
                .HasColumnName("foto");
            entity.Property(e => e.Morada)
                .HasMaxLength(255)
                .HasColumnName("morada");
            entity.Property(e => e.NomeProprio)
                .HasMaxLength(100)
                .HasColumnName("nomeProprio");
            entity.Property(e => e.ReferenciaCurso).HasColumnName("referenciaCurso");
            entity.Property(e => e.Telefone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefone");

            entity.HasOne(d => d.ReferenciaCursoNavigation).WithMany(p => p.Alunos)
                .HasForeignKey(d => d.ReferenciaCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Aluno_Curso_referenciaCurso_referencia");
        });

        modelBuilder.Entity<AnoLetivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AnoLetivo_id");

            entity.ToTable("AnoLetivo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AnoFinal).HasColumnName("anoFinal");
            entity.Property(e => e.AnoInicial).HasColumnName("anoInicial");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Referencia).HasName("PK_Curso_id");

            entity.ToTable("Curso");

            entity.Property(e => e.Referencia)
                .ValueGeneratedNever()
                .HasColumnName("referencia");
            entity.Property(e => e.DataInicio).HasColumnName("dataInicio");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("nome");
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .HasColumnName("sigla");
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK_Docente_numero");

            entity.ToTable("Docente");

            entity.Property(e => e.Numero)
                .ValueGeneratedNever()
                .HasColumnName("numero");
            entity.Property(e => e.Apelido)
                .HasMaxLength(150)
                .HasColumnName("apelido");
            entity.Property(e => e.DataNascimento).HasColumnName("dataNascimento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Extensao)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("extensao");
            entity.Property(e => e.NomeProprio)
                .HasMaxLength(100)
                .HasColumnName("nomeProprio");
            entity.Property(e => e.Salario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("salario");
            entity.Property(e => e.Telefone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<EpocaAvaliacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EpocaAvaliacao_id");

            entity.ToTable("EpocaAvaliacao");

            entity.Property(e => e.Id)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<EstadoEpoca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EstadoEpoca_id");

            entity.ToTable("EstadoEpoca");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<Inscricao>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAluno, e.IdUnidadeCurricular, e.IdAnoLetivo, e.IdEpocaAvaliacao }).HasName("PK_Inscricao_numeroAluno_idUnidadeCurricular_idAnoLetivo_idEpocaAvaliacao");

            entity.ToTable("Inscricao");

            entity.Property(e => e.NumeroAluno).HasColumnName("numeroAluno");
            entity.Property(e => e.IdUnidadeCurricular).HasColumnName("idUnidadeCurricular");
            entity.Property(e => e.IdAnoLetivo).HasColumnName("idAnoLetivo");
            entity.Property(e => e.IdEpocaAvaliacao)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idEpocaAvaliacao");
            entity.Property(e => e.IdEstadoEpoca).HasColumnName("idEstadoEpoca");
            entity.Property(e => e.Nota).HasColumnName("nota");
            entity.Property(e => e.Presenca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("presenca");

            entity.HasOne(d => d.IdAnoLetivoNavigation).WithMany(p => p.Inscricaos)
                .HasForeignKey(d => d.IdAnoLetivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_AnoLetivo_idAnoLetivo_id");

            entity.HasOne(d => d.IdEpocaAvaliacaoNavigation).WithMany(p => p.Inscricaos)
                .HasForeignKey(d => d.IdEpocaAvaliacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_EpocaAvaliacao_idEpocaAvaliacao_id");

            entity.HasOne(d => d.IdEstadoEpocaNavigation).WithMany(p => p.Inscricaos)
                .HasForeignKey(d => d.IdEstadoEpoca)
                .HasConstraintName("FK_Inscricao_EstadoEpoca_idEstadoEpoca_id");

            entity.HasOne(d => d.IdUnidadeCurricularNavigation).WithMany(p => p.Inscricaos)
                .HasForeignKey(d => d.IdUnidadeCurricular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_UnidadeCurricular_idUnidadeCurricular_id");

            entity.HasOne(d => d.NumeroAlunoNavigation).WithMany(p => p.Inscricaos)
                .HasForeignKey(d => d.NumeroAluno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscricao_Aluno_numeroAluno_numero");
        });

        modelBuilder.Entity<UnidadeCurricular>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UnidadeCurricular_id");

            entity.ToTable("UnidadeCurricular");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ano)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ano");
            entity.Property(e => e.Creditos)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("creditos");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");
            entity.Property(e => e.NumeroDocente).HasColumnName("numeroDocente");
            entity.Property(e => e.ReferenciaCurso).HasColumnName("referenciaCurso");
            entity.Property(e => e.Semestre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("semestre");
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .HasColumnName("sigla");

            entity.HasOne(d => d.NumeroDocenteNavigation).WithMany(p => p.UnidadeCurriculars)
                .HasForeignKey(d => d.NumeroDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadeCurricular_Docente_numeroDocente_numero");

            entity.HasOne(d => d.ReferenciaCursoNavigation).WithMany(p => p.UnidadeCurriculars)
                .HasForeignKey(d => d.ReferenciaCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadeCurricular_Curso_referenciaCurso_referencia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
