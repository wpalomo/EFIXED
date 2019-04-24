CREATE TABLE [dbo].[tb_Sucursal] (
    [IdEmpresa]          INT           NOT NULL,
    [IdSucursal]         INT           NOT NULL,
    [DirEstablecimiento] VARCHAR (300) NOT NULL,
    [Establecimiento]    VARCHAR (3)   NOT NULL,
    [PtoEmision]         VARCHAR (3)   NOT NULL,
    [Secuencial]         VARCHAR (25)  NOT NULL,
    [Estado]             BIT           NOT NULL,
    CONSTRAINT [PK_tb_Sucursal] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdSucursal] ASC),
    CONSTRAINT [FK_tb_Sucursal_tb_Empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_Empresa] ([IdEmpresa])
);

