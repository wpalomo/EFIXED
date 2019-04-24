CREATE TABLE [dbo].[tb_Actividades_Horario_Tipo_Ejecucion] (
    [IdTipoEjecucion] VARCHAR (20) NOT NULL,
    [Descripcion]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tb_Actividades_Horario_Tipo_Ejecucion] PRIMARY KEY CLUSTERED ([IdTipoEjecucion] ASC)
);

