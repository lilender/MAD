USE REGISTROS;
GO
CREATE OR ALTER VIEW v_datos_usuarios
AS
SELECT correo, nombres, apellido_p, apellido_m, f_nacimiento, genero, pregunta, idioma_pref, contador, estatus,id_usuario
FROM usuarios;