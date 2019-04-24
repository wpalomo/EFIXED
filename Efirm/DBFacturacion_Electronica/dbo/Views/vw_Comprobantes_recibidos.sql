
CREATE VIEW [dbo].[vw_Comprobantes_recibidos]
AS
SELECT        dbo.mail_Mensaje_Archi_Adjunto.descripcion_archi, dbo.mail_Mensaje_Archi_Adjunto.extencion, dbo.mail_Mensaje.Fecha, dbo.mail_Mensaje.Asunto, 
                         dbo.mail_Mensaje.mail_remitente AS mail_emisor, '' AS Ced_Ruc_Emisor, '' AS Razon_Social_emisor, '' AS sXml, dbo.mail_Mensaje.IdTipo_Mensaje, 
                         dbo.mail_Mensaje.codMensajeId, dbo.mail_Mensaje.IdCuenta, dbo.mail_Mensaje.Texto_mensaje, dbo.mail_Mensaje_Archi_Adjunto.Secuencia, 
                         dbo.mail_Mensaje_Archi_Adjunto.Archivo_adjunto, dbo.mail_Mensaje.Para, dbo.mail_Mensaje.IdMensaje, '' AS Ambiente, '' AS TipoDocumento
FROM            dbo.mail_Mensaje INNER JOIN
                         dbo.mail_Mensaje_Archi_Adjunto ON dbo.mail_Mensaje.IdMensaje = dbo.mail_Mensaje_Archi_Adjunto.IdMensaje
WHERE        (dbo.mail_Mensaje.IdTipo_Mensaje = 'Buzon_Ent')

