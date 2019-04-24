using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Data
{
    public class seg_menu_data
    {
        public List<seg_menu_info> get_list()
        {
            try
            {
                List<seg_menu_info> Lista = new List<seg_menu_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.seg_menu
                             select new seg_menu_info
                             {
                                 IdMenu = q.IdMenu,
                                 IdMenu_padre = q.IdMenu_padre,
                                 me_nombre = q.me_nombre,
                                 me_es_menu = q.me_es_menu,
                                 me_nom_formulario = q.me_nom_formulario,
                                 me_nom_assembly = q.me_nom_assembly,
                                 me_nivel = q.me_nivel,
                                 me_estado = q.me_estado
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public int get_id()
        {
            try
            {
                int ID = 1;

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    var lst = from q in Context.seg_menu
                              select q;

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdMenu) + 1;
                }

                return ID;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool guardarDB(seg_menu_info info)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_menu Entity = new seg_menu();
                    Entity.IdMenu = info.IdMenu = get_id();
                    Entity.IdMenu_padre = info.IdMenu_padre;
                    Entity.me_nombre = info.me_nombre;
                    Entity.me_es_menu = info.me_es_menu;
                    Entity.me_nom_formulario = info.me_nom_formulario;
                    Entity.me_nom_assembly = info.me_nom_assembly;
                    Entity.me_nivel = info.me_nivel;
                    Entity.me_estado = info.me_estado = true;
                    Context.seg_menu.Add(Entity);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool modificarDB(seg_menu_info info)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_menu Entity = Context.seg_menu.FirstOrDefault(q => q.IdMenu == info.IdMenu);
                    if (Entity != null)
                    {
                        Entity.IdMenu_padre = info.IdMenu_padre;
                        Entity.me_nombre = info.me_nombre;
                        Entity.me_es_menu = info.me_es_menu;
                        Entity.me_nom_formulario = info.me_nom_formulario;
                        Entity.me_nom_assembly = info.me_nom_assembly;
                        Entity.me_nivel = info.me_nivel;
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

        public bool anularDB(seg_menu_info info)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_menu Entity = Context.seg_menu.FirstOrDefault(q => q.IdMenu == info.IdMenu);
                    if (Entity != null)
                    {
                        Entity.me_estado = false;
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
