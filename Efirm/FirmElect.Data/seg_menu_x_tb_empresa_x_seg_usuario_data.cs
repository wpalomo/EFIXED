using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Data
{
    public class seg_menu_x_tb_empresa_x_seg_usuario_data
    {
        public List<seg_menu_x_tb_empresa_x_seg_usuario_info> get_list(int IdEmpresa, string IdUsuario)
        {
            try
            {
                List<seg_menu_x_tb_empresa_x_seg_usuario_info> Lista = new List<seg_menu_x_tb_empresa_x_seg_usuario_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.vwseg_menu_x_tb_empresa_x_seg_usuario
                             join m in Context.seg_menu
                             on q.IdMenu equals m.IdMenu
                             where q.IdEmpresa == IdEmpresa
                             && q.IdUsuario == IdUsuario
                             select new seg_menu_x_tb_empresa_x_seg_usuario_info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdMenu = q.IdMenu,
                                 IdUsuario = q.IdUsuario,
                                 nuevo = q.nuevo,
                                 modificar = q.modificar,
                                 consultar = q.consultar,
                                 anular = q.anular,
                                 seleccionado = true,

                                 info_menu = new seg_menu_info
                                 {
                                     me_es_menu = m.me_es_menu,
                                     me_nom_assembly = m.me_nom_assembly,
                                     me_nom_formulario = m.me_nom_formulario,
                                     me_nivel = m.me_nivel,
                                     IdMenu = m.IdMenu,
                                     me_nombre = m.me_nombre,
                                     IdMenu_padre = m.IdMenu_padre
                                 }
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception e)
            {                
                throw;
            }
        }

        public List<seg_menu_x_tb_empresa_x_seg_usuario_info> get_no_list(int IdEmpresa, string IdUsuario)
        {
            try
            {
                List<seg_menu_x_tb_empresa_x_seg_usuario_info> Lista = new List<seg_menu_x_tb_empresa_x_seg_usuario_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.seg_menu
                             where !(from f in Context.vwseg_menu_x_tb_empresa_x_seg_usuario
                                     where f.IdEmpresa == IdEmpresa
                                     && f.IdUsuario == IdUsuario
                                     select f.IdMenu).Contains(q.IdMenu)
                             select new seg_menu_x_tb_empresa_x_seg_usuario_info
                             {
                                 IdEmpresa = IdEmpresa,
                                 IdMenu = q.IdMenu,
                                 IdUsuario = IdUsuario,
                                 nuevo = false,
                                 modificar = false,
                                 consultar = false,
                                 anular = false,
                                 seleccionado = false,

                                 info_menu = new seg_menu_info
                                 {
                                     me_es_menu = q.me_es_menu,
                                     me_nom_assembly = q.me_nom_assembly,
                                     me_nom_formulario = q.me_nom_formulario,
                                     me_nivel = q.me_nivel,
                                     IdMenu = q.IdMenu,
                                     me_nombre = q.me_nombre,
                                     IdMenu_padre = q.IdMenu_padre
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

        public bool eliminarDB(int IdEmpresa, string IdUsuario)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Context.Database.ExecuteSqlCommand("DELETE seg_menu_x_tb_empresa_x_seg_usuario WHERE IdEmpresa = " + IdEmpresa+" and IdUsuario = '"+IdUsuario+"'");
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool guardarDB(List<seg_menu_x_tb_empresa_x_seg_usuario_info> Lista)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    foreach (var item in Lista)
                    {
                        seg_menu_x_tb_empresa_x_seg_usuario Entity = new seg_menu_x_tb_empresa_x_seg_usuario();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdMenu = item.IdMenu;
                        Entity.IdUsuario = item.IdUsuario;
                        Entity.nuevo = item.nuevo;
                        Entity.modificar = item.modificar;
                        Entity.consultar = item.consultar;
                        Entity.anular = item.anular;
                        Context.seg_menu_x_tb_empresa_x_seg_usuario.Add(Entity);
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
    }
}
