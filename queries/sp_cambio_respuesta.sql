USE REGISTROS;
GO
CREATE OR ALTER PROCEDURE sp_cambio_respuesta (
	@id				UNIQUEIDENTIFIER,
	@respActual		VARCHAR(25),
	@respNueva		VARCHAR(25)) --checar luego el 25
	AS
	BEGIN
		DECLARE @validacion VARCHAR(10);

    -- Llamar a la función para validar la respuesta
    SET @validacion = dbo.ValidarRespuesta(@id, @respActual);

    -- Devolver el resultado de la validación
    IF @validacion = 'VALIDA'
	BEGIN
	UPDATE v_private_usuarios SET respuesta = HASHBYTES('SHA2_256', @respNueva) WHERE id_usuario = @id;
	END
	SELECT @validacion;
END