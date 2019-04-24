using FirmElect.Info;
using FirmElect.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Bus
{
    public class seg_menu_x_tb_empresa_bus
    {
        seg_menu_x_tb_empresa_data oData = new seg_menu_x_tb_empresa_data();

        public List<seg_menu_x_tb_empresa_info> get_list(int IdEmpresa)
        {
            try
            {
                return oData.get_list(IdEmpresa);
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
                return oData.get_no_list(IdEmpresa);
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
                return oData.eliminarDB(IdEmpresa);
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
                return oData.guardarDB(Lista);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
