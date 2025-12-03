USE EscolaDB;



INSERT INTO EstadoEpoca(id, descricao) VALUES(10, 'Admitido');
INSERT INTO EstadoEpoca(id, descricao) VALUES(20, 'Reprovado');
INSERT INTO EstadoEpoca(id, descricao) VALUES(30, 'Aprovado');


/****** Tabela AnoLetivo ******/

INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (1819, 2018, 2019);
INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (1920, 2019, 2020);
INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (2021, 2020, 2021);
INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (2122, 2021, 2022);
INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (2223, 2022, 2023);
INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (2324, 2023, 2024);
INSERT INTO AnoLetivo (id, anoInicial, anoFinal) VALUES (2425, 2024, 2025);




/****** Tabela EpocaAvaliacao ******/

INSERT INTO EpocaAvaliacao (id, descricao) VALUES ('EFRE', 'Época de Frequência');
INSERT INTO EpocaAvaliacao (id, descricao) VALUES ('ENEX', 'Época Normal de Exame');
INSERT INTO EpocaAvaliacao (id, descricao) VALUES ('EREC', 'Época de Recurso');
INSERT INTO EpocaAvaliacao (id, descricao) VALUES ('EESP', 'Época Especial');



/****** Tabela Curso ******/

INSERT INTO Curso (referencia, nome, sigla, dataInicio) VALUES (100, 'Informática e Tecnologias Multimédia','ITM', '2010-10-10');
INSERT INTO Curso (referencia, nome, sigla, dataInicio) VALUES (200, 'Engenharia Mecânica', 'EM', '1993-3-3');
INSERT INTO Curso (referencia, nome, sigla, dataInicio) VALUES (300, 'Gestão e Administração', 'GA', '2005-5-5');
INSERT INTO Curso (referencia, nome, sigla, dataInicio) VALUES (400, 'Engenharia Civil', 'EC', '1998-8-8');
INSERT INTO Curso (referencia, nome, sigla, dataInicio) VALUES (500, 'Biotecnologia', 'BIO', '2012-12-12');




/****** Tabela Docente ******/

INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario) 
    VALUES (1000, 'Rui', 'Rodrigues', '1970-7-7', 'rui.rodrigues@ipk.pt', '997777777', '10001',150000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
    VALUES (2000, 'Pedro', 'Paz Pina', '1960-6-6', 'pedro.pina@ipk.pt', '99666666', '10002',95000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
	VALUES (3000, 'Luísa Lara', 'Lopes', '1980-8-8', 'luisa.lopes@ipk.pt', '9978888888', '10003',98000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
	VALUES (4000, 'José', 'Jesus', '1975-7-5', 'jose.jesus@ipk.pt', '995555555', '20001',250000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
	VALUES (5000, 'Cristina', 'Costa', '1984-8-4', 'cristina.costa@ipk.pt', '994444444', '20002',170000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
    VALUES (6000, 'Ana', 'Almeida', '1972-12-12', 'ana.almeida@ipk.pt', '993333333', '20003', 120000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
    VALUES (7000, 'Miguel', 'Monteiro', '1982-2-2', 'miguel.monteiro@ipk.pt', '992222222', '20004', 110000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
    VALUES (8000, 'Carla', 'Carvalho', '1978-3-3', 'carla.carvalho@ipk.pt', '991111111', '20005', 105000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
    VALUES (9000, 'Bruno', 'Borges', '1965-5-5', 'bruno.borges@ipk.pt', '990000000', '30001', 130000.00);
INSERT INTO Docente (numero, nomeProprio, apelido, dataNascimento, email, telefone, extensao, salario)
    VALUES (10000, 'Rita', 'Ramalho', '1986-9-9', 'rita.ramalho@ipk.pt', '998888888', '30002', 95000.00);




/****** Tabela Aluno ******/

INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (50123, 100, 'Maria Manuela', 'Manta', '2002-2-2', 'Rua Major Monteiro, Abrantes', 'aluno50123@ipw.pt', '995012300',NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (50456, 100, 'Abreu', 'Anjos', '2003-3-3', 'Avenida António Arrojo, Lisboa', 'aluno50456@ipw.pt', '995045600',NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (50789, 200, 'Berta', 'Belino', '1999-9-9', 'Travessa do Bernardino, Porto', 'aluno50789@ipw.pt', '995078900',NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (51012, 200, 'Carlos', 'Castro', '2001-1-1', 'Rua das Flores, Coimbra', 'aluno51012@ipw.pt', '995101200', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (51234, 100, 'Daniela', 'Dias', '2000-5-5', 'Rua dos Pescadores, Faro', 'aluno51234@ipw.pt', '995123400', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (51456, 200, 'Eduardo', 'Esteves', '2002-6-6', 'Avenida das Nações, Lisboa', 'aluno51456@ipw.pt', '995145600', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (51678, 300, 'Filipa', 'Ferreira', '2003-7-7', 'Largo do Carmo, Braga', 'aluno51678@ipw.pt', '995167800', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (51890, 300, 'Gonçalo', 'Gomes', '1998-8-8', 'Rua das Palmeiras, Aveiro', 'aluno51890@ipw.pt', '995189000', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (52101, 100, 'Helena', 'Henriques', '2001-4-4', 'Rua do Mercado, Leiria', 'aluno52101@ipw.pt', '995210100', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (52323, 200, 'Igor', 'Ivo', '1997-11-11', 'Rua Nova, Santarém', 'aluno52323@ipw.pt', '995232300', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (52545, 100, 'Joaquim', 'Jorge', '2002-2-20', 'Rua dos Caldeireiros, Guarda', 'aluno52545@ipw.pt', '995254500', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (52767, 300, 'Lúcia', 'Lourenço', '2000-10-10', 'Travessa das Oliveiras, Setúbal', 'aluno52767@ipw.pt', '995276700', NULL);
INSERT INTO Aluno (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone, foto) 
    VALUES (52989, 200, 'Manuel', 'Martins', '1999-12-12', 'Rua das Figueiras, Viseu', 'aluno52989@ipw.pt', '995298900', NULL);




/****** Tabela UnidadeCurricular ******/

INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (100011110, 100, 1000, 'Programação I', 'PI', 5.5, '1', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (100011120, 100, 2000, 'Introdução às Base de Dados', 'IBD', 5.0, '1', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (100012150, 100, 1000, 'Programação II', 'PII', 6.0, '1', '2');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (100031310, 100, 3000, 'Aprendizagem Automática', 'AA', 7.0, '3', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (200031110, 200, 5000, 'Gestão para Engenheiros', 'GPE', 4.5, '3', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (200032150, 200, 4000, 'Projeto Final', 'PF', 15.0, '3', '2');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (100021210, 100, 7000, 'Estruturas de Dados', 'ED', 6.0, '2', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (100022220, 100, 8000, 'Redes de Computadores', 'RC', 5.5, '2', '2');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (200011120, 200, 6000, 'Introdução à Engenharia Mecânica', 'IEM', 5.0, '1', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (200021230, 200, 9000, 'Termodinâmica', 'TD', 6.5, '2', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (300011110, 300, 10000, 'Contabilidade Geral', 'CG', 5.0, '1', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (300021210, 300, 1000, 'Gestão Financeira', 'GF', 6.0, '2', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (400011120, 400, 2000, 'Desenho Técnico', 'DT', 5.0, '1', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (500011210, 500, 3000, 'Biotecnologia Molecular', 'BM', 6.5, '1', '1');
	-- For referenciaCurso 300
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (300012120, 300, 6000, 'Marketing Digital', 'MD', 5.5, '1', '2');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (300022210, 300, 7000, 'Gestão de Recursos Humanos', 'GRH', 6.0, '2', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (300032220, 300, 8000, 'Empreendedorismo', 'EMP', 7.0, '3', '2');
-- For referenciaCurso 400
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (400012120, 400, 9000, 'Materiais de Construção', 'MC', 6.5, '1', '2');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (400022210, 400, 10000, 'Mecânica dos Solos', 'MS', 5.0, '2', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (400032220, 400, 1000, 'Hidráulica Aplicada', 'HA', 6.0, '3', '2');
-- For referenciaCurso 500
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (500012120, 500, 2000, 'Genética e Evolução', 'GE', 5.5, '1', '2');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (500022210, 500, 3000, 'Microbiologia', 'MIC', 6.0, '2', '1');
INSERT INTO UnidadeCurricular (id, referenciaCurso, numeroDocente, nome, sigla, creditos, ano, semestre) 
    VALUES (500032220, 500, 4000, 'Bioprocessos', 'BP', 7.0, '3', '2');





/****** Tabela Inscricao ******/

INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50123, 100011110, 2021, 'EFRE', 30, 'P', 17)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50123, 100011120, 2021, 'EFRE', 10, 'P', 8)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50123, 100011120, 2021, 'ENEX', 20, 'P', 9)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50123, 100011120, 2021, 'EREC', 30, 'P', 12)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50123, 100012150, 2021, 'EFRE', 10, 'F', NULL)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50123, 100012150, 2021, 'ENEX', 30, 'P', 14)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50456, 100011110, 2021, 'EFRE', 30, 'P', 14)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50456, 100011120, 2021, 'EFRE', 30, 'P', 16)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50789, 200031110, 2021, 'EFRE', 10, 'F', NULL)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50789, 200031110, 2021, 'ENEX', 20, 'F', NULL)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50789, 200031110, 2021, 'EREC', 20, 'P', 7)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50789, 200031110, 2021, 'EESP', 30, 'P', 10)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
	VALUES (50789, 200032150, 2021, 'EFRE', 30, 'P', 15)
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50456, 100012150, 2021, 'EFRE', 30, 'P', 13);
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50456, 100031310, 2021, 'EFRE', 30, 'P', 18);
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50456, 100031310, 2021, 'ENEX', 10, 'P', 12);
-- For student 50789 in different units and assessments
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50789, 200032150, 2021, 'ENEX', 20, 'P', 11);
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50789, 200032150, 2021, 'EREC', 30, 'P', 14);
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50789, 200032150, 2021, 'EESP', 10, 'P', 12);
-- For student 50123 in additional units
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50123, 100031310, 2021, 'EFRE', 20, 'P', 16);
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50123, 100031310, 2021, 'ENEX', 30, 'P', 12);
INSERT INTO Inscricao (numeroAluno, idUnidadeCurricular, idAnoLetivo, idEpocaAvaliacao, idEstadoEpoca, presenca, nota)
    VALUES (50123, 100031310, 2021, 'EREC', 10, 'P', 15);


