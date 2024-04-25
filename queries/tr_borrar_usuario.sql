USE REGISTROS;
GO
CREATE OR ALTER TRIGGER tr_borrar_usuario
ON usuarios
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @hoy DATETIME;
	SET		@hoy=GETDATE();
	UPDATE usuarios SET estatus = 0, f_baja = @hoy WHERE (SELECT id_usuario FROM DELETED) = id_usuario;

END;


select * from usuarios