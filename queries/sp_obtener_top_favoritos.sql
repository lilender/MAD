USE REGISTROS;
GO
CREATE OR ALTER PROCEDURE sp_obtener_top_favoritos
	AS
	BEGIN
	SELECT
    f.versión,
    f.testamento,
    f.libro,
    f.capitulo,
    f.versiculo,
    f.texto,
	t.N,
    t.id_favorito
	FROM v_top_favoritos_ID t
	JOIN v_favoritos f ON t.id_favorito = f.id_favorito
	ORDER BY t.N DESC;
	END

