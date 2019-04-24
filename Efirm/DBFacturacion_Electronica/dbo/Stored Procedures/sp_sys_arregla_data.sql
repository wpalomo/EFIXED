
CREATE PROCEDURE [dbo].[sp_sys_arregla_data]
AS
UPDATE tb_comprobante 
SET s_XML=REPLACE(s_XML,'PRODUCCIÓN','PRODUCCION')
where CHARINDEX('PRODUCCIÓN',s_XML,0)>0

update tb_comprobante
set Ambiente='PRODUCCION'
where Ambiente='PRODUCCIÓN'



