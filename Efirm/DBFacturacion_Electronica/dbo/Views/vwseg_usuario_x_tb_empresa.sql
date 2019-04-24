CREATE VIEW [dbo].[vwseg_usuario_x_tb_empresa]
AS
SELECT dbo.seg_usuario_x_tb_empresa.IdEmpresa, dbo.seg_usuario_x_tb_empresa.IdUsuario, dbo.tb_empresa.RazonSocial, dbo.seg_usuario.us_contrasenia, dbo.seg_usuario.us_nombre
FROM     dbo.seg_usuario INNER JOIN
                  dbo.seg_usuario_x_tb_empresa ON dbo.seg_usuario.IdUsuario = dbo.seg_usuario_x_tb_empresa.IdUsuario INNER JOIN
                  dbo.tb_empresa ON dbo.seg_usuario_x_tb_empresa.IdEmpresa = dbo.tb_empresa.IdEmpresa