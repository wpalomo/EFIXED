

CREATE VIEW [dbo].[vw_Mensaje_x_Contribuyente]
AS
SELECT        dbo.mail_Mensaje.IdMensaje, dbo.mail_Mensaje.Fecha, dbo.mail_Mensaje.Para, dbo.mail_Mensaje.Asunto, dbo.mail_Mensaje.Asunto_texto_mostrado, 
                         dbo.mail_Mensaje.Tiene_Adjunto, dbo.mail_Mensaje.Prioridad, dbo.mail_Mensaje.Leido, dbo.mail_Mensaje.Respondido, dbo.mail_Mensaje.No_Leido, 
                         dbo.mail_Mensaje.Texto_mensaje, dbo.mail_Mensaje.IdTipo_Mensaje, dbo.mail_Mensaje.Eliminado, dbo.mail_Mensaje.IdContribuyente, 
                         dbo.tb_Contribuyente.IdEmpresa, dbo.tb_Contribuyente.cedulaRuc_contri, dbo.tb_Contribuyente.Nom_Contribuyente, dbo.tb_Contribuyente.Mail, 
                         dbo.tb_Contribuyente.Mail_secundario, dbo.tb_Contribuyente.EsCliente, dbo.tb_Contribuyente.EsProveedor, dbo.tb_Contribuyente.Password, 
                         dbo.tb_Contribuyente.Estado, dbo.tb_Contribuyente.Observacion, dbo.tb_Contribuyente.TipoContacto, dbo.tb_Contribuyente.Direccion, 
                         dbo.tb_Contribuyente.Telefono, dbo.tb_Empresa.RazonSocial AS RazonSocial_Emisor, dbo.tb_Empresa.RUC AS RUC_Emisor, dbo.mail_Mensaje.mail_remitente, 
                         dbo.mail_Mensaje.Para_CC, dbo.mail_Mensaje.codMensajeId, dbo.mail_Mensaje.IdCuenta, dbo.mail_Mensaje.Archivo_correo
						 ,dbo.mail_Mensaje.Para_CCO
FROM            dbo.tb_Empresa INNER JOIN
                         dbo.tb_Contribuyente ON dbo.tb_Empresa.IdEmpresa = dbo.tb_Contribuyente.IdEmpresa RIGHT OUTER JOIN
                         dbo.mail_Mensaje ON dbo.tb_Contribuyente.IdContribuyente = dbo.mail_Mensaje.IdContribuyente


