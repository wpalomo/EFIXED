using FirmElect.Info;
using FirmElect.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Bus
{
    public class seg_menu_bus
    {
        seg_menu_data oData = new seg_menu_data();

        public List<seg_menu_info> get_list()
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

        public bool guardarDB(seg_menu_info info)
        {
            try
            {
                return oData.guardarDB(info);
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
                return oData.modificarDB(info);
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
                return oData.anularDB(info);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
