CREATE TABLE [dbo].[tb_Catalogo] (
    [IdCatalogo]     VARCHAR (10)  NOT NULL,
    [IdTIpoCatalogo] INT           NOT NULL,
    [Codigo]         VARCHAR (10)  NOT NULL,
    [Descripcion]    VARCHAR (100) NOT NULL,
    [Estado]         BIT           NULL,
    CONSTRAINT [PK_tb_Catalogo] PRIMARY KEY CLUSTERED ([IdCatalogo] ASC),
    CONSTRAINT [FK_tb_Catalogo_tb_Catalogo_tipo] FOREIGN KEY ([IdTIpoCatalogo]) REFERENCES [dbo].[tb_Catalogo_tipo] ([IdTipoCatalogo])
);

