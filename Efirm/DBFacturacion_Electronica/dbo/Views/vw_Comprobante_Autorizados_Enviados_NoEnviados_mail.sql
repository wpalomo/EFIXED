
CREATE view [dbo].[vw_Comprobante_Autorizados_Enviados_NoEnviados_mail]
as
SELECT DISTINCT 
                      tb_Comprobante.IdEmpresa, tb_Comprobante.IdComprobante, tb_Comprobante.IdTipoDocumento, tb_Comprobante.IdEstado_cbte, tb_Comprobante.Cedula_Ruc, 
                      tb_Comprobante.Numero_Autorizacion, tb_Comprobante.RutaArchivo, tb_Comprobante.Nombre_file, tb_Comprobante.Fecha_Emi_Fact, 
                      tb_Comprobante.Fecha_transaccion, tb_Comprobante.FechaAutorizacion, tb_Comprobante.ClaveContingencia, tb_Comprobante.EstadoDoc, tb_Comprobante.Error, 
                      tb_Comprobante.IdEstadoProceso, tb_Comprobante.IdError_Sri, tb_Comprobante.RespuestaSRI, tb_Comprobante.Total, tb_Comprobante.Ambiente, 
                      tb_Comprobante.Clave_Acceso, CASE WHEN mail_Mensaje_Archi_Adjunto.IdComprobante IS NULL 
                      THEN 0 WHEN mail_Mensaje_Archi_Adjunto.IdComprobante IS NOT NULL THEN 1 END AS mail_enviado, tb_Empresa.RazonSocial AS Nom_emisor, 
                      tb_Contribuyente.Nom_Contribuyente
FROM         tb_Empresa INNER JOIN
                      tb_Comprobante ON tb_Empresa.IdEmpresa = tb_Comprobante.IdEmpresa INNER JOIN
                      tb_Contribuyente ON tb_Comprobante.IdEmpresa = tb_Contribuyente.IdEmpresa AND 
                      tb_Comprobante.Cedula_Ruc = tb_Contribuyente.cedulaRuc_contri LEFT OUTER JOIN
                      mail_Mensaje_Archi_Adjunto ON tb_Comprobante.IdEmpresa = mail_Mensaje_Archi_Adjunto.IdEmpresa AND 
                      tb_Comprobante.IdComprobante = mail_Mensaje_Archi_Adjunto.IdComprobante
WHERE     (tb_Comprobante.IdEstado_cbte = 'VALI_&_FIRM_&_REC') AND (tb_Comprobante.EstadoDoc = 'AUTORIZADO')
