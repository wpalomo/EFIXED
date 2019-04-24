CREATE TABLE [dbo].[tb_Actividades_Horario] (
    [IdTransaccion]       VARCHAR (20) NOT NULL,
    [IdTipoEjecucion]     VARCHAR (20) NOT NULL,
    [Num_cbtes_x_pagina]  INT          NOT NULL,
    [lunes]               BIT          NOT NULL,
    [martes]              BIT          NOT NULL,
    [miercoles]           BIT          NOT NULL,
    [jueves]              BIT          NOT NULL,
    [viernes]             BIT          NOT NULL,
    [sabado]              BIT          NOT NULL,
    [domingo]             BIT          NOT NULL,
    [ocurre_1_vez]        BIT          NOT NULL,
    [valor_ocurre_1_vez]  TIME (7)     NOT NULL,
    [ocurre_cada]         BIT          NOT NULL,
    [valor_ocurre_cada]   INT          NOT NULL,
    [IdTipoTiempo]        VARCHAR (20) NOT NULL,
    [hora_inicia_a_las]   TIME (7)     NOT NULL,
    [hora_finaliza_a_las] TIME (7)     NOT NULL,
    CONSTRAINT [PK_tb_Actividades_Horario] PRIMARY KEY CLUSTERED ([IdTransaccion] ASC),
    CONSTRAINT [FK_tb_Actividades_Horario_tb_Actividades_Horario_Tipo_Ejecucion] FOREIGN KEY ([IdTipoEjecucion]) REFERENCES [dbo].[tb_Actividades_Horario_Tipo_Ejecucion] ([IdTipoEjecucion]),
    CONSTRAINT [FK_tb_Actividades_Horario_tb_Actividades_Horario_Tipo_Tiempo] FOREIGN KEY ([IdTipoTiempo]) REFERENCES [dbo].[tb_Actividades_Horario_Tipo_Tiempo] ([IdTipoTiempo])
);

