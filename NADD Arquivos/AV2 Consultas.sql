-- Segundo bimestre - CONSULTAS REFERENTES A AV2

-- *******Os dados necess�rios para cria��o e popular o banco est�o no arquivo Cria��o e preenchimento do BD.sql********

-- Enuncie problemas que tenham como solu��o views que contemplem: 




-- Subconsulta simples (com apenas uma tabela) 
-- Enunciado: O usu�rio ao consultar os usu�rios somente deve poder visualizar 
-- aqueles que tem um perfil igual ou com menos acesso.

Create or replace view SUBCONSULTA_SIMPLES
AS
select tu.usu_id as MATRICULA, tu.usu_nome as NOME, 
(select tp.perf_nome from tabela_perfil tp where tp.perf_id = tu.usu_perfil) AS PERFIL 
from tabela_usuario tu
where tu.usu_perfil >= 1;

select * from SUBCONSULTA_SIMPLES;




-- - Subconsulta complexa (contemplando 2 tabelas) 
-- ENUNCIADO: A Gest�o quer uma listagem de quantas provas de cada professor foi 
-- avaliada de uma determinada �rea, listando a area referente a consulta, 
-- o curso e a disciplina que cada professor est� lecionando. 

Create or replace view SUBCONSULTA_COMPLEXA
AS
select ta.area_nome as AREA, tc.cur_nome as CURSO, 
    td.dis_nome || ' - ' || td.dis_ano || ' - ' || td.dis_periodo as DISCIPLINA, 
    tp.prof_nome as PROFESSOR, (select count(*) from tabela_prova tpr 
    where tp.prof_id = tpr.prova_id_professor and tpr.prova_ano = tdp.dep_ano 
    and tpr.prova_periodo = tdp.dep_num_periodo 
    and tpr.prova_disciplina = tdp.dep_disciplina) as "QTDE_PROVAS_APLICADAS"
from tabela_area ta
inner join tabela_curso tc on ta.area_id = tc.cur_area 
inner join tabela_disciplina td on tc.cur_id = td.dis_curso
inner join tabela_dis_prof tdp on td.dis_id = tdp.dep_disciplina 
    and td.dis_ano = tdp.dep_ano and td.dis_periodo = tdp.dep_num_periodo
inner join tabela_professor tp on tp.prof_id = tdp.dep_professor 
where ta.area_nome like 'EXATAS%'
order by 1,2,3,4;

select * from SUBCONSULTA_COMPLEXA;




-- Subconsulta utilizando a cl�usula ALL 
-- ENUNCIADO: Deseja-se saber as disciplinas em que foram aplicadas provas 
-- com uma complexidade acima da de todas as provas cuja contextualiza��o foi 
-- avaliada em 2. Na consulta tamb�m deve aparecer a m�dia das complexidades de 
-- todas as provas dessas disciplinas.
create or replace view subconsulta_all
as
select td.dis_nome DISCIPLINA, AVG(ta.ava_complexidade) as "M�DIA DAS COMPLEXIDADES"  
from tabela_disciplina td inner join tabela_dis_prof tdp
on (td.dis_id = tdp.dep_disciplina) inner join tabela_prova tp
on (tdp.dep_disciplina = tp.prova_disciplina) inner join tabela_avaliacao ta
on (tp.prova_id = ta.ava_prova)
where ava_complexidade > all
(select ava_complexidade from tabela_avaliacao where ava_contextualizacao = 2)
group by td.dis_nome;

select * from subconsulta_all;




-- Subconsulta utilizando a cl�usula ANY 
-- ENUNCIADO: O coordenador do curso gostaria de saber a quantidade de quest�es 
-- das provas cujo valor total seja menor que 8, 
-- quais professores a aplicaram e em que disciplina foi:
Create or replace view SUBCONSULTA_ANY
AS
select tp.prof_nome as PROFESSOR, td.dis_nome as DISCIPLINA, 
    tp.prova_qnt_questao as "QTDE_DE_QUESTOES", tp.prova_valor_prova as "VALOR DA PROVA"
