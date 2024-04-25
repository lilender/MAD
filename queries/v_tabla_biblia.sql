USE REGISTROS;
GO
DROP VIEW v_tabla_biblia;

GO
CREATE VIEW v_tabla_biblia
AS

SELECT i.Nombre AS IDIOMA, 
v.NombreVersion AS VERSIÓN, 
t.Nombre AS TESTAMENTO, 
L.OrdenLibro AS ORDEN,
L.Nombre AS LIBRO, 
ver.NumeroCap AS CAPÍTULO, 
ver.NumeroVers AS VERSÍCULO, 
ver.texto AS TEXTO
FROM DB_Bible.dbo.Idiomas i
JOIN DB_Bible.dbo.Versiones v ON v.Id_Idioma = i.Id_Idioma
JOIN DB_Bible.dbo.Testamentos t ON t.Id_Idioma = v.Id_Idioma
JOIN DB_Bible.dbo.Libros L ON L.Id_Testamento = t.Id_Testamento
JOIN DB_Bible.dbo.Versiculos ver ON ver.Id_Version = v.Id_Version AND ver.Id_Libro = L.Id_Libro;
