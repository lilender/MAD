USE REGISTROS;
GO

CREATE OR ALTER FUNCTION ValidarRespuesta(
    @id           UNIQUEIDENTIFIER,
    @respActual   VARCHAR(25)
)
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @resultado VARCHAR(10);

    -- Si la respuesta ingresada es igual a la respuesta en la base de datos
    IF HASHBYTES('SHA2_256', @respActual) = (SELECT respuesta FROM v_private_usuarios WHERE id_usuario = @id)
    BEGIN
        SET @resultado = 'VALIDA';
    END
    ELSE
    BEGIN
        SET @resultado = 'INVALIDA';
    END

    RETURN @resultado;
END;
GO
