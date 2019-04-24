CREATE TABLE [dbo].[seg_usuario] (
    [IdUsuario]      VARCHAR (50)  NOT NULL,
    [us_contrasenia] VARCHAR (300) NOT NULL,
    [us_nombre]      VARCHAR (300) NOT NULL,
    [estado]         BIT           NOT NULL,
    CONSTRAINT [PK_seg_usuario] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

