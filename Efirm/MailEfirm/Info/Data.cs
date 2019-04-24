using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.Utils;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using DevExpress.XtraExport;
using System.Xml;
using MailEfirm.Info;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;
using MailEfirm;
namespace MailEfirm.Info
{
    public class Mensaje {
        DataRow row;
        DateTime date;
        bool leer, eliminar, si_respondido, hasAttachment;
        int prioridad = 1;
        eTipoMail tipoMensaje;
        eCarpetasMail mailFolder;
        string from = String.Empty, subject = String.Empty, text = String.Empty;

        public Mensaje() {
            this.date = DateTime.Now;
        }
        public Mensaje(DataRow row) {
            this.row = row;
            this.date = ((DateTime)row["Date"]).Add(DateTime.Now - DataHelper.LastMailDate);
            this.from = string.Format("{0}", row["From"]);
            this.subject = string.Format("{0}", row["Subject"]);
            this.si_respondido = (bool)row["IsReply"];
            this.hasAttachment = (bool)row["HasAttachment"];
            this.leer = (DateTime.Now - date) > TimeSpan.FromHours(40);
            this.text = string.Format("{0}", row["Text"]);
            this.eliminar = false;
            if(!Si_Respondido)
                prioridad = 2;
            else
                if(string.IsNullOrEmpty(Carpeta))
                    prioridad = 0;
            tipoMensaje = eTipoMail.Buzon_Ent;
            mailFolder = Obtener_Carpeta(row);
            DataTweaking();
        }

