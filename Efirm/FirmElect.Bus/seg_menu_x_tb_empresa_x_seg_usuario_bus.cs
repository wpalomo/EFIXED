using FirmElect.Info;
using FirmElect.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Data;
namespace FirmElect.Bus
{
    public class seg_menu_x_tb_empresa_x_seg_usuario_bus
    {
        seg_menu_x_tb_empresa_x_seg_usuario_data oData = new seg_menu_x_tb_empresa_x_seg_usuario_data();

        public List<seg_menu_x_tb_empresa_x_seg_usuario_info> get_list(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return oData.get_list(IdEmpresa,IdUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<seg_menu_x_tb_empresa_x_seg_usuario_info> get_no_list(int IdEmpresa, string IdUsuario)
        {
            try
            {
                return oData.get_no_list(IdEmpresa,IdUsuario);
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
                return oData.eliminarDB(IdEmpresa, IdUsuario);
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
                return oData.guardarDB(Lista);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}