from tabela_professor tp inner join tabela_dis_prof tdp 
on (tp.prof_id = tdp.dep_professor) inner join tabela_disciplina td 
on (tdp.dep_disciplina = td.dis_id) inner join tabela_prova tp 
on (tdp.dep_disciplina = tp.prova_disciplina) 
where prova_qnt_questao = ANY 
    (select prova_qnt_questao from tabela_prova where tp.prova_valor_prova < 8);
    
select * from SUBCONSULTA_ANY;
    



-- Subconsulta utilizando a cl�usula IN 
-- ENUNCIADO: Dentre todos os cursos da universidade, o reitor deseja saber a quantidade 
-- de professores das disciplinas ministradas no primeiro per�odo.

create or replace view subconsulta_in
as
select cur_nome CURSO, dis_nome DISCIPLINA, count(dep_professor) "QUANTIDADE DE PROFESSOR"
from tabela_curso tc inner join tabela_disciplina td
on (td.dis_curso = tc.cur_id) inner join tabela_dis_prof tdp
on (td.dis_id = tdp.dep_disciplina) 
WHERE cur_id in 
    (select dis_curso from tabela_disciplina where dis_periodo = 1) 
group by cur_nome, dis_nome;

select * from subconsulta_in;




-- - Consulta utilizando Left Join 
-- Exibir a �rea que ainda n�o possui nenhum curso cadastrado
create or replace view consulta_left_join
as
select area_nome area
from tabela_area a left join tabela_curso c 
on a.area_id = c.cur_area
where c.cur_id is null;

select * from consulta_left_join;




-- Consulta utilizando Right Join 
-- Exibir todos os cursos que ainda n�o possuam nenhuma disciplina
create or replace view consulta_right_join
as
select cur_nome CURSO, cur_area AREA
from tabela_disciplina d right join tabela_curso c
on d.dis_curso = c.cur_id
where d.dis_id is null;

SELECT * FROM CONSULTA_RIGHT_JOIN;




-- - Consulta utilizando Full Outer Join 
-- Exibir todos os cursos independentemente de terem disciplinas associadas:
create or replace view consulta_full_outer_join
as
select c.cur_nome curso, d.dis_nome disciplina
from tabela_disciplina d full outer join tabela_curso c
on d.dis_curso = c.cur_id;

select * from consulta_full_outer_join;




-- Enuncie e desenvolva dois blocos PL/SQL que fa�am uso de vari�veis, 
-- da cl�usula %TYPE e do bloco Exception

-- Deseja-se saber a matr�cula de um professor atrav�s do seu nome (D�bora), armazenar essa matr�cula numa vari�vel e logo depois imprimi-la: 
SET SERVEROUTPUT ON
DECLARE
	v_matricula_prof tabela_professor.prof_matricula%TYPE;
BEGIN
	select prof_matricula into v_matricula_prof from tabela_professor 
    where prof_nome = 'DEBORA AMORIM DE CARVALHO';
	
	dbms_output.put_line('A matr�cula da professor D�bora �: ' || v_matricula_prof);
EXCEPTION WHEN no_data_found THEN
	dbms_output.put_line('Ocorreu um problema');
END;

-- Sabe-se que por enquanto s� h� um curso da �rea da sa�de cadastro. Armazene o nome desse curso numa vari�vel e ent�o exiba-o.
SET SERVEROUTPUT ON
DECLARE
	v_nome_curso tabela_curso.cur_nome%TYPE;
BEGIN
	select c.cur_nome into v_nome_curso from tabela_curso c 
	join tabela_area a on (c.cur_area = a.area_id)
	where a.area_nome = 'SAUDE';
	
	dbms_output.put_line('Atualmente o �nico curso da �rea de sa�de cadastro � ' || v_nome_curso);
EXCEPTION WHEN no_data_found THEN
	dbms_output.put_line('Ocorreu um problema');
END;