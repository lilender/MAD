USE REGISTROS;
go
DROP PROCEDURE sp_obtener_datos_usuarios;
GO
CREATE PROCEDURE sp_obtener_datos_usuarios(
	@opcion			VARCHAR(10), 
	@id				UNIQUEIDENTIFIER)
	AS
	BEGIN
	IF @opcion = 'idioma'
		BEGIN
		SELECT idioma_pref FROM v_datos_usuarios WHERE id_usuario = @id;
		END
	IF @opcion = 'todo'
		BEGIN
		SELECT correo, nombres, apellido_p, apellido_m, f_nacimiento, genero, pregunta FROM v_datos_usuarios WHERE id_usuario = @id;
		END
	IF @opcion = 'contador'
		BEGIN
		SELECT contador FROM v_datos_usuarios WHERE id_usuario = @id;
		END	
	IF @opcion = 'pregunta'
		BEGIN
		SELECT pregunta FROM v_datos_usuarios WHERE id_usuario = @id;
		END	
	END