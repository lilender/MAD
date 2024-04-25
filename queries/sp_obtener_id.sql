USE REGISTROS;
go


CREATE OR ALTER PROCEDURE sp_obtener_id(
	@correo			VARCHAR(255))
	AS
	BEGIN
		SELECT id_usuario FROM v_datos_usuarios WHERE correo = @correo COLLATE Latin1_General_BIN AND estatus = 1;
	END