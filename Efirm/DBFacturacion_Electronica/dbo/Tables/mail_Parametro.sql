CREATE TABLE [dbo].[mail_Parametro] (
    [IdParametro]              VARCHAR (50) NOT NULL,
    [valor_min_envi_recep_aut] INT          NOT NULL,
    [envio_recep_aut_salir]    BIT          NOT NULL,
    [enviar_solo_pdf_ride]     BIT          NULL,
    [enviar_solo_xml_ride]     BIT          NULL,
    CONSTRAINT [PK_mail_parametro] PRIMARY KEY CLUSTERED ([IdParametro] ASC)
);

