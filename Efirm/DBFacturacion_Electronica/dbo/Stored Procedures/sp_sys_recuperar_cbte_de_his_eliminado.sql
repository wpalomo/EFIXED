
CREATE proc [dbo].[sp_sys_recuperar_cbte_de_his_eliminado]
(
 @IdEmpresa int
,@IdComprobante varchar(50)
)
as


INSERT INTO [dbo].[tb_Comprobante]
([IdEmpresa]			,[IdComprobante]	,[IdTipoDocumento]	,[IdEstado_cbte]	,[Cedula_Ruc]
,[Numero_Autorizacion]	,[RutaArchivo]		,[Nombre_file]		,[s_XML]			,[Fecha_Emi_Fact]
,[Fecha_transaccion]	,[FechaAutorizacion],[ClaveContingencia],[EstadoDoc]		,[Error]
,[IdEstadoProceso]		,[IdError_Sri]		,[RespuestaSRI]		,[Total]			
)	
select 
 [IdEmpresa]			,[IdComprobante]	,[IdTipoDocumento]	,[IdEstado_cbte]	,[Cedula_Ruc]
,[Numero_Autorizacion]	,[RutaArchivo]		,[Nombre_file]		,[s_XML]			,[Fecha_Emi_Fact]
,[Fecha_transaccion]	,[FechaAutorizacion],[ClaveContingencia],[EstadoDoc]		,[Error]
,[IdEstadoProceso]		,[IdError_Sri]		,[RespuestaSRI]		,[Total]			
from 
[dbo].[tb_Comprobante_Hist_Eliminado] 
where IdComprobante =@IdComprobante
and IdEmpresa=@IdEmpresa
