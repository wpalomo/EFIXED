CREATE TABLE [dbo].[tb_Contribuyente] (
    [IdContribuyente]           NUMERIC (18)  NOT NULL,
    [IdEmpresa]                 INT           NOT NULL,
    [cedulaRuc_contri]          VARCHAR (20)  NOT NULL,
    [Nom_Contribuyente]         VARCHAR (250) NOT NULL,
    [Mail]                      VARCHAR (100) NULL,
    [Mail_secundario]           VARCHAR (100) NULL,
    [EsCliente]                 BIT           NOT NULL,
    [EsProveedor]               BIT           NOT NULL,
    [Password]                  VARCHAR (50)  NOT NULL,
    [Estado]                    BIT           NOT NULL,
    [Fecha_transaccion]         DATETIME      NULL,
    [Fecha_Registro_web]        DATETIME      NULL,
    [Fecha_Actualizacion_datos] DATETIME      NULL,
    [Registrado_web]            BIT           NOT NULL,
    [Observacion]               VARCHAR (MAX) NOT NULL,
    [TipoContacto]              VARCHAR (10)  NULL,
    [Foto]                      IMAGE         NULL,
    [Direccion]                 VARCHAR (200) NULL,
    [Telefono]                  VARCHAR (50)  NULL,
    [Mail_secundario2]          VARCHAR (100) NULL,
    [Mail_de_Registro_x_WEB]    VARCHAR (100) NULL,
    CONSTRAINT [PK_tb_Contribuyente] PRIMARY KEY CLUSTERED ([IdContribuyente] ASC)
);






GO


