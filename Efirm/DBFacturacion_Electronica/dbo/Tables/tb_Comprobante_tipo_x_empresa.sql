CREATE TABLE [dbo].[tb_Comprobante_tipo_x_empresa] (
    [IdEmpresa]          INT             NOT NULL,
    [IdComprobante_tipo] VARCHAR (10)    NOT NULL,
    [File_disenio_rpt]   VARBINARY (MAX) NULL,
    CONSTRAINT [PK_tb_Comprobante_tipo_x_empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdComprobante_tipo] ASC)
);

