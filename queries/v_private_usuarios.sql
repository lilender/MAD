USE REGISTROS;
GO
CREATE OR ALTER VIEW v_private_usuarios
AS
SELECT respuesta, id_usuario
FROM usuarios;