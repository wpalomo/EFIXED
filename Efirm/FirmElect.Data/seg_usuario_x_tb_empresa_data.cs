using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Data
{
    public class seg_usuario_x_tb_empresa_data
    {
        public List<seg_usuario_x_tb_empresa_info> get_list(string IdUsuario)
        {
            try
            {
                List<seg_usuario_x_tb_empresa_info> Lista = new List<seg_usuario_x_tb_empresa_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.vwseg_usuario_x_tb_empresa
                             where q.IdUsuario == IdUsuario
                             select new seg_usuario_x_tb_empresa_info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdUsuario  =  q.IdUsuario,
                                 em_razon_social = q.RazonSocial,
                                 seleccionado = true
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public List<seg_usuario_x_tb_empresa_info> get_list(int IdEmpresa)
        {
            try
            {
                List<seg_usuario_x_tb_empresa_info> Lista = new List<seg_usuario_x_tb_empresa_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.vwseg_usuario_x_tb_empresa
                             where q.IdEmpresa == IdEmpresa
                             select new seg_usuario_x_tb_empresa_info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdUsuario = q.IdUsuario,
                                 em_razon_social = q.RazonSocial,
                                 seleccionado = true,
                                 
                                 info_usuario = new seg_usuario_info{
                                     IdUsuario = q.IdUsuario,
                                     us_nombre = q.us_nombre
                                 }
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool guardarDB(List<seg_usuario_x_tb_empresa_info> Lista)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    foreach (var item in Lista)
                    {
                        seg_usuario_x_tb_empresa Entity = new seg_usuario_x_tb_empresa();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdUsuario = item.IdUsuario;
                        Context.seg_usuario_x_tb_empresa.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool eliminarDB(string IdUsuario)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Context.Database.ExecuteSqlCommand("DELETE seg_usuario_x_tbl_empresa WHERE IdUsuario = '"+IdUsuario+"'");
                }

                return true;
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
