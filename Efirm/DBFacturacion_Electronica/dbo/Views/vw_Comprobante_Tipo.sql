CREATE view vw_Comprobante_Tipo as 
SELECT        A.IdEmpresa, A.descripcion_tipo, A.cod_tipo, B.File_disenio_rpt, A.RazonSocial, A.IdComprobante_tipo, ' ' AS RUC
FROM            (SELECT        dbo.tb_Empresa.IdEmpresa, dbo.tb_Comprobante_tipo.IdComprobante_tipo, dbo.tb_Comprobante_tipo.cod_tipo, dbo.tb_Comprobante_tipo.descripcion_tipo, dbo.tb_Empresa.RazonSocial
                          FROM            dbo.tb_Empresa CROSS JOIN
                                                    dbo.tb_Comprobante_tipo) AS A LEFT OUTER JOIN
                         dbo.tb_Comprobante_tipo_x_empresa AS B ON A.IdEmpresa = B.IdEmpresa AND A.IdComprobante_tipo = B.IdComprobante_tipo







