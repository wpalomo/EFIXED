using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class tb_Parametro_Info
    {

        public int IdParametro { get; set; }
        public string url_ws_sri_Recep_cbte_Prueba { get; set; }
        public string url_ws_sri_Recep_cbte_Produc { get; set; }
        public string url_ws_sri_Autorizacion_cbte_Prueba { get; set; }
        public string url_ws_sri_Autorizacion_cbte_Produc { get; set; }
        public string url_ws_firma_efirm { get; set; }

        public bool ? Usa_Proxy { get; set; }
        public string Url_Proxy { get; set; }
        public int ? Port_Proxy { get; set; }
        public string Usuario_Proxy { get; set; }
        public string Password_Proxy { get; set; }

        public bool ? Registra_Log { get; set; }
        public decimal? Version { get; set; }


        public Nullable<int> offline_online { get; set; }

       




    }
}
