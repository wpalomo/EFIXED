CREATE TABLE [dbo].[tb_Comprobante_estado_proceso] (
    [IdEstadoProceso] VARCHAR (15) NOT NULL,
    [Descripcion]     VARCHAR (50) NULL,
    CONSTRAINT [PK_tb_Comprobante_estado_proceso] PRIMARY KEY CLUSTERED ([IdEstadoProceso] ASC)
);

