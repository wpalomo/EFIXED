CREATE TABLE [dbo].[mail_Cuentas_Correo_x_Empresa] (
    [IdEmpresa]   INT          NOT NULL,
    [IdCuenta]    VARCHAR (50) NOT NULL,
    [observacion] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_mail_Cuentas_Correo_x_Empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdCuenta] ASC),
    CONSTRAINT [FK_mail_Cuentas_Correo_x_Empresa_mail_Cuentas_Correo] FOREIGN KEY ([IdCuenta]) REFERENCES [dbo].[mail_Cuentas_Correo] ([IdCuenta]),
    CONSTRAINT [FK_mail_Cuentas_Correo_x_Empresa_tb_Empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_Empresa] ([IdEmpresa])
);

