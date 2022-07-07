using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
    public class Muzisyen
    {
        //bir muzisyenin ....'sı olur.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public MuzikAleti CaldigiEnstruman { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad + " Çaldığı Enstruman " + CaldigiEnstruman.Marka;
        }
    }
}
