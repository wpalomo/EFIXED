CREATE TABLE [dbo].[tb_directorio_tipo] (
    [IdTipoDirectorio] VARCHAR (20) NOT NULL,
    [Descripcion]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tb_directorio_tipo] PRIMARY KEY CLUSTERED ([IdTipoDirectorio] ASC)
);

