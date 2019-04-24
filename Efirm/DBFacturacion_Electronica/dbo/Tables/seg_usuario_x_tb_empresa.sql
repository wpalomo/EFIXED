CREATE TABLE [dbo].[seg_usuario_x_tb_empresa] (
    [IdEmpresa]   INT          NOT NULL,
    [IdUsuario]   VARCHAR (50) NOT NULL,
    [observacion] VARCHAR (50) NULL,
    CONSTRAINT [PK_seg_usuario_x_tb_empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdUsuario] ASC),
    CONSTRAINT [FK_seg_usuario_x_tb_empresa_seg_usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[seg_usuario] ([IdUsuario]),
    CONSTRAINT [FK_seg_usuario_x_tb_empresa_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_Empresa] ([IdEmpresa])
);

