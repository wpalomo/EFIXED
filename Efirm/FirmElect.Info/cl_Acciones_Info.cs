using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Info
{
   public class cl_Acciones_Info
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Boolean Checked { get; set; }
        public int SegundosAEsperar { get; set; }



        public cl_Acciones_Info()
        {

        }

        public cl_Acciones_Info(Boolean _Checked, string _Key, string _Value, int _SegundosAEsperar)
        {
            Key = _Key;
            Value = _Value;
            Checked = _Checked;
            SegundosAEsperar = _SegundosAEsperar;
        }


    }
}
