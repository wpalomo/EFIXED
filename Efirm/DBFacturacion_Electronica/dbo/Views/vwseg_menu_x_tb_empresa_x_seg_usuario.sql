
CREATE VIEW [dbo].[vwseg_menu_x_tb_empresa_x_seg_usuario]
AS
SELECT seg_menu_x_tb_empresa_x_seg_usuario.IdEmpresa, seg_menu_x_tb_empresa_x_seg_usuario.IdMenu, seg_menu_x_tb_empresa_x_seg_usuario.IdUsuario, seg_menu_x_tb_empresa_x_seg_usuario.nuevo, 
                  seg_menu_x_tb_empresa_x_seg_usuario.modificar, seg_menu_x_tb_empresa_x_seg_usuario.consultar, seg_menu_x_tb_empresa_x_seg_usuario.anular
FROM     seg_menu INNER JOIN
                  seg_menu_x_tb_empresa ON seg_menu.IdMenu = seg_menu_x_tb_empresa.IdMenu INNER JOIN
                  seg_menu_x_tb_empresa_x_seg_usuario ON seg_menu_x_tb_empresa.IdMenu = seg_menu_x_tb_empresa_x_seg_usuario.IdMenu AND seg_menu_x_tb_empresa.IdEmpresa = seg_menu_x_tb_empresa_x_seg_usuario.IdEmpresa