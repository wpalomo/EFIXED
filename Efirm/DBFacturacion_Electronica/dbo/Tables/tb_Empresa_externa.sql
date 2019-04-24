CREATE TABLE [dbo].[tb_Empresa_externa] (
    [Cod_Empresa_exte] VARCHAR (5)   NOT NULL,
    [nom_empresa_ext]  VARCHAR (150) NULL,
    CONSTRAINT [PK_tb_empresa_externa] PRIMARY KEY CLUSTERED ([Cod_Empresa_exte] ASC)
);

