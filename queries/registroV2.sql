--CREATE DATABASE REGISTROS;

USE REGISTROS;

IF OBJECT_ID('usuarios') IS NOT NULL
	BEGIN
		IF OBJECT_ID('historial') IS NOT NULL
			BEGIN
			ALTER TABLE historial DROP CONSTRAINT FK_usuario_historial;
			END
		IF OBJECT_ID('busquedas') IS NOT NULL
			BEGIN
			ALTER TABLE busquedas DROP CONSTRAINT FK_usuario_busqueda;
			END
		IF OBJECT_ID('consultas') IS NOT NULL
			BEGIN
			ALTER TABLE consultas DROP CONSTRAINT FK_usuario_consulta;
			END
		IF OBJECT_ID('usuarios_favoritos') IS NOT NULL
			BEGIN
			ALTER TABLE usuarios_favoritos DROP CONSTRAINT FK_usuario_usuariosfavoritos;
			END
		IF OBJECT_ID('contrasenas') IS NOT NULL
			BEGIN
			ALTER TABLE contrasenas DROP CONSTRAINT FK_usuario_contrasena;
			END
		DROP TABLE usuarios;
	END

CREATE TABLE usuarios (
	id_usuario		UNIQUEIDENTIFIER NOT NULL,
	correo			VARCHAR(255) UNIQUE NOT NULL,
	nombres			VARCHAR(50) NOT NULL,
	apellido_p		VARCHAR(50) NOT NULL,
	apellido_m		VARCHAR(50),							--podría no tener apellido materno...
	f_nacimiento	DATE NOT NULL,
	genero			BIT NOT NULL,
	contador		TINYINT NOT NULL,
	pregunta		VARCHAR(255) NOT NULL,
	respuesta		VARBINARY(64) NOT NULL,
	f_registro		DATETIME NOT NULL,
	f_baja			DATETIME,
	estatus			BIT NOT NULL,
	idioma_pref		VARCHAR(20)

	CONSTRAINT PK_usuarios PRIMARY KEY (id_usuario)
);

IF OBJECT_ID('historial') IS NOT NULL
	BEGIN
		IF OBJECT_ID('busquedas') IS NOT NULL
			BEGIN
			ALTER TABLE busquedas DROP CONSTRAINT FK_historial_busqueda;
			END
		IF OBJECT_ID('consultas') IS NOT NULL
			BEGIN
			ALTER TABLE consultas DROP CONSTRAINT FK_historial_consulta;
			END
		DROP TABLE historial;
	END

CREATE TABLE historial (
	id_historial	UNIQUEIDENTIFIER NOT NULL,
	id_usuario		UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT PK_historial PRIMARY KEY (id_historial),

	CONSTRAINT FK_usuario_historial FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);

IF OBJECT_ID('favoritos') IS NOT NULL
	BEGIN
		IF OBJECT_ID('usuarios_favoritos') IS NOT NULL
			BEGIN
			ALTER TABLE usuarios_favoritos DROP CONSTRAINT FK_favorito_usuariosfavoritos;
			END
		DROP TABLE favoritos;
	END

CREATE TABLE favoritos (
	id_favorito		UNIQUEIDENTIFIER NOT NULL,
	idioma			VARCHAR(20) NOT NULL,
	versión			VARCHAR(30) NOT NULL,
	testamento		VARCHAR(20) NOT NULL,
	libro			VARCHAR(20) NOT NULL,
	capitulo		SMALLINT,
	versiculo		SMALLINT,

	CONSTRAINT PK_favorito PRIMARY KEY (id_favorito),
);

IF OBJECT_ID('busquedas') IS NOT NULL
	BEGIN
		DROP TABLE busquedas;
	END

CREATE TABLE busquedas (
	id_busqueda		UNIQUEIDENTIFIER NOT NULL,
	id_usuario		UNIQUEIDENTIFIER NOT NULL,
	id_historial	UNIQUEIDENTIFIER NOT NULL,
	idioma			VARCHAR(20) NOT NULL,
	versión			VARCHAR(30) NOT NULL,
	testamento		VARCHAR(20),
	libro			VARCHAR(20),
	capitulo		SMALLINT,
	versiculo		SMALLINT,
	busqueda		VARCHAR(100) NOT NULL,
	f_busqueda		DATETIME NOT NULL,

	CONSTRAINT PK_busquedas PRIMARY KEY (id_busqueda),
	
	CONSTRAINT FK_usuario_busqueda FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
	CONSTRAINT FK_historial_busqueda FOREIGN KEY (id_historial) REFERENCES historial(id_historial),
);

IF OBJECT_ID('consultas') IS NOT NULL
	BEGIN
		DROP TABLE consultas;
	END

CREATE TABLE consultas (
	id_consulta		UNIQUEIDENTIFIER NOT NULL,
	id_usuario		UNIQUEIDENTIFIER NOT NULL,
	id_historial	UNIQUEIDENTIFIER NOT NULL,
	idioma			VARCHAR(20) NOT NULL,
	versión			VARCHAR(30) NOT NULL,
	testamento		VARCHAR(20),
	libro			VARCHAR(20),
	capitulo		SMALLINT,
	versiculo		SMALLINT,
	vacio			VARCHAR(1),
	f_consulta		DATETIME NOT NULL,

	CONSTRAINT PK_consultas PRIMARY KEY (id_consulta),
	
	CONSTRAINT FK_usuario_consulta FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
	CONSTRAINT FK_historial_consulta FOREIGN KEY (id_historial) REFERENCES historial(id_historial),
);

IF OBJECT_ID('usuarios_favoritos') IS NOT NULL
	BEGIN
		DROP TABLE usuarios_favoritos;
	END

CREATE TABLE usuarios_favoritos (
	id_usuarios_favoritos	UNIQUEIDENTIFIER NOT NULL,
	id_usuario				UNIQUEIDENTIFIER NOT NULL,
	id_favorito				UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT PK_usuariosfavoritos PRIMARY KEY (id_usuarios_favoritos),

	CONSTRAINT FK_usuario_usuariosfavoritos FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
	CONSTRAINT FK_favorito_usuariosfavoritos FOREIGN KEY (id_favorito) REFERENCES favoritos(id_favorito)
);

IF OBJECT_ID('contrasenas') IS NOT NULL
	BEGIN
		DROP TABLE contrasenas;
	END

CREATE TABLE contrasenas (
	id_contrasena	UNIQUEIDENTIFIER NOT NULL,
	id_usuario		UNIQUEIDENTIFIER NOT NULL,
	contrasena		VARBINARY(64) NOT NULL,						--para hacer contraseñas seguras (tipo VARBINARY(64)), hay que usar la funcion HASHBYTES('SHA2_256', @Password)
	numero			TINYINT NOT NULL,
	
	CONSTRAINT PK_contrasenas PRIMARY KEY (id_contrasena),

	CONSTRAINT FK_usuario_contrasena FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario),
);
