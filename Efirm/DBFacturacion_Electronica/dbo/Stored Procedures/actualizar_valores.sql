create procedure [dbo].[actualizar_valores] as
UPDATE tb_Comprobante       SET Total=comp_valor.Total
FROM            dbo.tb_Comprobante AS comp INNER JOIN
                         dbo.tb_comprobante_x_valor AS comp_valor ON comp.IdEmpresa = comp_valor.IdEmpresa AND comp.IdComprobante = comp_valor.IdComprobante
						 and( comp.Total =0 or comp.Total is null)
						 and comp.IdComprobante like '%FA%'
