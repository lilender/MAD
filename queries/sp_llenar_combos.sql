USE REGISTROS;
--procedure para llenar los combos
go
DROP PROCEDURE sp_llenar_combos;
go

CREATE PROCEDURE sp_llenar_combos(
	@idioma		VARCHAR(20),
	@version	VARCHAR(30),
	@testamento VARCHAR(20),
	@libro		VARCHAR(20),
	@capitulo	SMALLINT
	)

	AS
	BEGIN
IF (@testamento = 'AMBOS')
	BEGIN
	set @testamento = null;
	END

IF (@idioma = '0')
	BEGIN
	SELECT i.Nombre, i.Id_Idioma FROM DB_Bible.dbo.Idiomas i;
	END
ELSE
	BEGIN
	IF (@version = '0')
		BEGIN
		SELECT v.NombreVersion, v.Id_Version 
		FROM DB_Bible.dbo.Idiomas i
		JOIN DB_Bible.dbo.Versiones v ON v.Id_Idioma = i.Id_Idioma
		WHERE i.Nombre = @idioma;
		END
	ELSE
		BEGIN
		IF (@testamento = '0')
			BEGIN
			SELECT t.Nombre, t.Id_Testamento 
			FROM DB_Bible.dbo.Idiomas i
			JOIN DB_Bible.dbo.Versiones v ON v.Id_Idioma = i.Id_Idioma
			JOIN DB_Bible.dbo.Testamentos t ON t.Id_Idioma = v.Id_Idioma
			WHERE i.Nombre = @idioma
			AND v.NombreVersion = @version;
			END
		ELSE
			BEGIN
			IF (@libro = '0')
				BEGIN
				SELECT L.Nombre, L.Id_Libro
				FROM DB_Bible.dbo.Idiomas i
				JOIN DB_Bible.dbo.Versiones v ON v.Id_Idioma = i.Id_Idioma
				JOIN DB_Bible.dbo.Testamentos t ON t.Id_Idioma = v.Id_Idioma
				JOIN DB_Bible.dbo.Libros L ON L.Id_Testamento = t.Id_Testamento
				WHERE i.Nombre = @idioma
				AND v.NombreVersion = @version
				AND t.Nombre = ISNULL(@testamento, t.Nombre)
				ORDER BY L.OrdenLibro;
				END
			ELSE
				BEGIN
				IF (@capitulo = '0')
					BEGIN
					SELECT ver.NumeroCap --, ver.Id_Vers
					FROM DB_Bible.dbo.Idiomas i
					JOIN DB_Bible.dbo.Versiones v ON v.Id_Idioma = i.Id_Idioma
					JOIN DB_Bible.dbo.Testamentos t ON t.Id_Idioma = v.Id_Idioma
					JOIN DB_Bible.dbo.Libros L ON L.Id_Testamento = t.Id_Testamento
					JOIN DB_Bible.dbo.Versiculos ver ON ver.Id_Version = v.Id_Version AND ver.Id_Libro = L.Id_Libro
					WHERE i.Nombre = @idioma
					AND v.NombreVersion = @version
					AND t.Nombre = ISNULL(@testamento, t.Nombre)
					AND L.Nombre = @libro
					AND ver.NumeroVers = 1
					END
				ELSE
					BEGIN
					SELECT ver.NumeroVers
					FROM DB_Bible.dbo.Idiomas i
					JOIN DB_Bible.dbo.Versiones v ON v.Id_Idioma = i.Id_Idioma
					JOIN DB_Bible.dbo.Testamentos t ON t.Id_Idioma = v.Id_Idioma
					JOIN DB_Bible.dbo.Libros L ON L.Id_Testamento = t.Id_Testamento
					JOIN DB_Bible.dbo.Versiculos ver ON ver.Id_Version = v.Id_Version AND ver.Id_Libro = L.Id_Libro
					WHERE i.Nombre = @idioma
					AND v.NombreVersion = @version
					AND t.Nombre = ISNULL(@testamento, t.Nombre)
					AND L.Nombre = @libro
					AND ver.NumeroCap = @capitulo
					END
				END
			END
		END
	END





END