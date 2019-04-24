CREATE TABLE [dbo].[mail_Mensaje_Tipo] (
    [IdTipo_Mensaje] VARCHAR (25) NOT NULL,
    [descripcion]    VARCHAR (50) NOT NULL,
    [orden]          INT          NULL,
    [estado]         CHAR (1)     NULL,
    CONSTRAINT [PK_mail_Mensaje_Tipo] PRIMARY KEY CLUSTERED ([IdTipo_Mensaje] ASC)
);

