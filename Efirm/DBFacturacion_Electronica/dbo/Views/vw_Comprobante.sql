CREATE VIEW [dbo].[vw_Comprobante]
AS
SELECT        dbo.tb_Comprobante.IdEmpresa, dbo.tb_Comprobante.IdComprobante, dbo.tb_Comprobante.IdTipoDocumento, dbo.tb_Comprobante.IdEstado_cbte, 
                         dbo.tb_Comprobante.Cedula_Ruc, dbo.tb_Comprobante.Numero_Autorizacion, dbo.tb_Comprobante.RutaArchivo, dbo.tb_Comprobante.Nombre_file, 
                         dbo.tb_Comprobante.s_XML, dbo.tb_Comprobante.Fecha_Emi_Fact, dbo.tb_Comprobante.Fecha_transaccion, dbo.tb_Comprobante.FechaAutorizacion, 
                         dbo.tb_Comprobante.ClaveContingencia, dbo.tb_Comprobante.EstadoDoc, dbo.tb_Comprobante.Error, dbo.tb_Comprobante.IdError_Sri, 
                         dbo.tb_Empresa.RazonSocial AS Nom_emisor, dbo.tb_Catalogo.Descripcion AS Nom_Tipo_doc, 
                         dbo.tb_Comprobante_tipo_estado.descripcion_estado AS Nom_estado_doc, dbo.tb_Comprobante.IdEstadoProceso, dbo.tb_Comprobante.RespuestaSRI, 
                         dbo.tb_Comprobante.Ambiente, dbo.tb_Comprobante.Clave_Acceso, dbo.tb_Contribuyente.Nom_Contribuyente, dbo.tb_Empresa.Tipo_Base_Exterior, 
                         dbo.tb_Empresa.cadena_conexion_Exterior, dbo.tb_Empresa.Cod_Empresa_Para_DB_Ext,tb_Comprobante.Total
FROM            dbo.tb_Comprobante INNER JOIN
                         dbo.tb_Empresa ON dbo.tb_Comprobante.IdEmpresa = dbo.tb_Empresa.IdEmpresa INNER JOIN
                         dbo.tb_Catalogo ON dbo.tb_Comprobante.IdTipoDocumento = dbo.tb_Catalogo.IdCatalogo INNER JOIN
                         dbo.tb_Comprobante_tipo_estado ON dbo.tb_Comprobante.IdEstado_cbte = dbo.tb_Comprobante_tipo_estado.IdEstado_cbte LEFT OUTER JOIN
                         dbo.tb_Contribuyente ON dbo.tb_Comprobante.IdEmpresa = dbo.tb_Contribuyente.IdEmpresa AND 
                         dbo.tb_Comprobante.Cedula_Ruc = dbo.tb_Contribuyente.cedulaRuc_contri


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[4] 2[55] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tb_Comprobante"
            Begin Extent = 
               Top = 0
               Left = 31
               Bottom = 149
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "tb_Empresa"
            Begin Extent = 
               Top = 6
               Left = 267
               Bottom = 155
               Right = 463
            End
            DisplayFlags = 280
            TopColumn = 17
         End
         Begin Table = "tb_Catalogo"
            Begin Extent = 
               Top = 173
               Left = 286
               Bottom = 292
               Right = 450
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_Comprobante_tipo_estado"
            Begin Extent = 
               Top = 108
               Left = 572
               Bottom = 197
               Right = 753
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_Contribuyente"
            Begin Extent = 
               Top = 6
               Left = 791
               Bottom = 135
               Right = 1021
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Co', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Comprobante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'lumn = 1440
         Alias = 1455
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Comprobante';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Comprobante';

