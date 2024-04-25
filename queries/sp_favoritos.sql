USE REGISTROS;

go
DROP PROCEDURE sp_favoritos;
go

CREATE PROCEDURE sp_favoritos 
	@id			UNIQUEIDENTIFIER
AS
BEGIN

SELECT versión, testamento, libro, capitulo, versiculo, TEXTO, id_favorito, id_usuario
FROM v_favoritos WHERE id_usuario = @id;

END