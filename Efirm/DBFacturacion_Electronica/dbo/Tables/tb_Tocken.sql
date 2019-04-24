CREATE TABLE [dbo].[tb_Tocken] (
    [IdTocken]   VARCHAR (150) NOT NULL,
    [nom_tocken] VARCHAR (250) NOT NULL,
    [Password]   VARCHAR (50)  NOT NULL,
    [Serie]      VARCHAR (150) NOT NULL,
    [Modelo]     VARCHAR (150) NOT NULL,
    [IdTipo]     VARCHAR (50)  NOT NULL,
    [Estado]     CHAR (1)      NOT NULL,
    CONSTRAINT [PK_tb_Tocken_disponibles] PRIMARY KEY CLUSTERED ([IdTocken] ASC)
);

