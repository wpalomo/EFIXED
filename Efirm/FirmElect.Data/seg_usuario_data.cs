using FirmElect.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Data
{
    public class seg_usuario_data
    {
        public List<seg_usuario_info> get_list()
        {
            try
            {
                List<seg_usuario_info> Lista = new List<seg_usuario_info>();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    Lista = (from q in Context.seg_usuario
                            select new seg_usuario_info
                            {
                                IdUsuario = q.IdUsuario,
                                us_contrasenia = q.us_contrasenia,
                                us_nombre = q.us_nombre,
                                estado = q.estado
                            }).ToList();
                }

                return Lista;

            }
            catch (Exception)
            {                
                throw;
            }
        }

        public seg_usuario_info get_info(string IdUsuario, string us_contrasenia)
        {
            try
            {
                seg_usuario_info info = new seg_usuario_info();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_usuario Entity = Context.seg_usuario.FirstOrDefault(q => q.IdUsuario == IdUsuario && q.us_contrasenia == us_contrasenia);
                    if (Entity != null)
                    {
                        info.IdUsuario = Entity.IdUsuario;
                        info.us_contrasenia = Entity.us_contrasenia;
                        info.us_nombre = Entity.us_nombre;
                        info.estado = Entity.estado;
                    }
                }

                return info;

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public seg_usuario_info get_info(string IdUsuario)
        
        {
            try
            {
                
                seg_usuario_info info = new seg_usuario_info();

                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_usuario Entity = Context.seg_usuario.FirstOrDefault(q => q.IdUsuario == IdUsuario);
                    if (Entity != null)
                    {
                        info.IdUsuario = Entity.IdUsuario;
                        info.us_contrasenia = Entity.us_contrasenia;
                        info.us_nombre = Entity.us_nombre;
                        info.estado = Entity.estado;
                    }
                }

                return info;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool guardarDB(seg_usuario_info info, ref string mensaje)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    var lst = from q in Context.seg_usuario
                              where q.IdUsuario == info.IdUsuario
                              select q;

                    if (lst.Count() == 0)
                    {
                        seg_usuario Entity = new seg_usuario();
                        Entity.IdUsuario = info.IdUsuario;
                        Entity.us_contrasenia = info.us_contrasenia;
                        Entity.us_nombre = info.us_nombre;
                        Entity.estado = info.estado = true;
                        Context.seg_usuario.Add(Entity);
                        Context.SaveChanges();
                    }
                    else
                    {
                        mensaje = "Usuario ya existe";
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool modificarDB(seg_usuario_info info)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_usuario Entity = Context.seg_usuario.FirstOrDefault(q => q.IdUsuario == info.IdUsuario && q.us_contrasenia == info.us_contrasenia);
                    if (Entity!=null)
                    {
                        Entity.us_nombre = info.us_nombre;
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

        public bool anularDB(seg_usuario_info info)
        {
            try
            {
                using (EntitiesFactElectronica Context = new EntitiesFactElectronica())
                {
                    seg_usuario Entity = Context.seg_usuario.FirstOrDefault(q => q.IdUsuario == info.IdUsuario && q.us_contrasenia == info.us_contrasenia);
                    if (Entity != null)
                    {
                        Entity.estado = false;
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
