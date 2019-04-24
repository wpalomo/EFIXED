CREATE TABLE [dbo].[tb_Error_sri] (
    [IdError_Sri]       VARCHAR (25)  NOT NULL,
    [Descripcion_error] VARCHAR (250) NOT NULL,
    [Posible_Causa]     VARCHAR (550) NOT NULL,
    CONSTRAINT [PK_tb_errores_sri] PRIMARY KEY CLUSTERED ([IdError_Sri] ASC)
);

