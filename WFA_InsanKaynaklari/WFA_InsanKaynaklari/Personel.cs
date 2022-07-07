using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_InsanKaynaklari
{
    public class Personel
    {
        public Personel()
        {
            IseGiris=DateTime.Now;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public DateTime IseGiris { get; set; }
        public Departman Departman { get; set; }
        public override string ToString()
        {
            return $"Ad Soyad: {Ad} {Soyad} Tc No: {TCKN} Ise giris Tarihi: {IseGiris} Departman:";
        }
    }
}
