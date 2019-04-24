CREATE TABLE [dbo].[tb_Parametro] (
    [IdParametro]                         INT           NOT NULL,
    [url_ws_sri_Recep_cbte_Prueba]        VARCHAR (150) NULL,
    [url_ws_sri_Recep_cbte_Produc]        VARCHAR (150) NULL,
    [url_ws_sri_Autorizacion_cbte_Prueba] VARCHAR (150) NULL,
    [url_ws_sri_Autorizacion_cbte_Produc] VARCHAR (150) NULL,
    [url_ws_firma_efirm]                  VARCHAR (150) NULL,
    [Usa_Proxy]                           BIT           NULL,
    [Url_Proxy]                           VARCHAR (150) NULL,
    [Port_Proxy]                          INT           NULL,
    [Usuario_Proxy]                       VARCHAR (150) NULL,
    [Password_Proxy]                      VARCHAR (150) NULL,
    [Registra_Log]                        BIT           NULL,
    [Version]                             NUMERIC (18)  NULL,
    [offline_online]                      INT           NULL,
    CONSTRAINT [PK_tb_Parametro] PRIMARY KEY CLUSTERED ([IdParametro] ASC)
);



