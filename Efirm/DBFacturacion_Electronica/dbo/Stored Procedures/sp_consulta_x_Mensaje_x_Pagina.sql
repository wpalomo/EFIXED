

CREATE   PROCEDURE [dbo].[sp_consulta_x_Mensaje_x_Pagina]
 @Pagina Int ,
 @RegistrosporPagina Int ,
 @TipoCorreo varchar(30),
 @direccionCorreo varchar(100),
 @CadenaBusqueda Varchar(100)
AS

BEGIN

SET NOCOUNT ON;

			SELECT * FROM (
					SELECT ROW_NUMBER()Over(Order by dbo.vw_Mensaje_x_Contribuyente.Fecha desc) As RowNum, 
					dbo.vw_Mensaje_x_Contribuyente.*
					FROM dbo.vw_Mensaje_x_Contribuyente
					where  dbo.vw_Mensaje_x_Contribuyente.IdTipo_Mensaje = @TipoCorreo
					AND dbo.vw_Mensaje_x_Contribuyente.mail_remitente = @direccionCorreo
					AND ':' + dbo.vw_Mensaje_x_Contribuyente.Para + ':' + dbo.vw_Mensaje_x_Contribuyente.Nom_Contribuyente + ':' 
					+ dbo.vw_Mensaje_x_Contribuyente.cedulaRuc_contri  
					+  dbo.vw_Mensaje_x_Contribuyente.Mail + ':' + dbo.vw_Mensaje_x_Contribuyente.RazonSocial_Emisor + ':' 
					+ dbo.vw_Mensaje_x_Contribuyente.Asunto + ':' +  dbo.vw_Mensaje_x_Contribuyente.Asunto_texto_mostrado
					LIKE '%' + @CadenaBusqueda + '%'
			)
			AS ResultadoPaginado
			WHERE RowNum BETWEEN (@Pagina - 1) * @RegistrosporPagina + 1 AND @Pagina * @RegistrosporPagina

END




