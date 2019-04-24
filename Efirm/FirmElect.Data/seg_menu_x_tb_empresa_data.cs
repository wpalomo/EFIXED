using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Data
{
    public class seg_menu_x_tb_empresa_data
    {
        public List<seg_menu_x_tb_empresa_info> get_list(int IdEmpresa)
        {
            try
            {
                List<seg_menu_x_tb_empresa_info> Lista = new List<seg_menu_x_tb_empresa_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.seg_menu_x_tb_empresa
                             join f in Context.seg_menu
                             on q.IdMenu equals f.IdMenu
                             where q.IdEmpresa == IdEmpresa
                             select new seg_menu_x_tb_empresa_info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdMenu = q.IdMenu,
                                 estado = q.estado,
                                 seleccionado = true,

                                 info_menu = new seg_menu_info
                                 {
                                     IdMenu = f.IdMenu,
                                     IdMenu_padre = f.IdMenu_padre,
                                     me_nom_formulario = f.me_nom_formulario,
                                     me_es_menu = f.me_es_menu,
                                     me_estado = f.me_estado,
                                     me_nivel = f.me_nivel,
                                     me_nom_assembly = f.me_nom_assembly,
                                     me_nombre = f.me_nombre
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

        public List<seg_menu_x_tb_empresa_info> get_no_list(int IdEmpresa)
        {
            try
            {
                List<seg_menu_x_tb_empresa_info> Lista = new List<seg_menu_x_tb_empresa_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.seg_menu
                             where !(from f in Context.seg_menu_x_tb_empresa
                                         where f.IdEmpresa == IdEmpresa
                                         select f.IdMenu).Contains(q.IdMenu)
                             select new seg_menu_x_tb_empresa_info
                             {
                                 IdEmpresa = IdEmpresa,
                                 IdMenu = q.IdMenu,
                                 estado = false,
                                 seleccionado = false,

                                 info_menu = new seg_menu_info
                                 {
                                     IdMenu = q.IdMenu,
                                     IdMenu_padre = q.IdMenu_padre,
                                     me_nom_formulario = q.me_nom_formulario,
                                     me_es_menu = q.me_es_menu,
                                     me_estado = q.me_estado,
                                     me_nivel = q.me_nivel,
                                     me_nom_assembly = q.me_nom_assembly,
                                     me_nombre = q.me_nombre
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

        public bool eliminarDB(int IdEmpresa)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Context.Database.ExecuteSqlCommand("DELETE seg_menu_x_tb_empresa WHERE IdEmpresa = " + IdEmpresa);
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool guardarDB(List<seg_menu_x_tb_empresa_info> Lista)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    foreach (var item in Lista)
                    {
                        seg_menu_x_tb_empresa Entity = new seg_menu_x_tb_empresa();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdMenu = item.IdMenu;
                        Entity.estado = true;
                        Context.seg_menu_x_tb_empresa.Add(Entity);
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
