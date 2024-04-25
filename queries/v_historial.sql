USE REGISTROS;
GO
DROP VIEW v_historial;

GO
CREATE VIEW v_historial
AS

SELECT idioma, versión, testamento, libro, capitulo, versiculo, vacio, f_consulta, id_consulta, id_historial FROM consultas
UNION
SELECT idioma, versión, testamento, libro, capitulo, versiculo, busqueda, f_busqueda, id_busqueda, id_historial FROM busquedas;