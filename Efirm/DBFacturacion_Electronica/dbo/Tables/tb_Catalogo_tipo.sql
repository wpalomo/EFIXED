CREATE TABLE [dbo].[tb_Catalogo_tipo] (
    [IdTipoCatalogo] INT           NOT NULL,
    [Descripcion]    VARCHAR (100) NOT NULL,
    [Estado]         BIT           NOT NULL,
    CONSTRAINT [PK_tb_Catalogo_tipo] PRIMARY KEY CLUSTERED ([IdTipoCatalogo] ASC)
);

