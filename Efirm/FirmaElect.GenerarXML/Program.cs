using FirmElect.Bus;
using FirmElect.Info;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;
namespace FirmaElect.GenerarXML
{
    static class Program
    {


        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);


            //prueba pru = new prueba();
            //pru.CargarDatos();
            //pru.GenerarArchivosXml();




        }







    }
}
