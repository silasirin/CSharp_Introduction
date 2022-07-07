using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
    public abstract class MuzikAleti
    {
        //bir müzik aletinin .......'sı olur.

        /*
           - Abstract olarak tanımlanan bir class'dan instance alınamaz.
           - Abstract metotlar sadece abstract classlar içerisinde kullanılır.
           - Abstract metotlar virtual olarak tanımlanmazlar.
           - Abstract classlar static olarak tanımlanamazlar.
           - Abstract metotların gövdesi olamaz!
         */

        public string Tur { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }

        public abstract string Cal();

    }
}
