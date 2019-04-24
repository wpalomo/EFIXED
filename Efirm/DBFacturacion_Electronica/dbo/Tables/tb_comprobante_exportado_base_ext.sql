CREATE TABLE [dbo].[tb_comprobante_exportado_base_ext] (
    [IdEmpresa]              INT           NOT NULL,
    [IdComprobante]          VARCHAR (100) NOT NULL,
    [IdTipoDocumento]        VARCHAR (10)  NOT NULL,
    [observacion]            VARCHAR (150) NOT NULL,
    [fecha_hora_exportacion] DATETIME      NOT NULL,
    CONSTRAINT [PK_tb_comprobante_exportado_base_ext_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdComprobante] ASC)
);

