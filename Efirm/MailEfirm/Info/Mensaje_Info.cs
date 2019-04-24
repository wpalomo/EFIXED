using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MailEfirm.Info
{
   public class Mensaje_Info
    {
         DataRow row;
        DateTime fecha;
        bool leido, eliminado, respondido, tiene_archivos_adjuntos;
        int prioridad = 1;
        eTipoMail tipoMensaje;
        eCarpetasMail mailFolder;
        string from = String.Empty, subject = String.Empty, texto_mensaje = String.Empty;


        public Mensaje_Info() {
            this.fecha = DateTime.Now;
        }
        public Mensaje_Info(DataRow row) {
           this.row = row;
            this.fecha = ((DateTime)row["Date"]).Add(DateTime.Now - DataHelper.LastMailDate);
            this.from = string.Format("{0}", row["From"]);
            this.subject = string.Format("{0}", row["Subject"]);
            this.respondido = (bool)row["IsReply"];
            this.tiene_archivos_adjuntos = (bool)row["HasAttachment"];
            this.leido = (DateTime.Now - fecha) > TimeSpan.FromHours(40);
            this.texto_mensaje = string.Format("{0}", row["Text"]);
            this.eliminado = false;
            if(!Respondido)
                prioridad = 2;
            else
                if(string.IsNullOrEmpty(Carpeta))
                    prioridad = 0;
            tipoMensaje = eTipoMail.Buzon_Ent;
            mailFolder = Obtener_Carpeta(row);
            DataTweaking();
        }


        public decimal IdMensaje { get; set; }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public string Para { get { return from; } set { from = value; } }
        public string Asunto { get { return subject; } set { subject = value; } }
        public string Asunto_texto_mostrado { get { return string.Format("{1}{0}", Asunto, Respondido ? "RE: " : ""); } }
        public int Tiene_Adjunto { get { return tiene_archivos_adjuntos ? 1 : 0; } }
        public int Leido { get { return leido ? 1 : 0; } }
        public int Prioridad { get { return prioridad; } set { prioridad = value; } }
        internal bool Respondido { get { return respondido; } set { respondido = value; } }
        public bool No_Leido { get { return !leido; } }
        internal string Carpeta { get { return string.Format("{0}", mailFolder); } }
        public string Texto_mensaje { get { return texto_mensaje; } set { texto_mensaje = value; } }
        public eTipoMail Tipo_Mail { get { return tipoMensaje; } set { tipoMensaje = value; } }
        public eCarpetasMail Carpeta_Mensaje { get { return mailFolder; } set { mailFolder = value; } }
        public bool Eliminado { get { return eliminado; } set { eliminado = value; } }

        public void ToggleRead() {
            leido = !leido;
        }
        void DataTweaking() {
            if(this.Respondido) return;
            if(this.Asunto.IndexOf("IDataStore") > 0) leido = false;
        }
        eCarpetasMail Obtener_Carpeta(DataRow row) {
            string ret = string.Format("{0}", row["Folder"]);
            if(string.IsNullOrEmpty(ret)) return eCarpetasMail.All;
            return (eCarpetasMail)Enum.Parse(typeof(eCarpetasMail), ret.Replace(" ", ""));
        }

    }
}
