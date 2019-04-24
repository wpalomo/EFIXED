
 
CREATE PROCEDURE  [dbo].[sp_VerificarRecuperaciondeContrasenia]
	@IdEmpresa int ,
	@HashText varchar(max) 

AS
BEGIN
	
	
declare @IdContribuyente numeric(18,0)
if exists(select * from tb_Contribuyente_Hash where IdEmpresa = @IdEmpresa and hash = @HashText)
begin 
	select @IdContribuyente = IdContribuyente from tb_Contribuyente_Hash where IdEmpresa = @IdEmpresa and hash = @HashText
	select [IdContribuyente],[IdEmpresa],[cedulaRuc_contri],[Nom_Contribuyente],[Mail],[Mail_secundario]
			,[EsCliente],[EsProveedor],[Password],[Estado],[Fecha_transaccion],[Fecha_Registro_web],[Fecha_Actualizacion_datos]
			,[Registrado_web],[Observacion],TipoContacto TipoContacto_,[Foto],[Direccion],[Telefono],[Mail_secundario2]
			,[Mail_de_Registro_x_WEB] 
			from tb_Contribuyente where IdEmpresa = @IdEmpresa and IdContribuyente=@IdContribuyente 
end

END

