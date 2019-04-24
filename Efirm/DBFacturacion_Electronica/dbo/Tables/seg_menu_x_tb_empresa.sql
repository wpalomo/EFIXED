CREATE TABLE [dbo].[seg_menu_x_tb_empresa] (
    [IdEmpresa] INT NOT NULL,
    [IdMenu]    INT NOT NULL,
    [estado]    BIT NOT NULL,
    CONSTRAINT [PK_seg_menu_x_tb_empresa] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdMenu] ASC),
    CONSTRAINT [FK_seg_menu_x_tb_empresa_seg_menu] FOREIGN KEY ([IdMenu]) REFERENCES [dbo].[seg_menu] ([IdMenu]),
    CONSTRAINT [FK_seg_menu_x_tb_empresa_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_Empresa] ([IdEmpresa])
);

