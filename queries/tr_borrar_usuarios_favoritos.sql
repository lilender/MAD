USE REGISTROS;
GO
CREATE OR ALTER TRIGGER tr_borrar_usuarios_favoritos
ON usuarios_favoritos
AFTER DELETE
AS
BEGIN
	
	DECLARE @id_fav UNIQUEIDENTIFIER;
	SELECT @id_fav = id_favorito FROM deleted;

	DECLARE @unico BIT;
	SET @unico = 1;

	SELECT @unico = 0 FROM usuarios_favoritos WHERE @id_fav = id_favorito;

	IF @unico = 1
		BEGIN
		DELETE FROM favoritos WHERE @id_fav = id_favorito;
		END
END;