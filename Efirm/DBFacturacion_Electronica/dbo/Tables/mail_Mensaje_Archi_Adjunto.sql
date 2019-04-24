CREATE TABLE [dbo].[mail_Mensaje_Archi_Adjunto] (
    [IdMensaje]         NUMERIC (18)    NOT NULL,
    [Secuencia]         INT             NOT NULL,
    [Archivo_adjunto]   VARBINARY (MAX) NULL,
    [descripcion_archi] VARCHAR (150)   NULL,
    [extencion]         VARCHAR (10)    NULL,
    [IdComprobante]     VARCHAR (100)   NULL,
    [IdEmpresa]         INT             NULL,
    CONSTRAINT [PK_mail_Mensaje_Archi_Adjunto] PRIMARY KEY CLUSTERED ([IdMensaje] ASC, [Secuencia] ASC),
    CONSTRAINT [FK_mail_Mensaje_Archi_Adjunto_mail_Mensaje] FOREIGN KEY ([IdMensaje]) REFERENCES [dbo].[mail_Mensaje] ([IdMensaje])
);

