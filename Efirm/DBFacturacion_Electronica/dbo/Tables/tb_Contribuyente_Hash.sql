CREATE TABLE [dbo].[tb_Contribuyente_Hash] (
    [IdEmpresa]       INT           NOT NULL,
    [IdContribuyente] NUMERIC (18)  NOT NULL,
    [hash]            VARCHAR (MAX) NULL,
    CONSTRAINT [PK_tb_Contribuyente_Hash] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdContribuyente] ASC)
);

