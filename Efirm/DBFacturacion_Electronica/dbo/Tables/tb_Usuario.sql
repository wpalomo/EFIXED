CREATE TABLE [dbo].[tb_Usuario] (
    [IdUsuario]   INT          NOT NULL,
    [Usuario]     VARCHAR (50) NOT NULL,
    [Contrasenia] VARCHAR (50) NOT NULL,
    [Estado]      BIT          NOT NULL,
    CONSTRAINT [PK_tb_Usuario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

