CREATE TABLE [dbo].[tb_Comprobante_tipo] (
    [IdComprobante_tipo] VARCHAR (10) NOT NULL,
    [cod_tipo]           VARCHAR (4)  NULL,
    [descripcion_tipo]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tb_Comprobante_tipo] PRIMARY KEY CLUSTERED ([IdComprobante_tipo] ASC)
);

