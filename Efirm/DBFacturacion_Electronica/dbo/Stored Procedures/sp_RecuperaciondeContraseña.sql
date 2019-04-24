
--  exec [sp_RecuperaciondeContraseña] 1,'1790010937001'
 
CREATE PROCEDURE [dbo].[sp_RecuperaciondeContraseña] 
	@IdEmpresa int ,
	@cedulaRuc varchar(40)
AS
BEGIN
	 
	
	declare @HashText  varchar(max) = master.dbo.fn_varbintohexstr(HashBytes('MD5',Cast(@IdEmpresa as varchar(10))+@cedulaRuc))
	declare @IdContribuyente_ Numeric(18,0)
	declare @correo_contribuyente varchar(50)



	if exists( select * from tb_Contribuyente where IdEmpresa = @IdEmpresa and cedulaRuc_contri= @cedulaRuc)
	begin
	select @IdContribuyente_ = A.IdContribuyente
	,@correo_contribuyente =A.Mail_de_Registro_x_WEB
	from tb_Contribuyente A
	where A.IdEmpresa = @IdEmpresa 
	and A.cedulaRuc_contri= @cedulaRuc

		if exists(select * from tb_Contribuyente_Hash where IdEmpresa = @IdEmpresa and IdContribuyente = @IdContribuyente_)
			begin
				
				print 'actualizar'
				update 	tb_Contribuyente_Hash set hash = @HashText  WHERE IdEmpresa = @IdEmpresa and IdContribuyente = @IdContribuyente_
			end
		else	
			begin
				 
				insert tb_Contribuyente_Hash (IdEmpresa,IdContribuyente,hash)values(@IdEmpresa,@IdContribuyente_,@HashText)
				print 'insertar'
			end
		select 'True' Respuesta, 'Hemos enviado un correo con detalles para recuperación de la contrasña' Mensaje, @HashText	HashText,@correo_contribuyente as CorreoContribuyente,@IdContribuyente_ as IdContribuyente
	end
	else
	begin
		select 'False' Respuesta, 'El contribuyento no existe en la base de datos' Mensaje
	end
		 
END



