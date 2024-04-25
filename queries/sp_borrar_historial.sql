USE REGISTROS

GO

CREATE OR ALTER PROCEDURE sp_borrar_historial(
	@id_objeto	UNIQUEIDENTIFIER = null,
	@id			UNIQUEIDENTIFIER = null)

	AS
	BEGIN

	IF @id_objeto IS NOT NULL
		BEGIN
		DELETE FROM consultas WHERE @id_objeto = id_consulta;
		DELETE FROM busquedas WHERE @id_objeto = id_busqueda;
		END
	IF @id IS NOT NULL
		BEGIN
		DECLARE @id_historial UNIQUEIDENTIFIER;
		SELECT @id_historial = id_historial FROM historial WHERE id_usuario = @id;
		DELETE FROM consultas WHERE @id_historial = id_historial;
		DELETE FROM busquedas WHERE @id_historial = id_historial;
		END

	END