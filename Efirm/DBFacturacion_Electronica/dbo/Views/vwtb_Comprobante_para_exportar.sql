
--select * from vwtb_Comprobante_para_exportar

CREATE view [dbo].[vwtb_Comprobante_para_exportar]
as
SELECT        tb_Comprobante.IdEmpresa, tb_Comprobante.IdComprobante, tb_Comprobante.IdTipoDocumento, tb_Comprobante.IdEstado_cbte, tb_Comprobante.Cedula_Ruc, 
                         tb_Comprobante.Numero_Autorizacion, tb_Comprobante.RutaArchivo, tb_Comprobante.Nombre_file, tb_Comprobante.Fecha_Emi_Fact, 
                         tb_Comprobante.Fecha_transaccion, tb_Comprobante.FechaAutorizacion, tb_Comprobante.ClaveContingencia, tb_Comprobante.Ambiente, 
                         tb_Comprobante.Clave_Acceso, tb_Comprobante.EstadoDoc, tb_comprobante_exportado_base_ext.fecha_hora_exportacion, 
                         tb_Empresa.RazonSocial AS Nom_emisor, tb_Empresa.Tipo_Base_Exterior, tb_Empresa.cadena_conexion_Exterior, tb_Empresa.Cod_Empresa_Para_DB_Ext, 
                         tb_Contribuyente.Nom_Contribuyente
FROM            tb_Comprobante INNER JOIN
                         tb_Empresa ON tb_Comprobante.IdEmpresa = tb_Empresa.IdEmpresa INNER JOIN
                         tb_Contribuyente ON tb_Comprobante.IdEmpresa = tb_Contribuyente.IdEmpresa AND 
                         tb_Comprobante.Cedula_Ruc = tb_Contribuyente.cedulaRuc_contri LEFT OUTER JOIN
                         tb_comprobante_exportado_base_ext ON tb_Comprobante.IdEmpresa = tb_comprobante_exportado_base_ext.IdEmpresa AND 
                         tb_Comprobante.IdComprobante = tb_comprobante_exportado_base_ext.IdComprobante
WHERE        (tb_Comprobante.IdEstado_cbte = 'VALI_&_FIRM_&_REC') AND (tb_Comprobante.EstadoDoc = 'AUTORIZADO')
