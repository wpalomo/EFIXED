using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailEfirm.Data;
using MailEfirm.Info;

    public  class Contribuyente_Bus
    {

        
       Cotribuyente_Data Odata;

       public Contribuyente_Bus()
       {
           Odata = new Cotribuyente_Data();

       }

       public List<Contribuyente_Info> consultar()
       {
           try
           {
               return Odata.CargarContribuyente();
           }
           catch (Exception ex)
           {

               return new List<Contribuyente_Info>();
           }
       }

       public bool ModificarDB(Contribuyente_Info contribuyente, ref string mensajeErrorOut)
       {
           try
           {
               return Odata.ModificarDB(contribuyente, ref mensajeErrorOut);
           }
           catch (Exception ex)
           {
               return false;
               
           }
       }
    }

