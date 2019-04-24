CREATE TABLE [dbo].[seg_menu_x_tb_empresa_x_seg_usuario] (
    [IdEmpresa] INT          NOT NULL,
    [IdMenu]    INT          NOT NULL,
    [IdUsuario] VARCHAR (50) NOT NULL,
    [nuevo]     BIT          NOT NULL,
    [modificar] BIT          NOT NULL,
    [consultar] BIT          NOT NULL,
    [anular]    BIT          NOT NULL,
    CONSTRAINT [PK_seg_menu_x_tb_empresa_x_seg_usuario] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdMenu] ASC, [IdUsuario] ASC),
    CONSTRAINT [FK_seg_menu_x_tb_empresa_x_seg_usuario_seg_menu] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[seg_menu] ([IdMenu]),
    CONSTRAINT [FK_seg_menu_x_tb_empresa_x_seg_usuario_seg_usuario] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[seg_usuario] ([IdUsuario]),
    CONSTRAINT [FK_seg_menu_x_tb_empresa_x_seg_usuario_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_Empresa] ([IdEmpresa])
);

