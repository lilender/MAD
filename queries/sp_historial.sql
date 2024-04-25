USE REGISTROS;

go
DROP PROCEDURE sp_historial;
go

CREATE PROCEDURE sp_historial 
	@id			UNIQUEIDENTIFIER
AS
BEGIN

DECLARE @id_historial UNIQUEIDENTIFIER;
SELECT @id_historial = id_historial FROM historial WHERE id_usuario = @id;

SELECT idioma, versión, testamento, libro, capitulo, versiculo, vacio, f_consulta, id_consulta FROM v_historial WHERE id_historial = @id_historial
ORDER BY f_consulta DESC;

END