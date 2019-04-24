using FirmElect.Info;
using FirmElect.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Bus
{
    public class seg_usuario_bus
    {
        seg_usuario_data oData = new seg_usuario_data();

        public List<seg_usuario_info> get_list()
        {
            try
            {
                return oData.get_list();
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
                return oData.get_info(IdUsuario, us_contrasenia);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public seg_usuario_info get_info(string IdUsuario)
        {
            try
            {
                return oData.get_info(IdUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool guardarDB(seg_usuario_info info, ref string mensaje)
        {
            try
            {
                return oData.guardarDB(info, ref mensaje);
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
                return oData.modificarDB(info);
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
                return oData.anularDB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
