CREATE TABLE [dbo].[tb_Comprobante_tipo_estado] (
    [IdEstado_cbte]      VARCHAR (25)  NOT NULL,
    [descripcion_estado] VARCHAR (150) NULL,
    CONSTRAINT [PK_tb_Comprobante_estado] PRIMARY KEY CLUSTERED ([IdEstado_cbte] ASC)
);

