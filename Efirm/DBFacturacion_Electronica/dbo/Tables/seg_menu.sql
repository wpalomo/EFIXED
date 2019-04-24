CREATE TABLE [dbo].[seg_menu] (
    [IdMenu]            INT           NOT NULL,
    [IdMenu_padre]      INT           NULL,
    [me_nombre]         VARCHAR (100) NOT NULL,
    [me_es_menu]        BIT           NOT NULL,
    [me_nom_formulario] VARCHAR (250) NULL,
    [me_nom_assembly]   VARCHAR (250) NULL,
    [me_nivel]          INT           NOT NULL,
    [me_estado]         BIT           NOT NULL,
    CONSTRAINT [PK_seg_menu] PRIMARY KEY CLUSTERED ([IdMenu] ASC),
    CONSTRAINT [FK_seg_menu_seg_menu] FOREIGN KEY ([IdMenu_padre]) REFERENCES [dbo].[seg_menu] ([IdMenu])
);

