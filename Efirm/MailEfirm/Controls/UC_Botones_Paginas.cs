using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MailEfirm.Controls
{
    public partial class UC_Botones_Paginas : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variables
        int _IndicePagina;
        int _NumeroPaginas;
        int _Total_Registros_x_pagina;

        public delegate void delegate_btn_Click(object sender, EventArgs e, int _IndicePagina);
        public event delegate_btn_Click event_click_buttons;
        
        public int Total_Registros_x_pagina
        {
            get {
                return _Total_Registros_x_pagina;
            }
        }

        public string Cadena_Busqueda { get; set; }
        #endregion

        public UC_Botones_Paginas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            _NumeroPaginas = 0;
            _IndicePagina = 1;
            event_click_buttons += UC_Botones_Paginas_event_click_buttons;
            _Total_Registros_x_pagina = 600;
            cmb_registros_x_pagina.Text = "600";
        }

        void UC_Botones_Paginas_event_click_buttons(object sender, EventArgs e, int _IndicePagina)
        {
            
        }

       
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
            get
            {
                return _NumeroPaginas;
            }
            set
            {
                _NumeroPaginas = value;
                lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;

            }
        }
       
        private void btn_pagIni_Click(object sender, EventArgs e)
        {
            try
            {
                _IndicePagina = 1;
                lblPagina.Text = "1/" + _NumeroPaginas;
                event_click_buttons(sender, e, _IndicePagina);
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_pagAnt_Click(object sender, EventArgs e)
        {
            try
            {
                _IndicePagina--;
                if (_IndicePagina <= 1)
                {
                    _IndicePagina = 1;
                }

                lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;
                event_click_buttons(sender, e, _IndicePagina);
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_PagSgt_Click(object sender, EventArgs e)
        {
            try
            {
                _IndicePagina++;
                if (_IndicePagina >= _NumeroPaginas)
                {
                    _IndicePagina = _NumeroPaginas;
                }
                lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;
                event_click_buttons(sender, e, _IndicePagina);
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_PagFin_Click(object sender, EventArgs e)
        {
            try
            {
                _IndicePagina = _NumeroPaginas;
                lblPagina.Text = _IndicePagina + "/" + _NumeroPaginas;
                event_click_buttons(sender, e, _IndicePagina);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_registros_x_pagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 _Total_Registros_x_pagina = Convert.ToInt32(cmb_registros_x_pagina.Text);
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Cadena_Busqueda = txtBusqueda.Text;
            }
            catch (Exception ex)
            {

            }
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
