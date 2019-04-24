CREATE TABLE [dbo].[tb_Actividades_Horario_Acciones] (
    [IdTransaccion]       VARCHAR (20) NOT NULL,
    [IdAccion]            VARCHAR (20) NOT NULL,
    [Descripcion]         VARCHAR (50) NOT NULL,
    [TiempoEspera]        INT          NOT NULL,
    [Secuencia_ejecucion] INT          NOT NULL,
    CONSTRAINT [PK_tb_Actividades_Horario_Acciones] PRIMARY KEY CLUSTERED ([IdTransaccion] ASC, [IdAccion] ASC),
    CONSTRAINT [FK_tb_Actividades_Horario_Acciones_tb_Actividades_Horario] FOREIGN KEY ([IdTransaccion]) REFERENCES [dbo].[tb_Actividades_Horario] ([IdTransaccion])
);

