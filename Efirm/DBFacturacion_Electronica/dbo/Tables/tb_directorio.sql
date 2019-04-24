CREATE TABLE [dbo].[tb_directorio] (
    [IdTipoDirectorio] VARCHAR (20)  NOT NULL,
    [Ruta_directorio]  VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tb_directorio_1] PRIMARY KEY CLUSTERED ([IdTipoDirectorio] ASC)
);

