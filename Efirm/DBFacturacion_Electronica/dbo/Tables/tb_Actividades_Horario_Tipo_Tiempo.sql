CREATE TABLE [dbo].[tb_Actividades_Horario_Tipo_Tiempo] (
    [IdTipoTiempo] VARCHAR (20) NOT NULL,
    [descripcion]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tb_Actividades_Horario_Tipo_Tiempo] PRIMARY KEY CLUSTERED ([IdTipoTiempo] ASC)
);

