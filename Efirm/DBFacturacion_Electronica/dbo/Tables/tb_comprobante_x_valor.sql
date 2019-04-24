CREATE TABLE [dbo].[tb_comprobante_x_valor](
	[IdEmpresa] [int] NOT NULL,
	[IdComprobante] [varchar](30) NOT NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_tb_comprobante_x_valor] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO