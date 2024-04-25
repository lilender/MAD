USE REGISTROS;

GO
CREATE OR ALTER VIEW v_top_favoritos_ID
AS

SELECT TOP 5
    uf.id_favorito,
    COUNT(*) AS N
FROM usuarios_favoritos uf
GROUP BY uf.id_favorito
ORDER BY N DESC;
