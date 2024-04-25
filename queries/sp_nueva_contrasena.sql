USE REGISTROS;
go
DROP PROCEDURE sp_nueva_contrasena;
go
CREATE PROCEDURE sp_nueva_contrasena(
	@id				UNIQUEIDENTIFIER,
	@contrasena		VARCHAR(25)) --checar luego el 25
	AS
	BEGIN
		
		--while
		DECLARE @contra VARBINARY(64);
		DECLARE micursor CURSOR FOR SELECT contrasena FROM contrasenas WHERE id_usuario = @id;

		OPEN micursor;
		FETCH NEXT FROM micursor INTO @contra;

		WHILE @@FETCH_STATUS = 0
		BEGIN
		--codigo
		IF @contra = HASHBYTES('SHA2_256', @contrasena)
			BEGIN
			SELECT 'INVALIDA';
			RETURN;
			END

		FETCH NEXT FROM micursor INTO @contra;
		END;
		CLOSE micursor;
		DEALLOCATE micursor;
		--end while

		BEGIN
			--otro while
			DECLARE @id_contra UNIQUEIDENTIFIER;
			DECLARE micursor CURSOR FOR SELECT id_contrasena FROM contrasenas WHERE id_usuario = @id;

			OPEN micursor;
			FETCH NEXT FROM micursor INTO @id_contra;

			WHILE @@FETCH_STATUS = 0
			BEGIN
			--codigo
			IF (SELECT numero FROM contrasenas WHERE @id_contra = id_contrasena) = 1
				BEGIN
				DELETE FROM contrasenas WHERE @id_contra = id_contrasena;
				END
			ELSE
				BEGIN
				UPDATE contrasenas SET numero = numero - 1 WHERE @id_contra = id_contrasena;
				END
			FETCH NEXT FROM micursor INTO @id_contra;
			END;
			CLOSE micursor;
			DEALLOCATE micursor;
			--end while

			INSERT contrasenas VALUES (NEWID(), @id, HASHBYTES('SHA2_256', @contrasena), 3);
			UPDATE usuarios SET contador = 0 WHERE id_usuario = @id;
			SELECT 'VALIDA';
		END

	END