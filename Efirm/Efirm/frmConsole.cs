using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Efirm
{
    public partial class frmConsole : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        int i = 0;

        public frmConsole()
        {
            InitializeComponent();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            btn_leer.Enabled = false;
            //ListaDeArchivos.ItemsSource = ObtenerArchivos();
            btn_leer.Enabled= true;

            Console.WriteLine("hola consola #:" + i++);
        }

        private IEnumerable<string> ObtenerArchivos()
        {
            var archivos = from archivo
            in
                               System.IO.Directory.GetFiles(@"C:\Windows\System32")
                           select archivo;
            System.Threading.Thread.Sleep(5000);
            return archivos;
        }

        private void frmConsole_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

    }
}
