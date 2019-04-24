CREATE TABLE [dbo].[tb_Clave_Conting] (
    [IdEmpresa]         INT           NOT NULL,
    [IdClave]           DECIMAL (18)  NOT NULL,
    [Usado]             BIT           NOT NULL,
    [Fecha_Trans]       DATETIME      NOT NULL,
    [ClaveContingencia] VARCHAR (150) NOT NULL,
    [Fecha_Importacion] DATETIME      NOT NULL,
    [Estado]            BIT           NOT NULL,
    [IdAmbiente]        INT           NULL,
    CONSTRAINT [PK_tb_Clave_Contin] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdClave] ASC),
    CONSTRAINT [FK_tb_Clave_Contin_tb_Empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_Empresa] ([IdEmpresa])
);

