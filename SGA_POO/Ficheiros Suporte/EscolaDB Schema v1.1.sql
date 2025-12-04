USE master
GO

IF DB_ID(N'EscolaDB') IS NOT NULL
	DROP DATABASE EscolaDB;
GO

CREATE DATABASE EscolaDB;
GO

USE EscolaDB
GO

-------------------------------------------------
-- Tabela de estados de �pocas de avalia��o.
-- Nesta tabela s�o registados os estados poss�veis de uma �poca de avalia��o.
-------------------------------------------------
CREATE TABLE EstadoEpoca(
id SMALLINT,
descricao NVARCHAR(50) NOT NULL,
CONSTRAINT [PK_EstadoEpoca_id] PRIMARY KEY (id)
)
GO

-------------------------------------------------
-- Tabela de anos letivos.
-- Nesta tabela s�o registadas os anos letivos.
-------------------------------------------------
CREATE TABLE AnoLetivo(
id			SMALLINT,
anoInicial	SMALLINT NOT NULL,
anoFinal	SMALLINT NOT NULL,
CONSTRAINT [PK_AnoLetivo_id] PRIMARY KEY (id)
)
GO

-------------------------------------------------
-- Tabela de �pocas de avalia��o.
-- Nesta tabela s�o registadas as �pocas de avalia��o.
-------------------------------------------------
CREATE TABLE EpocaAvaliacao (
id			CHAR(4),
descricao	NVARCHAR(100) NOT NULL,
CONSTRAINT [PK_EpocaAvaliacao_id] PRIMARY KEY (id)
)
GO

-------------------------------------------------
-- Tabela de cursos.
-- Nesta tabela s�o registadas os cursos.
-------------------------------------------------
CREATE TABLE Curso(
  referencia	INTEGER NOT NULL, 
  nome			NVARCHAR(255) NOT NULL,
  sigla			NVARCHAR(10) NOT NULL,
  dataInicio	DATE NOT NULL, 
  CONSTRAINT [PK_Curso_id] PRIMARY KEY (referencia),
)
GO

-------------------------------------------------
-- Tabela de docentes.
-- Nesta tabela s�o registadas todos os docentes.
-------------------------------------------------
CREATE TABLE Docente(
  numero            INTEGER NOT NULL, 
  nomeProprio		NVARCHAR(100) NOT NULL, 
  apelido			NVARCHAR(150) NOT NULL, 
  dataNascimento	DATE NULL,
  email				NVARCHAR(100) NULL,
  telefone			CHAR(12) NULL,
  extensao			CHAR(5) NULL,
  salario			DECIMAL(10,2) NOT NULL, 
  CONSTRAINT [PK_Docente_numero] PRIMARY KEY (numero),
)
GO

-------------------------------------------------
-- Tabela de alunos.
-- Nesta tabela s�o registadas todos os alunos.
-------------------------------------------------
CREATE TABLE Aluno(
  numero            INTEGER NOT NULL,
  referenciaCurso	INTEGER NOT NULL, 
  nomeProprio		NVARCHAR(100) NOT NULL, 
  apelido			NVARCHAR(150) NOT NULL, 
  dataNascimento	DATE NOT NULL,
  morada			NVARCHAR(255) NOT NULL,
  email				NVARCHAR(100) NOT NULL,
  telefone			CHAR(12) NULL,
  foto				IMAGE NULL,
  CONSTRAINT [PK_Aluno_numero] PRIMARY KEY(numero),
  CONSTRAINT [FK_Aluno_Curso_referenciaCurso_referencia] FOREIGN KEY(referenciaCurso) REFERENCES Curso(referencia)
)
GO

-------------------------------------------------
-- Tabela de unidades curriculares.
-- Nesta tabela s�o registadas todas as unidades curriculares.
-------------------------------------------------
CREATE TABLE UnidadeCurricular (
  id				INTEGER NOT NULL,
  referenciaCurso	INTEGER NOT NULL, 
  numeroDocente		INTEGER NOT NULL, 
  nome				NVARCHAR(100) NOT NULL,
  sigla				NVARCHAR(10) NOT NULL,
  creditos			DECIMAL(10,2) NOT NULL, 
  ano				CHAR(1) NOT NULL,
  semestre			CHAR(1) NOT NULL,
  CONSTRAINT [PK_UnidadeCurricular_id] PRIMARY KEY (id),
  CONSTRAINT [FK_UnidadeCurricular_Curso_referenciaCurso_referencia] FOREIGN KEY(referenciaCurso) REFERENCES Curso(referencia),
  CONSTRAINT [FK_UnidadeCurricular_Docente_numeroDocente_numero] FOREIGN KEY(numeroDocente) REFERENCES Docente(numero)
)
GO

-------------------------------------------------
-- Tabela de inscri��es em unidades curriculares.
-- Nesta tabela s�o registadas todas as inscri��es de um aluno em unidades curriculares
-- num determinado ano letivo, numa determinada �poca de avalia��o.
-------------------------------------------------
CREATE TABLE Inscricao(
  numeroAluno			INTEGER NOT NULL,
  idUnidadeCurricular	INTEGER NOT NULL,
  idAnoLetivo			SMALLINT NOT NULL,
  idEpocaAvaliacao		CHAR(4) NOT NULL,
  idEstadoEpoca			SMALLINT NULL,
  presenca				CHAR(1) NULL,
  nota					SMALLINT NULL
  CONSTRAINT [PK_Inscricao_numeroAluno_idUnidadeCurricular_idAnoLetivo_idEpocaAvaliacao] PRIMARY KEY(numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao),
  CONSTRAINT [FK_Inscricao_Aluno_numeroAluno_numero] FOREIGN KEY(numeroAluno) REFERENCES Aluno(numero),
  CONSTRAINT [FK_Inscricao_UnidadeCurricular_idUnidadeCurricular_id] FOREIGN KEY(idUnidadeCurricular) REFERENCES UnidadeCurricular(id),
  CONSTRAINT [FK_Inscricao_AnoLetivo_idAnoLetivo_id] FOREIGN KEY(idAnoLetivo) REFERENCES AnoLetivo(id),
  CONSTRAINT [FK_Inscricao_EstadoEpoca_idEstadoEpoca_id] FOREIGN KEY(idEstadoEpoca) REFERENCES EstadoEpoca(id),
  CONSTRAINT [FK_Inscricao_EpocaAvaliacao_idEpocaAvaliacao_id] FOREIGN KEY(idEpocaAvaliacao) REFERENCES EpocaAvaliacao(id)
)
GO