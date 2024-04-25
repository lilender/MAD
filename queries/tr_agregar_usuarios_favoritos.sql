USE REGISTROS;
GO
CREATE OR ALTER TRIGGER tr_agregar_usuarios_favoritos
ON usuarios_favoritos
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @ID_usuarios_favoritos		UNIQUEIDENTIFIER;
	DECLARE @ID_usuario UNIQUEIDENTIFIER;
	DECLARE @ID_fav		UNIQUEIDENTIFIER;

	SELECT @ID_usuarios_favoritos = id_usuarios_favoritos, @ID_usuario = id_usuario, @ID_fav = id_favorito
        FROM inserted;

	DECLARE @existe BIT;
	SET @existe = 0;

	SELECT @existe = 1 FROM usuarios_favoritos UF 
	WHERE @ID_fav = UF.id_favorito
	AND @ID_usuario = UF.id_usuario;

	IF @existe = 0
		BEGIN
			INSERT INTO usuarios_favoritos VALUES (@ID_usuarios_favoritos, @ID_usuario, @ID_fav);
		END

END;
