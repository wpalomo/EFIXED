using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Efirm
{
    public partial class UC_Botones_Paginas : DevExpress.XtraEditors.XtraUserControl
    {
		///
        #region Variables
        int _IndicePagina;
        int _NumeroPaginas;
        int _Total_Registros_x_pagina;
        public delegate void delegate_btn_Click(object sender, EventArgs e, int _IndicePagina, int _Total_Registros_x_pagina);
        public event delegate_btn_Click event_click_buttons;
        #endregion
      
        public int IndicePagina
        {
            get
            {
                return _IndicePagina;
            }
            set
            {
                _IndicePagina = value;
                lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;

            }
        }

        public int NumeroPaginas 
        { 
            get {
                return _NumeroPaginas;
                } 
          set {
              _NumeroPaginas = value;
              lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;

              } 
        }

        public int Total_Registros_x_pagina
        {
            get
            {

                return _Total_Registros_x_pagina;
            } 
        }

        public UC_Botones_Paginas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            _NumeroPaginas = 0;
            _IndicePagina = 1;
            event_click_buttons +=UC_Botones_Paginas_event_click_buttons;
            _Total_Registros_x_pagina = 900;
            cmb_registros_x_pagina.Text = "900";
        }

        void UC_Botones_Paginas_event_click_buttons(object sender, EventArgs e, int _IndicePagina, int _Total_Registros_x_pagina)
        {
            
        }

        

        

        private void btn_pagina_Ini_Click(object sender, EventArgs e)
        {
            _IndicePagina = 1;
            lblPagina.Text = "1/" + _NumeroPaginas;
            event_click_buttons(sender, e, _IndicePagina, _Total_Registros_x_pagina);
            
        }

        private void btn_pagina_ant_Click(object sender, EventArgs e)
        {
            _IndicePagina--;
            if (_IndicePagina <= 1)
            {
                _IndicePagina = 1;
            }

            lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;
            event_click_buttons(sender, e, _IndicePagina, _Total_Registros_x_pagina);

        }

        private void btn_pagina_sig_Click(object sender, EventArgs e)
        {
            _IndicePagina++;
            if (_IndicePagina >= _NumeroPaginas)
            {
                _IndicePagina = _NumeroPaginas;
            }
            lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;
            event_click_buttons(sender, e, _IndicePagina, _Total_Registros_x_pagina);

        }

        private void btn_pagina_fin_Click(object sender, EventArgs e)
        {
            _IndicePagina = _NumeroPaginas;
            lblPagina.Text = _IndicePagina+ "/" + _NumeroPaginas;
            event_click_buttons(sender, e, _IndicePagina, _Total_Registros_x_pagina);
          
        }

        private void cmb_registros_x_pagina_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStrip_Pagina_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmb_registros_x_pagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Total_Registros_x_pagina = Convert.ToInt32(cmb_registros_x_pagina.Text);
        }

        private void cmb_registros_x_pagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }

                

            }
            catch (Exception ex)
            {
                
                
            }
            
        }

        private void cmb_registros_x_pagina_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _Total_Registros_x_pagina = Convert.ToInt32(cmb_registros_x_pagina.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
    }
}
