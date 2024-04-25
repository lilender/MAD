USE REGISTROS;
GO

-- Crear o alterar la función de utilidad
CREATE OR ALTER FUNCTION FavoritoExistente(
    @idioma     VARCHAR(20),
    @version    VARCHAR(30),
    @testamento VARCHAR(20),
    @libro      VARCHAR(20),
    @capitulo   SMALLINT,
    @versiculo  SMALLINT = NULL
)
RETURNS UNIQUEIDENTIFIER
AS
BEGIN
    DECLARE @id_fav UNIQUEIDENTIFIER;

    SELECT @id_fav = F.id_favorito
    FROM favoritos F
    JOIN usuarios_favoritos UF ON F.id_favorito = UF.id_favorito
    WHERE F.idioma = @idioma
      AND F.versión = @version
      AND F.testamento = @testamento
      AND F.libro = @libro
      AND F.capitulo = @capitulo
      AND ((F.versiculo = @versiculo) OR (F.versiculo IS NULL AND @versiculo IS NULL));

    RETURN ISNULL(@id_fav, NULL);
END;
GO

