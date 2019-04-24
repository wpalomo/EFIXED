using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using FirmElect.Data;

namespace FirmElect.Bus
{
    public class mail_Catalogo_Bus
    {
        mail_Catalogo_Data mailData;

        public mail_Catalogo_Bus()
        {
            mailData = new mail_Catalogo_Data();
        }

        public List<mail_Catalogo_Info> consultarCatalogo(string estado, string tipoCatalogo, ref string mensajeErrorOut)
        {
            try
            {
                return mailData.consultarCatalogo(estado, tipoCatalogo, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<mail_Catalogo_Info>();
            }
        }

    }
}
