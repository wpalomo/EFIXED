CREATE TABLE [dbo].[tb_Actividades_Horario_EloadEfirm] (
    [id_horario]                 INT          NOT NULL,
    [lunes]                      BIT          NOT NULL,
    [martes]                     BIT          NOT NULL,
    [miercoles]                  BIT          NOT NULL,
    [jueves]                     BIT          NOT NULL,
    [viernes]                    BIT          NOT NULL,
    [sabado]                     BIT          NOT NULL,
    [domingo]                    BIT          NOT NULL,
    [ocurre_1_vez]               BIT          NOT NULL,
    [valor_ocurre_1_vez]         TIME (7)     NOT NULL,
    [ocurra_cada]                BIT          NOT NULL,
    [valor_ocurre_cada]          INT          NOT NULL,
    [hora_inicia_a_las]          TIME (7)     NOT NULL,
    [hora_finaliza_a_las]        TIME (7)     NOT NULL,
    [tipo_ejecucion]             VARCHAR (12) NOT NULL,
    [tipo_frecuencia_ocurrencia] VARCHAR (12) NOT NULL,
    [DiasRestaFecha]             INT          NULL
);

