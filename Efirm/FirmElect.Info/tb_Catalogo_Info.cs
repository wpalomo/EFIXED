using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;

namespace FirmElect.Info
{
  [DataContract]
    public class tb_Catalogo_Info
    {
        [DataMember] 
        public string IdCatalogo { get; set; }
        [DataMember]
        public int IdTIpoCatalogo { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }

        
       public  tb_Catalogo_Info(){}
    }
}
