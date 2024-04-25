USE REGISTROS;
GO
DROP VIEW v_favoritos;

GO
CREATE VIEW v_favoritos
AS

SELECT f.versión, f.testamento, f.libro, f.capitulo, f.versiculo, b.TEXTO, f.id_favorito, uf.id_usuario
FROM favoritos f
JOIN usuarios_favoritos uf ON f.id_favorito = uf.id_favorito 
JOIN v_tabla_biblia b ON b.IDIOMA = f.idioma 
AND b.VERSIÓN = f.versión 
AND b.TESTAMENTO = f.testamento 
AND b.LIBRO = f.libro 
AND b.CAPÍTULO = f.capitulo 
AND b.VERSÍCULO = ISNULL(f.versiculo, b.VERSÍCULO);
