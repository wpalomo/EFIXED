

 
CREATE PROCEDURE  [dbo].[sp_Registro_Contribuyente] 
	  @IdEmpresa int  ,
	  @CedulaRuc varchar(13) , 
	  @IdTipoComprobante varchar (2) , 
	  @NumComprobante varchar (20) ,
	  @Correo varchar(100) ,
	  @Contrasenia varchar(100) ,
	  @HashText  varchar(max)  
AS
BEGIN
	
if(@IdTipoComprobante='01')
	begin
		set @NumComprobante = 'FA-'+@NumComprobante;
	end
else if(@IdTipoComprobante='04')
	begin
		set @NumComprobante = 'NC-'+@NumComprobante;
	end
else
if(@IdTipoComprobante='05')
	begin
		set @NumComprobante = 'ND-'+@NumComprobante;
	end
else
if(@IdTipoComprobante='06')
	begin
		set @NumComprobante = 'GUI-'+@NumComprobante;
	end
else
if(@IdTipoComprobante='07')
	begin
		set @NumComprobante = 'RT-'+@NumComprobante;
	end
 
 
 if exists ( select * from tb_Contribuyente where IdEmpresa = @IdEmpresa and cedulaRuc_contri = @CedulaRuc)
	begin
		if exists(select * from tb_Comprobante where Cedula_Ruc =@CedulaRuc and IdTipoDocumento =@IdTipoComprobante and IdComprobante = @NumComprobante)
		begin
			update tb_Contribuyente 
			set Mail_de_Registro_x_Web =  @Correo 
			, Password = @Contrasenia ,  Fecha_Registro_web = GETDATE(), Fecha_Actualizacion_datos = GETDATE()
			where IdEmpresa = @IdEmpresa and cedulaRuc_contri = @CedulaRuc;
			declare @IdContribuyente_ numeric
			select @IdContribuyente_ = IdContribuyente from tb_Contribuyente where cedulaRuc_contri = @CedulaRuc
			
			set @HashText  = master.dbo.fn_varbintohexstr(HashBytes('MD5',@Contrasenia+@Correo+@NumComprobante))
			if exists(select * from tb_Contribuyente_Hash where IdEmpresa = @IdEmpresa and IdContribuyente = @IdContribuyente_)
				begin
					update 	tb_Contribuyente_Hash set hash = @HashText  WHERE IdEmpresa = @IdEmpresa and IdContribuyente = @IdContribuyente_
				end
			else	
				begin
					insert tb_Contribuyente_Hash (IdEmpresa,IdContribuyente,hash)values(@IdEmpresa,@IdContribuyente_,@HashText)
				end
						
				
					update 	tb_Contribuyente_Hash set hash = @HashText  WHERE IdEmpresa = @IdEmpresa and IdContribuyente = @IdContribuyente_
			select 'True' Respuesta , 'Registros ingresados satisfactoriamente, hemos enviado un correo electronico a su cuenta para confirmacion de datos' Mensaje, @HashText HashText ,@IdContribuyente_ as IdContribuyente
		end
		else
			select 'False' Respuesta, 'El contribuyento no posee ningun comprobante' Mensaje
		 		
	end 
else 
	begin 
		select 'False' Respuesta, 'El contribuyente no se encuentra registrado en la base de datos' Mensaje
	end


END



