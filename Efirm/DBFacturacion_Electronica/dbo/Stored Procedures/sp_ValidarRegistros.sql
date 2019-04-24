
 
CREATE PROCEDURE [dbo].[sp_ValidarRegistros]
	@IdEmpresa int,
	@HashText varchar(max) 
AS
BEGIN
	IF EXISTS ( SELECT * FROM tb_Contribuyente_Hash WHERE IdEmpresa =@IdEmpresa AND HASH = @HashText)
	BEGIN 
		DECLARE @IdContribuyente numeric(18,0)
		SELECT @IdContribuyente=  IdContribuyente FROM tb_Contribuyente_Hash WHERE IdEmpresa =@IdEmpresa AND HASH = @HashText
		UPDATE tb_Contribuyente SET Registrado_web = 1 where IdEmpresa = @IdEmpresa  and IdContribuyente  = @IdContribuyente
		SELECT 'True' Respuesta, 'Registros Actualizados Correctamente' Mensaje
	END
	
ELSE
	BEGIN
		SELECT 'False', 'ERROR al validar usuario' Mensaje
	END
	 
 
END

