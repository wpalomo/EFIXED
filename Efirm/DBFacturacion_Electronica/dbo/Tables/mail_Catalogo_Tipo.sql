CREATE TABLE [dbo].[mail_Catalogo_Tipo] (
    [IdTipoCatalogo]   VARCHAR (50) NOT NULL,
    [nom_TipoCatalogo] VARCHAR (50) NULL,
    [estado]           CHAR (1)     NULL,
    CONSTRAINT [PK_mail_Catalogo_Tipo] PRIMARY KEY CLUSTERED ([IdTipoCatalogo] ASC)
);

