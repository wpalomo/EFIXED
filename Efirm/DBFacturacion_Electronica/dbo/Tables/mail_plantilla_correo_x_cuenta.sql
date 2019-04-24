CREATE TABLE [dbo].[mail_plantilla_correo_x_cuenta] (
    [IdCuenta]      VARCHAR (50)  NOT NULL,
    [Asunto]        VARCHAR (50)  NOT NULL,
    [cuerpo_correo] VARCHAR (300) NOT NULL,
    CONSTRAINT [PK_mail_plantilla_correo_x_cuenta] PRIMARY KEY CLUSTERED ([IdCuenta] ASC)
);

