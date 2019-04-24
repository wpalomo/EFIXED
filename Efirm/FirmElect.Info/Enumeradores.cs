public enum eTipo_action
{
    grabar = 1,
    actualizar = 2,
    borrar = 3,
    consultar = 4
}




public enum eTipo_emision
{
    ONLINE = 1,
    OFFLINE = 2
}


public enum eTipoExportacion
{
    EXPORTADOS,
    X_EXPORTAR
}





public enum eIdEstadoProceso
{
    /// <summary>
    /// PROCESADO
    /// </summary>
    PROCE=1,
    /// <summary>
    /// PENDIENTE
    /// </summary>
    PEND=2
}

public enum eTipoToquen
{
    /// <summary>
    /// SD - BioPass3000
    /// </summary>
    SDBIOPASS3,
    /// <summary>
    /// SD - ePass3003 auto
    /// </summary>
    SDEPAS3003,
    /// <summary>
    /// BCE - Aladdin e Token Pro
    /// </summary>
    BCEALAETPR,
    /// <summary>
    /// BCE - IKey2032
    /// </summary>
    BCEIKEY203,
    /// <summary>
    /// ANF - Certificado Exportado
    /// </summary>
    ANFCERTEXP,
    /// <summary>
    /// ANF - Plug & Sign 
    /// </summary>
    ANFPLUSIG
}


public enum eTipoEjecucion
{ 
Automatica=1,
Manual=1
}


public enum eTipo_Tiempo
{
    SEG,
    MIN,
    HOR
}




public enum eTipoError
{ 
ERROR,
WARNING,
INFO,
ERROR_VALIDACION,
ERROR_TRY,
LOG
}

public enum eTipoRespuesta
{ 
OK,
ERROR
}

public enum eAcciones
{ 
    Nuevo ,
    Modificar ,
    Consultar ,
    Eliminar ,
}


public enum eTipoDirectorio
{
    CBTE_VALID
    , CERTI
    , REPO
    ,ROOT
    ,CBTES_CON_ERROR
}


public enum eCod_Empresa_efirm
{ 
    Dacar,
    Fundamentz,
    ExpoGye,
    Toyocosta,


}

public enum eTipo_Conexion_seguridad_SMTP
{ 
Ninguno,
SSL,
TLS
}



public enum eTipo_Perfil_Usuario
{
    SERVER,
    CLIENTE
}

public enum eTipoEnvioMail
{
    RENVIO,
    NUEVO
}


public enum eCliente
{
    
    EXPOGYE = 1,
   
    FIXED = 6
}

public enum eTipoFactura
{
    FactrasServicios,
    FacturaManuales,
    FacturaRespuesto,
    FacturaVehiculo,
}

public enum eTipoTabla
{
    Cabecera,
    Totales,
    Detalles
}
public enum eTipoNotaCredito
{
    NotaCreditoManual,
    NotaCreditoRespuesto,
    NotaCreditoTaller,
    NotaCreditoVehiculo,
}

public enum eTipoComprobante
{
    Factura,
    NotaCred,
    NotaDeb,
    Guia,
    Retencion,
    FacturaRembolso
}


public enum eTipoCodComprobante
{
    FAC,
    NTC,
    NTD,
    GUI,
    RET,
    FACR
}

public enum eTipoMensaje
{
    ERROR,
    WARNING,
    LOG,
    INFO
}


public enum eTipoAccion
{
    NUEVO,
    MODIFICAR,
    CONSULTAR,
    ANULAR
}

