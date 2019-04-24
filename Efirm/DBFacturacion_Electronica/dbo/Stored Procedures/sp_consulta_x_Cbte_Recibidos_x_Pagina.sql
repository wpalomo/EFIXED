
CREATE    PROCEDURE [dbo].[sp_consulta_x_Cbte_Recibidos_x_Pagina]
 @Pagina Int ,
 @RegistrosporPagina Int, 
 @FechaIni Datetime,
 @FechaFin Datetime,
 @CadenaBusqueda Varchar(100)
AS

BEGIN

SET NOCOUNT ON;

SELECT * FROM (
SELECT ROW_NUMBER()Over(Order by dbo.vw_Comprobantes_recibidos.Fecha desc) As RowNum, 

dbo.vw_Comprobantes_recibidos.*

FROM dbo.vw_Comprobantes_recibidos
where  dbo.vw_Comprobantes_recibidos.Fecha >= @FechaIni
AND dbo.vw_Comprobantes_recibidos.Fecha <= @FechaFin
AND ':' + dbo.vw_Comprobantes_recibidos.Ced_Ruc_Emisor + ':' + dbo.vw_Comprobantes_recibidos.Razon_Social_emisor 
+ ':' + dbo.vw_Comprobantes_recibidos.descripcion_archi + ':' + dbo.vw_Comprobantes_recibidos.IdCuenta
+ ':' + dbo.vw_Comprobantes_recibidos.Para   LIKE '%' + @CadenaBusqueda + '%'
)
AS ResultadoPaginado
WHERE RowNum BETWEEN (@Pagina - 1) * @RegistrosporPagina + 1 AND @Pagina * @RegistrosporPagina

END



