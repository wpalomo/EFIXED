using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FirmElect.Info;

namespace FirmElect.Data
{
   public class fx_Comprobante_generados_Data
   {

       #region funciones insert comprobantes generados ax
       public void GuardarComprobantes_generados_AX(fx_Comprobante_generados_Info compro, string conexion)
       {
           DateTime fecha; string ff;
           fecha = Convert.ToDateTime(compro.FECHA_CARGA);

           ff = fecha.ToString("yyyy-MM-dd");
           try
           {
               string sql = "insert Into TB_EFIRM_LOAD_CARGA(ID_REGISTRO,FECHA_CARGA,ESTADO)values('" + compro.IdRegistro + "','" + ff + "','" + compro.Estado + "')";
               SqlConnection cone = new SqlConnection(conexion);
               cone.Open();
               SqlCommand cmd = new SqlCommand(sql, cone);
               SqlDataReader reader = cmd.ExecuteReader();
               reader.Close();
               cone.Close();
           }
           catch (Exception ex)
           {
           }
       }
       public List<fx_Comprobante_generados_Info> Listacomprobantes_generados_AX(string conexion)
       {
           try
           {
               List<fx_Comprobante_generados_Info> lista = new List<fx_Comprobante_generados_Info>();
               fx_Comprobante_generados_Info comprobamte = null;
               string sql = "select * from  TB_EFIRM_LOAD_CARGA";
               SqlConnection cn = new SqlConnection(conexion);
               cn.Open();
               SqlCommand cmd = new SqlCommand(sql, cn);
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                   comprobamte = new fx_Comprobante_generados_Info();
                   comprobamte.IdRegistro = reader.GetString(0);
                   comprobamte.FECHA_CARGA = reader.GetDateTime(1);
                   comprobamte.Estado = reader.GetString(2);
                   comprobamte.Checked = true;
                   lista.Add(comprobamte);
               }
               reader.Close();
               cn.Close();
               return lista;
           }
           catch (Exception ex)
           {
               return new List<fx_Comprobante_generados_Info>();
           }
       }
       public bool Eliminar_Comprobantes_Generados_AX(fx_Comprobante_generados_Info info, string Conexion)
       {
           try
           {
               using (SqlConnection ConexionEfirm = new SqlConnection(Conexion))
               {
                   ConexionEfirm.Open();


                   string SQL = " delete TB_EFIRM_LOAD_CARGA where ID_REGISTRO  ='" + info.IdRegistro + "'";
                   SqlCommand cmd = new SqlCommand(SQL, ConexionEfirm);
                   SqlDataReader reader = cmd.ExecuteReader();
                   reader.Close();


                   return true;
               }


           }
           catch (Exception)
           {

               return false;
           }
       }

       #endregion



       #region funciones insert comprobantes generados fixed
       public void GuardarComprobantes_generados_FX(fx_Comprobante_generados_Info info)
       {
          
           try
           {
               using (Entity_conexion_efixed Context=new Entity_conexion_efixed())
               {
                   fa_elec_registros_generados entity = new fa_elec_registros_generados();
                   entity.ID_REGISTRO = info.IdRegistro;
                   entity.FECHA_CARGA = info.FECHA_CARGA = DateTime.Now;
                   entity.ESTADO = "A";
                   Context.fa_elec_registros_generados.Add(entity);
                   Context.SaveChanges();
               }
           }
           catch (Exception ex)
           {
           }
       }
       public List<fx_Comprobante_generados_Info> Listacomprobantes_generados_FX()
       {
           try
           {
               List<fx_Comprobante_generados_Info> lista = new List<fx_Comprobante_generados_Info>();
               using (Entity_conexion_efixed Context=new Entity_conexion_efixed())
               {
                   lista = (from q in Context.fa_elec_registros_generados
                        
                        select new fx_Comprobante_generados_Info
                        {
                            IdRegistro = q.ID_REGISTRO,
                            FECHA_CARGA = q.FECHA_CARGA,
                            Estado = q.ESTADO,
                            Checked=true
                        }).ToList();
               }
               return lista;
           }
           catch (Exception )
           {
               return new List<fx_Comprobante_generados_Info>();
           }
       }
       public bool Eliminar_Comprobantes_Generados_FX(fx_Comprobante_generados_Info info)
       {
           try
           {
               using (Entity_conexion_efixed Context = new Entity_conexion_efixed())
               {
                   fa_elec_registros_generados Entity = Context.fa_elec_registros_generados.FirstOrDefault(q => q.ID_REGISTRO == info.IdRegistro );
                   Context.fa_elec_registros_generados.Remove(Entity);
                   Context.SaveChanges();
                   return true;
               }


           }
           catch (Exception)
           {

               return false;
           }
       }

       #endregion


   }
}