        public DateTime Date { get { return date; } set { date = value; } }
        public string From { get { return from; } set { from = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string SubjectDisplayText { get { return string.Format("{1}{0}", Subject, Si_Respondido ? "RE: " : ""); } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Leer { get { return leer ? 1 : 0; } }
        public int Prioridad { get { return prioridad; } set { prioridad = value; } }
        internal bool Si_Respondido { get { return si_respondido; } set { si_respondido = value; } }
        public bool No_Leido { get { return !leer; } }
        internal string Carpeta { get { return string.Format("{0}", mailFolder); } }
        public string Texto { get { return text; } set { text = value; } }
        public eTipoMail Tipo_Mail { get { return tipoMensaje; } set { tipoMensaje = value; } }
        public eCarpetasMail Carpeta_Mensaje { get { return mailFolder; } set { mailFolder = value; } }
        public bool Eliminado { get { return eliminar; } set { eliminar = value; } }

        public void ToggleRead() {
            leer = !leer;
        }
        void DataTweaking() {
            if(this.Si_Respondido) return;
            if(this.Subject.IndexOf("IDataStore") > 0) leer = false;
        }
        eCarpetasMail Obtener_Carpeta(DataRow row) {
            string ret = string.Format("{0}", row["Folder"]);
            if(string.IsNullOrEmpty(ret)) return eCarpetasMail.All;
            return (eCarpetasMail)Enum.Parse(typeof(eCarpetasMail), ret.Replace(" ", ""));
        }
    }
    
    
    public class Contacto : IComparable {
        DataRow customer, person;
        Image foto;
        NombreCompleto name;
        string email, telefono, nota;
        eGenero genero;
        DateTime? fecha_nacimiento;
        Address direccion;
        bool hay_foto = false;
        public Contacto() {
            //name = new FullName(Properties.Resources.NewFirstName, string.Empty, Properties.Resources.NewLastName);
            name = new NombreCompleto("", "", "");
            direccion = new Address();
        }
        public Contacto(Contacto contact) {
            name = new NombreCompleto();
            direccion = new Address();
            this.Assign(contact);
        }
        public Contacto(DataRow customer, DataRow person) {
            this.customer = customer;
            this.person = person;
            if(!(customer["foto"] is DBNull)) {
                foto = ByteImageConverter.FromByteArray((byte[])customer["foto"]);
                hay_foto = true;
            } 
            //else foto = global::DevExpress.MailClient.Win.Properties.Resources.Unknown_user;

            name = new NombreCompleto(string.Format("{0}", person["FirstName"]), string.Format("{0}", customer["MiddleName"]), string.Format("{0}", person["LastName"]));
            email = string.Format("{0}", customer["Email"]).Replace("dxvideorent.com", "dxmail.net");
            genero = (eGenero)person["Gender"];
            fecha_nacimiento = (DateTime?)person["BirthDate"];
            telefono = string.Format("{0}", customer["Phone"]);
            direccion = new Address(string.Format("{0}", customer["Address"]));
        }
        public string Nombre { get { return name.ToString(); } }
        public string PrimerNombre { get { return name.PimerNombre; } }
        public string SegundoNombre { get { return name.SegundoNombre; } }
        public string Apellidos { get { return name.Apellidos; } }
        public string Email { get { return email; } set { email = value; } }
        public eGenero Genero { get { return genero; } set { genero = value; } }
        public DateTime? FechaNacimiento { get { return fecha_nacimiento; } }
        public DateTime BindingBirthDate {
            get {
                if(FechaNacimiento.HasValue)
                    return FechaNacimiento.Value;
                return DateTime.MinValue;
            }
            set {
                fecha_nacimiento = value;
            }
        }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Estado { get { return direccion.Estado; } }
        public string City { get { return direccion.Ciudad; } }
        public Address Direccion { get { return direccion; } }
        public NombreCompleto FullName { get { return name; } }
        public Image Foto { get { return foto; } set { foto = value; } }
        public string Nota { get { return nota; } set { nota = value; } }
        public string GetContactInfoHtml() {
            string ret = string.Format("<size=+2><b>{0}</b><size=-2>", Nombre);
            ret += "<br>";
            if(FechaNacimiento != null && FechaNacimiento != DateTime.MinValue) ret += string.Format(Properties.Resources.BirthDateHtml, FechaNacimiento);
            if(!string.IsNullOrEmpty(Email)) ret += string.Format(Properties.Resources.EmailHtml, Email);
            if(!string.IsNullOrEmpty(Telefono)) ret += string.Format(Properties.Resources.PhoneHtml, Telefono);
            ret += string.Format(Properties.Resources.AddressHtml, Direccion);
            

            return ret;
        }
        public override string ToString() { return Nombre; }
        public Image Icon {
            get {
                eTipo_Contacto title = name.Titulo;
                if(title == eTipo_Contacto.None && genero == eGenero.Femenino) title = eTipo_Contacto.Srs;
                switch(title) {
                    case eTipo_Contacto.Dr: return global:: MailEfirm.Properties.Resources.Doctor;
                    case eTipo_Contacto.Sta: return global::MailEfirm.Properties.Resources.Miss;
                    case eTipo_Contacto.Srs: return global::MailEfirm.Properties.Resources.Mrs;
                    case eTipo_Contacto.Ms: return global::MailEfirm.Properties.Resources.Ms;
                    case eTipo_Contacto.Prof: return global::MailEfirm.Properties.Resources.Professor;
                        
                }
                return global::MailEfirm.Properties.Resources.Mr;
            }
        }
        internal bool Hasfoto { get { return hay_foto; } }
        public void Assign(Contacto contact) {
            this.foto = contact.Foto;
            this.name.Assign(contact.FullName);
            this.direccion.Assign(contact.Direccion);
            this.email = contact.Email;
            this.genero = contact.Genero;
            this.fecha_nacimiento = contact.FechaNacimiento;
            this.telefono = contact.Telefono;
            this.nota = contact.Nota;
        }
        public Contacto Clone() {
            return new Contacto(this);
        }
        #region IComparable Members

        public int CompareTo(object obj) {
            return Comparer<string>.Default.Compare(Nombre, obj.ToString());
        }

        #endregion
    }
    public class NombreCompleto {
        eTipo_Contacto titulo;
        string primero, medio, utimo;
        public NombreCompleto() : this(string.Empty, string.Empty, string.Empty) { }
        public NombreCompleto(string first, string middle, string last) : this(eTipo_Contacto.None, first, middle, last) { }
        public NombreCompleto(eTipo_Contacto titulo, string primero, string medio, string ultimo) {
            this.titulo = titulo;
            this.primero = primero;
            this.medio = medio;
            this.utimo = ultimo;
        }
        public eTipo_Contacto Titulo { get { return titulo; } set { titulo = value; } }
        public string PimerNombre { get { return primero; } set { primero = value; } }
        public string SegundoNombre { get { return medio; } set { medio = value; } }
        public string Apellidos { get { return utimo; } set { utimo = value; } }
        
        public override string ToString() {
            //return string.Format("{0}{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)), 
            //    GetFormatString(FirstName), GetFormatString(MiddleName), LastName);

            return string.Format("{0}{1}{2}{3}", GetFormatString(Titulo.ToString()), 
                GetFormatString(PimerNombre), GetFormatString(SegundoNombre), Apellidos);
        }


        string GetFormatString(string name) {
            if(string.IsNullOrEmpty(name)) return string.Empty;
            return string.Format("{0} ", name);
        }
        public void Assign(NombreCompleto name) {
            this.titulo = name.Titulo;
            this.primero = name.PimerNombre;
            this.medio = name.SegundoNombre;
            this.utimo = name.Apellidos;
        }
    }
    public class Address {
        string direccion, ciudad = string.Empty, estado = string.Empty, zip;
        public Address() : this(string.Empty) { }
        public Address(string address, string city, string state, string zip) {
            this.direccion = address;
            this.ciudad = city;
            this.estado = state;
            this.zip = zip;
        }
        internal Address(string addressString) {
            if(string.IsNullOrEmpty(addressString)) return;
            try {
                string[] lines = addressString.Split(',');
                this.direccion = lines[0].Trim();
                this.ciudad = lines[1].Trim();
                this.estado = lines[2].Trim().Substring(0, 2);
                string temp = lines[2].Trim();
                this.zip = temp.Substring(3, temp.Length - 3);
            } catch { }
        }
        public string AddressLine { get { return direccion; } set { direccion = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }
        public string Cremallera { get { return zip; } set { zip = value; } }
        public override string ToString() {
            return string.Format("{0}{1}{2}{3}", GetFormatString(AddressLine), GetFormatString(Ciudad), GetFormatString(Estado), Cremallera);
        }
        string GetFormatString(string name) {
            if(string.IsNullOrEmpty(name)) return string.Empty;
            return string.Format("{0}, ", name);
        }
        public void Assign(Address address) {
            this.direccion = address.AddressLine;
            this.estado = address.Estado;
            this.ciudad = address.Ciudad;
            this.zip = address.Cremallera;
        }
    }
   
    public class DataHelper {
        internal static bool ShowAllMessageCount = false;
        internal static bool ShowUnreadMessageCount = true;
        static List<Mensaje> mensaje = null;
        static List<Contacto> contacto = null;
        //static List<Task> tasks = null;
        internal static DateTime LastMailDate = DateTime.Now;
        internal static DateTime CalendarDate = DateTime.Today;
        internal static string[] ApplicationArguments;
        
        static DataTable calendarResourcesTable;
        static DataTable calendarAppointmentsTable;

        internal static DataTable MailTable {
            get {
                string table = "Messages";
                DataTable messages = CreateDataTable(table);
                if(messages != null && messages.Rows.Count > 0)
                    LastMailDate = (DateTime)messages.Rows[0]["Date"];
                return messages;
            }
        }
        public static List<Mensaje> Messages {
            get {
                try {
                    if(mensaje == null) {
                        mensaje = new List<Mensaje>();
                        DataTable tbl = MailTable;
                        if(tbl != null) {
                            foreach(DataRow row in tbl.Rows)
                                mensaje.Add(new Mensaje(row));
                        }
                        mensaje.Add(CreateMessageAbout());
                    }
                } catch(Exception e) {
                    XtraMessageBox.Show(e.Message, e.Source);
                    mensaje = new List<Mensaje>();
                    mensaje.Add(CreateMessageAbout());
                }
                return mensaje;
            }
        }
        public static List<Contacto> Contactos {
            get {
                if(contacto == null)
                    contacto = GetContacts();
                return contacto;
            }
        }
       
       
        internal static List<Contacto> GetContacts() {
            List<Contacto> ret = new List<Contacto>();
            DataSet temp = new DataSet();
            string dbName = FilesHelper.FindingFileName(Application.StartupPath, "Data\\VideoRent.xml", false);
            if(string.IsNullOrEmpty(dbName)) return ret;
            temp.ReadXml(dbName);
            DataTable tbl = temp.Relations["FK_CustomerOidOidPerson"].ChildTable;
            for(int i = 0; i < tbl.Rows.Count; i++)
                ret.Add(new Contacto(tbl.Rows[i], tbl.Rows[i].GetParentRow("FK_CustomerOidOidPerson")));
            return ret;
        }

        static Mensaje CreateMessageAbout()
        {
            Mensaje ret = new Mensaje();
            ret.Subject = "";// Properties.Resources.AboutSubj;
            ret.From = "";// Properties.Resources.AboutFrom;
            ret.Prioridad = 2;
            ret.Texto = "";// StringResources.Get("AboutMessage");
            ret.Carpeta_Mensaje = eCarpetasMail.Announcements;
            return ret;
        }

        internal static DataTable CalendarResources {
            get {
                if(calendarResourcesTable == null) {
                    string table = "Resources";
                    calendarResourcesTable = CreateDataTable(table);
                }
                return calendarResourcesTable;
            }
        }
        internal static DataTable CalendarAppointments {
            get {
                if(calendarAppointmentsTable == null) {
                    string table = "Appointments";
                    calendarAppointmentsTable = CreateDataTable(table);
                }
                return calendarAppointmentsTable;
            }
        }

        private static DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            string dataFile = FilesHelper.FindingFileName(Application.StartupPath, "Data\\Mail.xml");
            if(dataFile != string.Empty) {
                FileInfo fi = new FileInfo(dataFile);
                dataSet.ReadXml(fi.FullName);
                return dataSet.Tables[table];
            }
            return null;
        }
    }
    //internal class TaskGenerator {
    //    public static int CustomerCount = 10;
    //    static Random rndGenerator = new Random();
    //    static List<Contacto> customers;
    //    internal static List<Contacto> Customers {
    //        get {
    //            if(customers == null) {
    //                customers = new List<Contacto>();
    //                List<Contacto> temp = DataHelper.GetContacts();
    //                if(temp.Count > CustomerCount) {
    //                    while(customers.Count < CustomerCount) {
    //                        Contacto contact = GetCustomer(rndGenerator.Next(temp.Count - 1), customers, temp);
    //                        if(contact != null)
    //                            customers.Add(contact);
    //                    }
    //                }
    //            }
    //            return customers;
    //        }
    //    }
    //    static Contacto GetCustomer(int index, List<Contacto> cliente, List<Contacto> contacto) {
    //        Contacto contact = contacto[index];
    //        if(!contact.Hasfoto) return null;
    //        foreach(Contacto c in cliente)
    //            if(ReferenceEquals(c, contact)) return null;
    //        return contact;
    //    }
      
    //}
    
    
    public class LayoutOption {
        public static bool TaskCollapsed = false;
        public static bool MailCollapsed = false;
    }
}
