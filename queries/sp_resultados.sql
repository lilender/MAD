USE REGISTROS;

go
DROP PROCEDURE sp_resultados;
go

CREATE PROCEDURE sp_resultados(
	@idioma		VARCHAR(20),
	@version	VARCHAR(30),
	@testamento VARCHAR(20) = null,
	@libro		VARCHAR(20) = null,
	@capitulo	SMALLINT = null,
	@versiculo	SMALLINT = null,
	@palabras	VARCHAR(100) = null,
	@id			UNIQUEIDENTIFIER
	)

	AS
	BEGIN
	DECLARE @id_historial UNIQUEIDENTIFIER;
	SELECT @id_historial = id_historial FROM historial WHERE id_usuario = @id;
	UPDATE usuarios SET idioma_pref = @idioma WHERE id_usuario = @id;
	
	IF @palabras = ISNULL(@palabras, '0')
	BEGIN
		INSERT INTO busquedas VALUES (NEWID(), @id, @id_historial, @idioma, @version, @testamento, @libro, @capitulo, @versiculo, @palabras, GETDATE());

		DECLARE @palabra VARCHAR (30);
		DECLARE micursor CURSOR FOR SELECT value FROM string_split(@palabras, ' ');

		SET @palabras = '%';
		OPEN micursor;
		FETCH NEXT FROM micursor INTO @palabra;

		WHILE @@FETCH_STATUS = 0
		BEGIN
		--codigo
		IF @palabra != ' '
			BEGIN
			SET @palabras += @palabra + '%';
			END

		FETCH NEXT FROM micursor INTO @palabra;
		END;
		CLOSE micursor;
		DEALLOCATE micursor;
		--end while

		IF (@testamento = 'AMBOS')
			BEGIN
			set @testamento = null;
			END
		SELECT TESTAMENTO, LIBRO, CAPÍTULO, VERSÍCULO, TEXTO FROM v_tabla_biblia
		WHERE IDIOMA = @idioma
		AND VERSIÓN = @version
		AND TESTAMENTO = ISNULL(@testamento, TESTAMENTO)
		AND LIBRO = ISNULL(@libro, LIBRO)
		AND CAPÍTULO = ISNULL(@capitulo, CAPÍTULO)
		AND VERSÍCULO = ISNULL(@versiculo, VERSÍCULO)
		AND TEXTO LIKE @palabras
		ORDER BY ORDEN;

	END
	ELSE
		BEGIN
		INSERT INTO consultas VALUES (NEWID(), @id, @id_historial, @idioma, @version, @testamento, @libro, @capitulo, @versiculo, null, GETDATE());

		IF (@testamento = 'AMBOS')
			BEGIN
			set @testamento = null;
			END
		SELECT TESTAMENTO, LIBRO, CAPÍTULO, VERSÍCULO, TEXTO FROM v_tabla_biblia
		WHERE IDIOMA = @idioma
		AND VERSIÓN = @version
		AND TESTAMENTO = ISNULL(@testamento, TESTAMENTO)
		AND LIBRO = ISNULL(@libro, LIBRO)
		AND CAPÍTULO = ISNULL(@capitulo, CAPÍTULO)
		AND VERSÍCULO = ISNULL(@versiculo, VERSÍCULO)
		ORDER BY ORDEN;
		
		END
	END
