using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FirmElect.Info;

namespace FirmElect.Data
{
   public class fx_GeneradorXML_Comprobantes_No_Generados_Data: fx_GeneradorXML_IComprobantes_No_Generados_Data
    {
       public void Guardar_Comprobantes_Generaron_Error_Carga(fx_GeneradorXML_Comprobantes_No_Generados_Info compNoGenerados_info, string conexio)
        {
            try
            {
                using (SqlConnection ConexionEfirm = new SqlConnection(conexio))
                {
                    ConexionEfirm.Open();
                    string SQL = " insert into tb_comprobantes_No_Generados(id_Comprobante,Nom_vista,Mensaje_Error,Fecha_Carga)" +
                        "Values('" + compNoGenerados_info.id_Comprobante + "','" + compNoGenerados_info.Nom_vista + "','" + compNoGenerados_info.Mensaje_Error + "','" + compNoGenerados_info.Fecha_Carga + "')";
                    SqlCommand cmd = new SqlCommand(SQL, ConexionEfirm);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

       public List<fx_GeneradorXML_Comprobantes_No_Generados_Info> Listados_ComprobantesNo_Generados(string conexio)
        {
            fx_GeneradorXML_Comprobantes_No_Generados_Info compronatenoGenerado = null;
            List<fx_GeneradorXML_Comprobantes_No_Generados_Info> lista = new List<fx_GeneradorXML_Comprobantes_No_Generados_Info>();
            try
            {
                using (SqlConnection ConexionEfirm = new SqlConnection(conexio))
                {
                    ConexionEfirm.Open();
                    string SQL = " select * from tb_comprobantes_No_Generados";
                    SqlCommand cmd = new SqlCommand(SQL, ConexionEfirm);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        compronatenoGenerado = new fx_GeneradorXML_Comprobantes_No_Generados_Info();
                        compronatenoGenerado.id_Comprobante = reader.GetString(0);
                        compronatenoGenerado.Nom_vista = reader.GetString(1);
                        compronatenoGenerado.Mensaje_Error = reader.GetString(2);
                        compronatenoGenerado.Fecha_Carga = reader.GetDateTime(3);
                        lista.Add(compronatenoGenerado);
                    }
                    return lista;
                }


            }
            catch (Exception ex)
            {

                return new List<fx_GeneradorXML_Comprobantes_No_Generados_Info>();
            }

        }

       public bool Eliminar_ComprobantesNo_Generados(List<fx_GeneradorXML_Comprobantes_No_Generados_Info> lista_comp, string conexio)
        {
            try
            {
                using (SqlConnection ConexionEfirm = new SqlConnection(conexio))
                {
                    ConexionEfirm.Open();

                    foreach (var item in lista_comp)
                    {
                        string SQL = " delete tb_comprobantes_No_Generados where id_Comprobante ='" + item.id_Comprobante + "'";
                        SqlCommand cmd = new SqlCommand(SQL, ConexionEfirm);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Close();

                    }

                    return true;
                }


            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
