USE REGISTROS;
GO
CREATE OR ALTER PROCEDURE sp_agregar_favorito(
    @idioma     VARCHAR(20),
    @version    VARCHAR(30),
    @testamento VARCHAR(20),
    @libro      VARCHAR(20),
    @capitulo   SMALLINT,
    @versiculo  SMALLINT = NULL,
    @id         UNIQUEIDENTIFIER
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_fav UNIQUEIDENTIFIER;

    -- Verificar si ya existe un favorito con las mismas condiciones utilizando la función
    SET @id_fav = dbo.FavoritoExistente(@idioma, @version, @testamento, @libro, @capitulo, @versiculo);

    IF @id_fav IS NULL
    BEGIN
        SET @id_fav = NEWID();
        INSERT INTO favoritos VALUES (@id_fav, @idioma, @version, @testamento, @libro, @capitulo, @versiculo);
    END

    INSERT INTO usuarios_favoritos VALUES (NEWID(), @id, @id_fav);

END;
