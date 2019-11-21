CREATE   OR ALTER    PROCEDURE PR_RELATORIO1 
(@pDataIni DATE,
@pDataFim DATE, 
@pCurso  nvarchar(5),
@pArea nvarchar(5), 
@pDisciplina nvarchar(5), 
@pProfessor nvarchar(5))
AS    
SET NOCOUNT ON;
    SELECT
		p.Id AS ProvaID,c.Cur_Nome,p.Prova_Avd AS Prova_AVD , p.Prova_Data as Prova_Data,
		((Case when sum (a.Ava_Valor_Questao)=p.Prova_Valor_Prova then 1 else 0 end) +p.Prova_Ref_Bibliografica + 
			(sum((a.Ava_Clareza/100 + a.Ava_Contextualizacao/100 +a.Ava_Complexibilidade+a.Ava_Questao_Explicito)/9)/(count(a.ProvasId)))*8 )*10 as Nota_da_Prova,
		CONCAT(d.Dis_Nome,' - ',d.Dis_Ano, (case when c.Cur_Ano_Sem=0 then CONCAT(' - ',d.Dis_Periodo/2, 'ano') else (CONCAT(' - periodo: ',d.Dis_Periodo)) end)) as Disciplina,
		PF.Prof_Nome as Prof_Nome,
		X.media as Media_Cur
	FROM CURSO C 
		INNER JOIN DISCIPLINA D ON C.Id = D.CursosId
		INNER JOIN dbo.PROVA P ON P.DisciplinasId = D.Id
		INNER JOIN AVALIACAO A ON A.ProvasId = P.Id 
		INNER JOIN PROFESSOR PF ON PF.Id = D.ProfessoresId
		INNER JOIN AREA AR ON AR.Id = C.AreasId
		INNER JOIN (select a.Id, avg(a.Nota_da_Prova) as media from (
				SELECT
				c.Id,((Case when sum (a.Ava_Valor_Questao)=p.Prova_Valor_Prova then 1 else 0 end) +p.Prova_Ref_Bibliografica + 
				(sum((a.Ava_Clareza/100 + a.Ava_Contextualizacao/100 +a.Ava_Complexibilidade+a.Ava_Questao_Explicito)/9)/(count(a.ProvasId)))*8 )*10 as Nota_da_Prova
				FROM CURSO C 
				INNER JOIN DISCIPLINA D ON C.Id = D.CursosId
				INNER JOIN PROVA P ON P.DisciplinasId = D.Id
				INNER JOIN AVALIACAO A ON A.ProvasId = P.Id 
				where (c.Id = null or null is null )
					AND (p.Prova_Data >= null or null is null)
					AND (p.Prova_Data <= null or null is null)
					AND (p.DisciplinasId = null or null is null)
					AND (d.ProfessoresId = null or null is null)
				group by c.Id, p.Prova_Ref_Bibliografica, p.Prova_Valor_Prova
				) a group by a.id) X ON C.Id = X.Id
    where (c.Id = @pCurso or @pCurso is null or @pCurso = 0)
		AND (CAST(p.Prova_Data as DATE) >= CAST(@pDataIni AS DATE) or @pDataIni is null)
		AND (CAST(p.Prova_Data as DATE) <= CAST(@pDataFim AS DATE) or @pDataFim is null)
		AND (p.DisciplinasId = @pDisciplina or @pDisciplina is null or @pDisciplina = 0)
		AND (d.ProfessoresId = @pProfessor or @pProfessor is null or @pProfessor = 0)
		AND (AR.Id = @pArea or @pArea is null or @pArea = 0)
    group by 	p.id,p.Prova_Ref_Bibliografica, p.Prova_Valor_Explicito, p.Prova_Valor_Prova,d.Dis_Nome, d.Dis_Ano, d.Dis_Periodo,
				c.Cur_Nome,c.Cur_Ano_Sem,p.Prova_Avd,p.Prova_Data,c.Id,X.media,PF.Prof_Nome
	RETURN
