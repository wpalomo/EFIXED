
/*
exec Paging_test 
 @Tamanio_Pagina =20
,@Indice_Pagina =13
,@PageCount =0
,@CedulaRuc =null
,@TipoComprobante =null

*/

CREATE PROCEDURE [dbo].[sp_consulta_x_cbtes_x_paginas]
 @IdEmpresa int
,@Tamanio_Pagina INT                --Tamaño página
,@Indice_Pagina INT              --Número de página
--,@PageCount INT OUT           --Retorno de cantidad de páginas
,@CedulaRuc NVARCHAR(30) = NULL       --Filtro por campo CedulaRuc
,@TipoComprobante NVARCHAR(5) = NULL         --Filtro por campo Size
,@String_a_buscar varchar(150)=null
,@FecIni datetime
,@FecFin datetime
AS


       


BEGIN
    --Validación de precondiciones
    --SET @PageCount = 0
    IF @Tamanio_Pagina < 1  OR @Indice_Pagina < 1 RETURN
    --Ajuste de cantidad de páginas
    DECLARE @Contador_Registros INT
    
    SELECT
        @Contador_Registros = COUNT(*)
    FROM
        vwSerWeb_Comprobante A
    WHERE  
        (@CedulaRuc IS NULL OR A.Cedula_Ruc =@CedulaRuc or A.Cedula_Ruc=@String_a_buscar) 
        AND (@TipoComprobante IS NULL OR @TipoComprobante = '00' OR A.IdTipoDocumento =@TipoComprobante or A.IdTipoDocumento=@String_a_buscar)
        and a.Fecha_Emi_Fact between @FecIni and @FecFin
        and A.IdEmpresa=@IdEmpresa
        


    --IF @Contador_Registros = 0
    --    SET @PageCount = 0
    --ELSE IF @Contador_Registros % @Tamanio_Pagina = 0

    --    SET @PageCount = @Contador_Registros / @Tamanio_Pagina

    --ELSE

    --    SET @PageCount = (@Contador_Registros / @Tamanio_Pagina) + 1

                         

    --Registros paginados,filtrados y ordenados

    --DECLARE @offset INT =  (@Tamanio_Pagina * (@Indice_Pagina - 1))

        
    select * from
    (
		select A.IdEmpresa   ,A.IdComprobante ,A.IdTipoDocumento ,A.IdEstado_cbte	,A.Cedula_Ruc
		,A.Numero_Autorizacion,A.s_XML,A.Fecha_Emi_Fact,A.Nombre_file,A.nom_Tipo_doc                                                                                         
		,A.ClaveContingencia   ,A.FechaAutorizacion       ,A.Total                  ,A.IdContribuyente                         
		,A.Nom_Contribuyente
		,ROW_NUMBER() over (order by A.idempresa,A.Fecha_Emi_Fact desc ) NumFila, @Contador_Registros as TotalRegistros
		FROM
		vwSerWeb_Comprobante A
		WHERE
		(@CedulaRuc IS NULL OR A.Cedula_Ruc =@CedulaRuc)
		AND (@TipoComprobante IS NULL OR @TipoComprobante = '00' OR A.IdTipoDocumento =@TipoComprobante )
		and a.Fecha_Emi_Fact between @FecIni and @FecFin
        and A.IdEmpresa=@IdEmpresa
        
		) A
     where A.NumFila between @Indice_Pagina and (@Tamanio_Pagina+@Indice_Pagina-1)
		
        

    
    
    
END

