﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efirm
{
    public partial class frmComprobantes_recibidos_sin_respuestas : Form
    {
        public frmComprobantes_recibidos_sin_respuestas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
