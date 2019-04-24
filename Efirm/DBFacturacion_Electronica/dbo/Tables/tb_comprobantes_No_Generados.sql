CREATE TABLE [dbo].[tb_comprobantes_No_Generados] (
    [id_Comprobante] VARCHAR (30)  NOT NULL,
    [Nom_vista]      VARCHAR (50)  NOT NULL,
    [Mensaje_Error]  VARCHAR (MAX) NOT NULL,
    [Fecha_Carga]    DATETIME      NOT NULL
);

