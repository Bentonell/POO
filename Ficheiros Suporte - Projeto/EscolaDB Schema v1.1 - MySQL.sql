USE `mysql`;
DROP DATABASE IF EXISTS EscolaDB;

CREATE DATABASE EscolaDB;
USE EscolaDB;

CREATE TABLE EstadoEpoca(
  id SMALLINT,
  descricao NVARCHAR(50) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE AnoLetivo(
  id SMALLINT,
  anoInicial SMALLINT NOT NULL,
  anoFinal SMALLINT NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE EpocaAvaliacao (
  id CHAR(4),
  descricao NVARCHAR(100) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Curso(
  referencia INT NOT NULL,
  nome NVARCHAR(255) NOT NULL,
  sigla NVARCHAR(10) NOT NULL,
  dataInicio DATE NOT NULL,
  PRIMARY KEY (referencia)
);

CREATE TABLE Docente(
  numero INT NOT NULL,
  nomeProprio NVARCHAR(100) NOT NULL,
  apelido NVARCHAR(150) NOT NULL,
  dataNascimento DATE,
  email NVARCHAR(100),
  telefone CHAR(12),
  extensao CHAR(5),
  salario DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (numero)
);

CREATE TABLE Aluno(
  numero INT NOT NULL,
  referenciaCurso INT NOT NULL,
  nomeProprio NVARCHAR(100) NOT NULL,
  apelido NVARCHAR(150) NOT NULL,
  dataNascimento DATE NOT NULL,
  morada NVARCHAR(255) NOT NULL,
  email NVARCHAR(100) NOT NULL,
  telefone CHAR(12),
  foto BLOB,
  PRIMARY KEY(numero),
  FOREIGN KEY(referenciaCurso) REFERENCES Curso(referencia)
);

CREATE TABLE UnidadeCurricular (
  id INT NOT NULL,
  referenciaCurso INT NOT NULL,
  numeroDocente INT NOT NULL,
  nome NVARCHAR(100) NOT NULL,
  sigla NVARCHAR(10) NOT NULL,
  creditos DECIMAL(10,2) NOT NULL,
  ano CHAR(1) NOT NULL,
  semestre CHAR(1) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY(referenciaCurso) REFERENCES Curso(referencia),
  FOREIGN KEY(numeroDocente) REFERENCES Docente(numero)
);

CREATE TABLE Inscricao(
  numeroAluno INT NOT NULL,
  idUnidadeCurricular INT NOT NULL,
  idAnoLetivo SMALLINT NOT NULL,
  idEpocaAvaliacao CHAR(4) NOT NULL,
  idEstadoEpoca SMALLINT,
  presenca CHAR(1),
  nota SMALLINT,
  PRIMARY KEY(numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao),
  FOREIGN KEY(numeroAluno) REFERENCES Aluno(numero),
  FOREIGN KEY(idUnidadeCurricular) REFERENCES UnidadeCurricular(id),
  FOREIGN KEY(idAnoLetivo) REFERENCES AnoLetivo(id),
  FOREIGN KEY(idEstadoEpoca) REFERENCES EstadoEpoca(id),
  FOREIGN KEY(idEpocaAvaliacao) REFERENCES EpocaAvaliacao(id)
);
