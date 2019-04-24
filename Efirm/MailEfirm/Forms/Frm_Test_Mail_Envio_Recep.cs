using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.IO;
using FirmElect.Info;
using FirmElect.Bus;




namespace MailEfirm.Forms
{
    public partial class Frm_Test_Mail_Envio_Recep : Form
    {
        public Frm_Test_Mail_Envio_Recep()
        {
            InitializeComponent();
        }

       List<cl_error_Info> listErrores = new List<cl_error_Info>();

       private  string dirrecion_correo_cuenta;
       private string Server_saliente;
       private int Puerto_Saliente;
       private bool Usa_Credenciales_x_default;
       private string Usuario;
       private string password;
       private eTipo_Conexion_seguridad_SMTP Tipo_conexion;

       public Frm_Test_Mail_Envio_Recep(string _dirrecion_correo_cuenta, string _Server_saliente, int _Puerto_Saliente, bool _Usa_Credenciales_x_default
            , string _Usuario, string _password, eTipo_Conexion_seguridad_SMTP _Tipo_conexion)
           : this()
        {
            dirrecion_correo_cuenta = _dirrecion_correo_cuenta;
            Server_saliente = _Server_saliente;
            Puerto_Saliente = _Puerto_Saliente;
            Usa_Credenciales_x_default = _Usa_Credenciales_x_default;
            Usuario = _Usuario;
            password = _password;
            Tipo_conexion = _Tipo_conexion;
            listErrores = new List<cl_error_Info>();
            gridControl_tareas_realizadas.DataSource = listErrores;

        }

        
        
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Test_Mail_Envio_Recep_Load(object sender, EventArgs e)
        {

            Procesos();
            

        }


        private void Procesos()
        {
            try
            {
                Enviar_mail();
            }
            catch (Exception ex)
            {
                
                
            }
        }


        public Boolean Enviar_mail()
        {
            try
            {
                

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(dirrecion_correo_cuenta);
                msg.To.Add(new MailAddress(dirrecion_correo_cuenta));
                msg.Subject = "Mensaje de Prueba " + DateTime.Now;
                msg.Body = "Mensaje de Prueba configuracion de correo "  + DateTime.Now;
               

                SmtpClient cliente = new SmtpClient();
                cliente.Host = Server_saliente;
                cliente.Port = Puerto_Saliente;
                
                cliente.EnableSsl = false;
                cliente.UseDefaultCredentials = Usa_Credenciales_x_default;
                
                cliente.Credentials = new NetworkCredential(Usuario,password);
                
                switch (Tipo_conexion)
                { 
                    case eTipo_Conexion_seguridad_SMTP.SSL:
                        cliente.EnableSsl = true;
                        break;
                    case eTipo_Conexion_seguridad_SMTP.TLS:
                        cliente.EnableSsl = true;
                        break;
                    case eTipo_Conexion_seguridad_SMTP.Ninguno:
                        cliente.EnableSsl = false;
                        break;
                    default:
                        cliente.EnableSsl = false;
                        break;
                }


                cliente.Send(msg);

                //MessageBox.Show("Mensaje enviado ok..." + mensajeErrorOut);

                listErrores.Add(new cl_error_Info("0", "", DateTime.Now.ToString(), "A", eTipoError.INFO,eTipoRespuesta.OK));
                gridControl_tareas_realizadas.Refresh();

                return true;

            }
            catch (Exception ex)
            {
                listErrores.Add(new cl_error_Info("1", "", DateTime.Now.ToString(), "A", eTipoError.INFO,eTipoRespuesta.Error));
                gridControl_tareas_realizadas.Refresh();
                return false;
            }
        }


    }
}
