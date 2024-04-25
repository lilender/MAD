exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'id_usuario'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Correo electrónico del usuario, debe ser único',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'correo'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Nombres del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'nombres'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Apellido paterno del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'apellido_p'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Apellido materno del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'apellido_m'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Fecha de nacimiento del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'f_nacimiento'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Genero del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'genero'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Contador de fallos de contraseña incorrecta',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'contador'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Pregunta de recuperación en caso de que se falle 3 veces en la contraseña',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'pregunta'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Respuesta a la pregunta de recuperación',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'respuesta'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Fecha de registro/alta del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'f_registro'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Fecha de baja del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'f_baja'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Estatus del usuario (activo/inactivo)',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios',
	@level2type = 'Column', @level2name = 'estatus'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de historial',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'historial',
	@level2type = 'Column', @level2name = 'id_historial'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'historial',
	@level2type = 'Column', @level2name = 'id_usuario'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de favorito',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'favoritos',
	@level2type = 'Column', @level2name = 'id_favorito'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de busqueda',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'busquedas',
	@level2type = 'Column', @level2name = 'id_busqueda'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'busquedas',
	@level2type = 'Column', @level2name = 'id_usuario'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de historial',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'busquedas',
	@level2type = 'Column', @level2name = 'id_historial'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Palabra o palabras que el usuario buscó',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'busquedas',
	@level2type = 'Column', @level2name = 'busqueda'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Fecha de la busqueda',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'busquedas',
	@level2type = 'Column', @level2name = 'f_busqueda'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de consulta',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'consultas',
	@level2type = 'Column', @level2name = 'id_consulta'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'consultas',
	@level2type = 'Column', @level2name = 'id_usuario'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de historial',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'consultas',
	@level2type = 'Column', @level2name = 'id_historial'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Fecha de la consulta',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'consultas',
	@level2type = 'Column', @level2name = 'f_consulta'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de usuario-favorito',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios_favoritos',
	@level2type = 'Column', @level2name = 'id_usuarios_favoritos'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios_favoritos',
	@level2type = 'Column', @level2name = 'id_usuario'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de favorito',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'usuarios_favoritos',
	@level2type = 'Column', @level2name = 'id_favorito'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Identificador de contrasenas',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'contrasenas',
	@level2type = 'Column', @level2name = 'id_contrasena'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Llave foranea de usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'contrasenas',
	@level2type = 'Column', @level2name = 'id_usuario'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Contrasena del usuario',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'contrasenas',
	@level2type = 'Column', @level2name = 'contrasena'
GO
exec sp_addextendedproperty
	@name = 'MS_Description', @value = 'Numero de la contrasena (se deben guardar las 2 contrasenas anteriores)',
	@level0type = 'Schema', @level0name = 'dbo',
	@level1type = 'Table', @level1name = 'contrasenas',
	@level2type = 'Column', @level2name = 'numero'
GO
SELECT 
	'DATADICTIONARY' AS [REPORT],
	@@SERVERNAME AS [ServerName],
	DB_NAME() AS [DatabaseName],
	t.name AS [TableName], 
	schema_name(t.schema_id) AS [SchemaName], 
	c.name AS [ColumnName], 
	st.name AS [DataType], 
	c.max_length AS [MaxLength], 
	CASE 
		WHEN c.is_nullable = 0 THEN 'NO'
		ELSE 'YES'
	END AS [IsNull],
	CASE 
		WHEN c.is_identity = 0 THEN 'NO'
		ELSE 'YES'
	END AS [IsIdentity], 
	isnull(ep.value, '-- add description here') AS [Description]
FROM [sys].[tables] t
INNER JOIN [sys].[columns] c
	ON t.object_id= c.object_id 
INNER JOIN [sys].[systypes] st 
	ON c.system_type_id= st.xusertype 
INNER JOIN [sys].[objects] o 
	ON t.object_id= o.object_id 
LEFT JOIN [sys].[extended_properties] ep 
	ON o.object_id = ep.major_id 
	AND c.column_Id = ep.minor_id
WHERE t.name <> 'sysdiagrams' 
ORDER BY 
	t.name,
	c.column_Id