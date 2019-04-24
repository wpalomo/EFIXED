
CREATE PROCEDURE [dbo].[sp_consulta_x_CbteVALI_FIRM_REC_x_Pagina]
(
 @IdEmpresaIni Int,
 @IdEmpresaFin Int,
 @IdTipoCbteIni varchar(20),
 @IdTipoCbteFin varchar(20),
 @Pagina Int ,
 @RegistrosporPagina Int, 
 @FechaIni Datetime,
 @FechaFin Datetime,
 @IdEstado_cbte  varchar(30),
 @EstadoDoc varchar(30),
 @IdEstadoProceso varchar(30),
 @CadenaBusqueda varchar(100)
 )
AS

BEGIN



SELECT *
FROM (
				SELECT ROW_NUMBER()Over(Order by A.Fecha_Emi_Fact desc) As RowNum, 
				  A.IdEmpresa				, A.IdComprobante	, A.IdTipoDocumento	, A.IdEstado_cbte		, A.Cedula_Ruc			, A.Numero_Autorizacion
				, A.RutaArchivo				, A.Nombre_file		, A.Fecha_Emi_Fact	, A.Fecha_transaccion	, A.FechaAutorizacion	, A.ClaveContingencia
				, A.EstadoDoc				, A.Error			, A.IdError_Sri		, A.Nom_emisor			, A.Nom_Tipo_doc		, A.Nom_estado_doc
				, A.IdEstadoProceso			, A.RespuestaSRI	, A.Ambiente		, A.Clave_Acceso		, A.Nom_Contribuyente	, A.Tipo_Base_Exterior
				, A.cadena_conexion_Exterior, A.Cod_Empresa_Para_DB_Ext,A.Total
				FROM dbo.vw_Comprobante A
				where  A.Fecha_Emi_Fact >= @FechaIni
				AND A.Fecha_Emi_Fact <= @FechaFin
				AND A.IdEstado_cbte = @IdEstado_cbte
				AND A.EstadoDoc like '%'+ @EstadoDoc + '%'
				AND A.IdEstadoProceso = @IdEstadoProceso
				AND ':' + IdComprobante + ':' + A.Nom_Contribuyente + ':' + A.Cedula_Ruc 
				+ ':' + Nom_emisor LIKE '%' + @CadenaBusqueda + '%'
				and IdEmpresa between @IdEmpresaIni and @IdEmpresaFin
				and IdTipoDocumento between @IdTipoCbteIni  and @IdTipoCbteFin
)
AS ResultadoPaginado 
WHERE RowNum BETWEEN (@Pagina - 1) * @RegistrosporPagina + 1 AND @Pagina * @RegistrosporPagina

END





