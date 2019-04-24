CREATE TABLE [dbo].[mail_Catalogo] (
    [IdCatalogo]     VARCHAR (50) NOT NULL,
    [nom_catalogo]   VARCHAR (50) NULL,
    [IdTipoCatalogo] VARCHAR (50) NULL,
    [estado]         CHAR (1)     NULL,
    CONSTRAINT [PK_mail_Catalogo] PRIMARY KEY CLUSTERED ([IdCatalogo] ASC),
    CONSTRAINT [FK_mail_Catalogo_mail_Catalogo_Tipo] FOREIGN KEY ([IdTipoCatalogo]) REFERENCES [dbo].[mail_Catalogo_Tipo] ([IdTipoCatalogo])
);

