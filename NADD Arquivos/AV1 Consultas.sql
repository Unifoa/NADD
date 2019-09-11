-- CONSULTAS REFERENTES A AV1
-- SELECTS

-- RETORNAR NOME DE USUARIO, PERFIL DE USUARIO
SELECT USU_NOME NOME, PERF_NOME PERFIL
FROM TABELA_USUARIO U INNER JOIN TABELA_PERFIL P
ON (U.USU_PERFIL = P.PERF_ID)
ORDER BY USU_NOME;

-- RETORNA NOME DA AREA, NOME DO CURSO E QUANTIDADE DE PERIODOS
SELECT AREA_NOME AREA, CUR_NOME CURSO, CUR_NUM_PERIODOS "QUANTIDADE DE PERIDOS"
FROM TABELA_AREA A INNER JOIN TABELA_CURSO C
ON (A.AREA_ID = C.CUR_AREA)
ORDER BY AREA_NOME;

-- RETORNA NOME DO PROFESSOR, NOME DA DISCIPLINA, E A QUAL CURSO ESTA DISCIPLINA PERTENCE
SELECT PROF_NOME PROFESSOR, DIS_NOME DISCIPLINA, CUR_NOME CURSO
FROM TABELA_CURSO C JOIN TABELA_DISCIPLINA D
ON (C.CUR_ID = D.DIS_CURSO) INNER JOIN TABELA_DIS_PROF DP
ON (DP.DEP_DISCIPLINA = D.DIS_ID) INNER JOIN TABELA_PROFESSOR P
ON (P.PROF_ID = DP.DEP_PROFESSOR)
ORDER BY PROF_NOME;

-- RETONA O TOTAL DE PROFESSORES
SELECT COUNT(PROF_ID) "TOTAL DE PROFESSORES"
FROM TABELA_PROFESSOR;

-- RETORNA O TOTAL DE CURSO POR AREA,
SELECT AREA_NOME AREA, COUNT(CUR_ID) "TOTAL DE CURSOS"
FROM TABELA_AREA A INNER JOIN TABELA_CURSO C
ON (A.AREA_ID = C.CUR_AREA)
GROUP BY AREA_NOME;

-- RETORNA AS PROVAS COM A QUANTIDADE DE QUESTOES E OS PROFESSORES DAQUELA DISCIPLINA
SELECT DIS_NOME PROVA, PROVA_QNT_QUESTAO "QUANTIDADE DE QUEST�ES", PROF_NOME PROFESSOR
FROM TABELA_PROFESSOR P INNER JOIN TABELA_DIS_PROF DP
ON (P.PROF_ID = DP.DEP_PROFESSOR) INNER JOIN TABELA_DISCIPLINA D
ON (D.DIS_ID = DP.DEP_DISCIPLINA) INNER JOIN TABELA_PROVA PR
ON (PR.PROVA_DISCIPLINA = DP.DEP_DISCIPLINA);

-- RETORNA A DISCIPLINA, CURSO E A AREA A QUAL AQUELA DISCIPLINA PERTENCE
SELECT DIS_NOME DISCIPLINA, CUR_NOME CURSO, AREA_NOME AREA
FROM TABELA_DISCIPLINA D INNER JOIN TABELA_CURSO C
ON (D.DIS_CURSO = C.CUR_ID) INNER JOIN TABELA_AREA A
ON (A.AREA_ID = C.CUR_AREA)
ORDER BY AREA_NOME;

-- RETORNA AS PROVAS COM A QUANTIDADE DE QUESTOES E OS PROFESSORES DAQUELA DISCIPLINA
SELECT DIS_NOME PROVA, PROVA_QNT_QUESTAO "QUANTIDADE DE QUEST�ES", PROF_NOME PROFESSOR
FROM TABELA_PROFESSOR P INNER JOIN TABELA_DIS_PROF DP
ON (P.PROF_ID = DP.DEP_PROFESSOR) INNER JOIN TABELA_DISCIPLINA D
ON (D.DIS_ID = DP.DEP_DISCIPLINA) INNER JOIN TABELA_PROVA PR
ON (PR.PROVA_DISCIPLINA = DP.DEP_DISCIPLINA);

-- CONTA O TOTAL DE PROVAS AGRUPADAS POR PROVA, E RETORNA SOMENTE AS QUANTIDADE DE AVALIACOES DA PROVA 1
SELECT COUNT(AVA_PROVA)
FROM TABELA_AVALIACAO
GROUP BY AVA_PROVA
HAVING AVA_PROVA = 1;

-- CONTA O TOTAL DE PROVAS AGRUPADAS POR PROVA, E RETORNA SOMENTE AS AVALIACOES DA PROVA 2
SELECT COUNT(AVA_PROVA)
FROM TABELA_AVALIACAO
GROUP BY AVA_PROVA
HAVING AVA_PROVA = 2;

-- RETORNA A QUANTIDADE DE CURSOS POR AREA
SELECT AREA_NOME AREA, COUNT(CUR_ID) "QUANTIDADE DE CURSOS"
FROM TABELA_AREA A INNER JOIN TABELA_CURSO C
ON (A.AREA_ID = C.CUR_AREA)
GROUP BY AREA_NOME, AREA_ID
HAVING AREA_ID = 1;
