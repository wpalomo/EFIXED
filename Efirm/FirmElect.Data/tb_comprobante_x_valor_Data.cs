using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info;
using System.Data.SqlClient;
using System.Data;
using System.Data.Objects;
using FirmElect.Data;
using FirmElect.Info.class_sri.Factura_V2;
using FirmElect.Info.class_sri.GuiaRemision;
using FirmElect.Info.class_sri.NotaCredito;
using FirmElect.Info.class_sri.NotaDebito;
using FirmElect.Info.class_sri.Retencion;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FirmElect.Data
{
   public class tb_comprobante_x_valor_Data
    {
        public Boolean GrabarDB(tb_comprobante_x_valor_Info Comprobante_info)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {

                    var Address = new tb_comprobante_x_valor();

                    Address.IdEmpresa = Comprobante_info.IdEmpresa;
                    Address.IdComprobante = Comprobante_info.IdComprobante;
                    Address.Total = Comprobante_info.Total;
                    Context.tb_comprobante_x_valor.Add(Address);
                    Context.SaveChanges();
                
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool si_existe_comprobante(tb_comprobante_x_valor_Info Comprobante_info)
        {
            try
            {

                Boolean Existe;
                using (EntitiesFactElectronica conexion = new EntitiesFactElectronica())
                {
                    int consulta = (from q in conexion.tb_comprobante_x_valor
                                    where q.IdEmpresa == Comprobante_info.IdEmpresa
                                    &&q.IdComprobante==Comprobante_info.IdComprobante
                                    select q).Count();

                    if (consulta > 0)
                    {
                        Existe = true;

                    }
                    else
                    {
                        Existe = false;
                    }
                    return Existe;
                }
            }
            catch (Exception ex)
            {

                

                return false;
            }
        }


    }
}
