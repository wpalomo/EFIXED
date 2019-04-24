CREATE TABLE [dbo].[tb_Usuario_Tocken] (
    [IdUsuario_Tocken]   VARCHAR (150) NOT NULL,
    [Nom_usuario_tocken] VARCHAR (150) NOT NULL,
    [estado]             CHAR (1)      NOT NULL,
    CONSTRAINT [PK_tb_Usuario_Tocken] PRIMARY KEY CLUSTERED ([IdUsuario_Tocken] ASC)
);

