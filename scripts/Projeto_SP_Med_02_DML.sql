USE Clinica_SP_Medical_Group;


INSERT INTO clinica (cnpj,nomeFantasia , endereco, dias, horarioabertura, horariofechamento, razaoSocial)
VALUES	('86400902000130', 'Clinica Possarle ', 'Av. Barão Limeira, 532, São Paulo, SP', 'Segunda a Sexta', '08:00:00', '17:00:00','SP Medical Group');


INSERT INTO TiposUsuarios (tipoUsuario)
VALUES	('Administrador'),
		('Médico'),
		('Paciente');


INSERT INTO especialidade( nomeEspecialidade)
VALUES	('Acupuntura'),
		('Anestesiologia'),
		('Angiologia'),
		('Cardiologia'),
		('Cirurgia Cardiovascular'),
		('Cirurgia da Mão'),
		('Cirurgia do Aparelho Digestivo'),
		('Cirurgia Geral'),
		('Cirurgia Pediátrica'),
		('Cirurgia Plástica'),
		('Cirurgia Torácica'),
		('Cirurgia Vascular'),
		('Dermatologia'),
		('Radioterapia'),
		('Urologia'),
		('Pediatria'),
		('Psiquiatria');

INSERT INTO usuario(idTipoUsuario, email, senha)
VALUES	(1,'adm@adm.com', 'adm123'),
		(2,'ricardo.lemos@spmedicalgroup.com.br', 'ricardo123'),
		(2,'roberto.possarle@spmedicalgroup.com.br', 'roberto123'),
		(2, 'helena.souza@spmedicalgroup.com.br','helena123'),
		(3, 'ligia@gmail.com','ligia123'),
		(3, 'alexandre@gmail.com','alexandre123'),
		(3, 'fernando@gmail.com','fernando123'),
		(3, 'henrique@gmail.com','henrique123'),
		(3, 'joao@hotmail.com','joao123'),
		(3, 'bruno@gmail.com','bruno123'),
		(3, 'mariana@outlook.com','mariana123');

INSERT INTO paciente(idUsuario, dataNascimento, telefone, rg, cpf, endereco, nome)
VALUES	(5, '13/10/1983', '11 3456-7654', '435225435', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000', 'Ligia'),
		(6, '23/07/2001', '11 98765-6543', '326543457', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200', 'Alexandre'),
		(7, '10/10/1978', '11 97208-4453', '546365253', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927, São Paulo - SP, 04029-200', 'Fernando'),
		(8, '13/10/1985', '11 3456-6543', '543663625', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030', 'Henrique'),
		(9, '27/08/1975', '11 7656-6377', '325444441', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380', 'João'),
		(10, '21/03/1972', '11 95436-8769', '545662667', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001', 'Bruno'),
		(11, '03/05/2018', '', '545662668', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140', 'Mariana');

INSERT INTO medico(idUsuario, idClinica, idEspecialidade, crm, nome)
VALUES	(2, 1, 2, '54356-SP', 'Ricardo Lemos'),
		(3, 1, 17, '53452-SP','Roberto Possarle'),
		(4, 1, 16, '65463-SP', 'Helena Strada');


INSERT INTO consulta(idPaciente, idMedico, dataConsulta)
VALUES	(7, 4, '20/01/2020 15:00:00'),
		(2, 3, '01/06/2020  10:00:00'),
		(3, 3, '02/07/2020  11:00:00'),
		(2, 3, '02/06/2018  10:00:00'),
		(4, 2, '02/07/2019  11:00:00'),
		(7, 4, '03/08/2020  15:00:00'),
		(4, 2, '03/09/2020  11:00:00');

INSERT INTO situacao(idConsulta, situacao)
VALUES	(8, 'Realizada')
		,(9, 'Cancelada')
		,(10, 'Realizada')
		,(11, 'Realizada')
		,(12, 'Cancelada')
		,(13, 'Agendada')
		,(14, 'Agendada');
