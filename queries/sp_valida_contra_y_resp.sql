DROP PROCEDURE sp_valida_contra_y_resp;
go
CREATE PROCEDURE sp_valida_contra_y_resp (
	@id				UNIQUEIDENTIFIER,
	@cifrado		VARCHAR(25),
	@opcion			VARCHAR(10)) 
	AS
	BEGIN
	
		IF @opcion = 'contra'
			BEGIN
			--Si la contraseña ingresada es igual a la contraseña en la base de datos
			IF HASHBYTES('SHA2_256', @cifrado) = (SELECT contrasena FROM contrasenas WHERE id_usuario = @id AND numero = 3)
				BEGIN
				--regresar el contador a 0
				UPDATE usuarios SET contador = 0 WHERE id_usuario = @id;
				SELECT 'CORRECTA';
				END
			ELSE 
				BEGIN
				--sumar 1 a contador maximo 3
				IF (SELECT contador FROM v_datos_usuarios WHERE id_usuario = @id) < 3
					BEGIN
					UPDATE usuarios SET contador = contador + 1 WHERE id_usuario = @id;
					SELECT 'INCORRECTA';
					END
				ELSE
					BEGIN
					SELECT 'MAX';
					END
				END
			END
		IF @opcion = 'resp'
			BEGIN
			--Si la respuesta ingresada es igual a la respuesta en la base de datos
			IF HASHBYTES('SHA2_256', @cifrado) = (SELECT respuesta FROM v_private_usuarios WHERE id_usuario = @id)
				BEGIN
				SELECT 'CORRECTA';
				END
			ELSE 
				BEGIN
				SELECT 'INCORRECTA';
				END
			END

	END
