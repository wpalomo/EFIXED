CREATE TABLE [dbo].[tb_Tocken_x_Usuario_Tocken] (
    [IdTocken]         VARCHAR (150) NOT NULL,
    [IdUsuario_Tocken] VARCHAR (50)  NOT NULL,
    [Observacion]      VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_tb_Tocken_x_Usuario_Tocken] PRIMARY KEY CLUSTERED ([IdTocken] ASC, [IdUsuario_Tocken] ASC)
);

