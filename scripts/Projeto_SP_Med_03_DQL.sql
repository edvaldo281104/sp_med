USE Clinica_SP_Medical_Group;
SELECT * FROM clinica;
SELECT * FROM tiposUsuarios;
SELECT * FROM especialidade;
SELECT * FROM usuario;
SELECT * FROM paciente;
SELECT * FROM medico;
SELECT * FROM consulta;
SELECT * FROM situacao;

--3. O administrador poder� cancelar o agendamento;
--Para cancelar o agendamento selecione o idConsulta da situac�o a ser cancelada, exemplo a seguir:
UPDATE situacao
SET situacao = 'Cancelada'
WHERE idConsulta = '1';

--5. O m�dico poder� ver os agendamentos (consultas) associados a ele;

--Administra��o consegue ver todas as consultas por m�dico
SELECT medico.idMedico, medico.nome Medico, consulta.idConsulta, consulta.dataConsulta, paciente.nome Paciente FROM consulta
INNER JOIN medico
ON consulta.idMedico = medico.idMedico
INNER JOIN paciente
ON consulta.idPaciente = paciente.idPaciente
INNER JOIN situacao
ON consulta.idConsulta = situacao.idConsulta
ORDER BY idMedico;

--Cada m�dico ve as consultas associadas ao seu ID
SELECT medico.idMedico, medico.nome Medico, consulta.idConsulta, consulta.dataConsulta, paciente.nome Paciente FROM consulta
INNER JOIN medico
ON consulta.idMedico = medico.idMedico
INNER JOIN paciente
ON consulta.idPaciente = paciente.idPaciente
INNER JOIN situacao
ON consulta.idConsulta = situacao.idConsulta
WHERE consulta.idMedico LIKE '1';

--6. O m�dico poder� incluir a descri��o da consulta que estar� vinculada ao paciente (prontu�rio);
ALTER TABLE consulta ADD descricao VARCHAR(200);
GO
UPDATE consulta
SET descricao = 'O paciente apresentava sintomas semelhantes ao da COVID 19, foi encaminhado para os exames apropriados'
WHERE idConsulta = '1';
GO

--7. O paciente poder� visualizar suas pr�prias consultas;
--Administra��o consegue ver todas as consultas por paciente
SELECT paciente.idPaciente, paciente.nome Paciente, consulta.idConsulta, consulta.dataConsulta, situacao.situacao, medico.nome, especialidade.nomeEspecialidade FROM consulta
INNER JOIN paciente
ON consulta.idPaciente = paciente.idPaciente
RIGHT JOIN medico
ON consulta.idMedico = medico.idMedico
INNER JOIN situacao
ON consulta.idConsulta = situacao.idConsulta
INNER JOIN especialidade
ON medico.idEspecialidade = especialidade.idEspecialidade
ORDER BY idPaciente;

--Cada paciente ve as consultas de acordo com o seu id (exemplo )
SELECT paciente.idPaciente, paciente.nome Paciente, consulta.idConsulta, consulta.dataConsulta, situacao.situacao, medico.nome, especialidade.nomeEspecialidade FROM consulta
INNER JOIN paciente
ON consulta.idPaciente = paciente.idPaciente
RIGHT JOIN medico
ON consulta.idMedico = medico.idMedico
INNER JOIN situacao
ON consulta.idConsulta = situacao.idConsulta
INNER JOIN especialidade
ON medico.idEspecialidade = especialidade.idEspecialidade
WHERE consulta.idPaciente LIKE '2';
