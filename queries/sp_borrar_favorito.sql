USE REGISTROS
GO
DROP PROCEDURE sp_borrar_favorito
go

CREATE PROCEDURE sp_borrar_favorito (
	@id_fav UNIQUEIDENTIFIER,
	@id_usuario UNIQUEIDENTIFIER
	)

	AS
	BEGIN

	DELETE FROM usuarios_favoritos WHERE @id_fav = id_favorito AND @id_usuario = id_usuario;

	

	END