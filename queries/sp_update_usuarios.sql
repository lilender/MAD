USE REGISTROS;
go

CREATE OR ALTER PROCEDURE sp_update_usuarios (
	@opcion			VARCHAR(10), 
	@correo			VARCHAR(255),
	@nombres		VARCHAR(50),
	@apellido_p		VARCHAR(50),
	@apellido_m		VARCHAR(50) = null,
	@f_nacimiento	DATE,
	@genero			BIT,
	@pregunta		VARCHAR(255),
	@respuesta		VARCHAR(25) = null,--checar luego el 25
	@contrasena		VARCHAR(25) = null,
	@id				UNIQUEIDENTIFIER = null) 
	AS
	BEGIN
		IF @opcion = 'agregar'
			BEGIN
				DECLARE @hoy DATETIME;
				SET		@hoy=GETDATE();
				DECLARE @id_usuario	UNIQUEIDENTIFIER;
				SET		@id_usuario=NEWID();
				INSERT usuarios VALUES (@id_usuario, @correo, @nombres, @apellido_p, @apellido_m, @f_nacimiento, @genero, 0, @pregunta, HASHBYTES('SHA2_256', @respuesta), @hoy, null, 1, NULL);
				INSERT contrasenas VALUES (NEWID(), @id_usuario, HASHBYTES('SHA2_256', @contrasena), 3);
				INSERT historial VALUES (NEWID(), @id_usuario);
			END

		IF @opcion = 'cambiar'
			BEGIN
				UPDATE usuarios 
				SET correo = @correo, 
					nombres = @nombres, 
					apellido_p = @apellido_p, 
					apellido_m = @apellido_m, 
					f_nacimiento = @f_nacimiento, 
					genero = @genero, 
					pregunta = @pregunta
				WHERE @id = id_usuario;
					
			END
		IF @opcion = 'borrar'
			BEGIN
				DELETE usuarios WHERE @id = id_usuario;
			END
	END

	