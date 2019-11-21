CREATE TRIGGER TR_QUESTAO
ON Prova
FOR INSERT
AS
BEGIN
    DECLARE
    @ID		INTEGER,
    @QTD	INTEGER,
	@i		INTEGER
 
    SELECT @ID = ID, @QTD = Prova_Qnt_Questao, @i = 0 FROM INSERTED
	WHILE (@i<@QTD) BEGIN
	    SET @i=@i+1;
		INSERT INTO AVALIACAO VALUES (@i,'-1','-1','-1',NULL,'-1','-1','-1',@ID);
	END 

END;