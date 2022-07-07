using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
    public class KlasikGitar : Gitar
    {
        public override string Cal()
        {
            return "klasik gitar çalınıyor....";
        }
        public override string ToString()
        {
            return "Klasik Gitar " + Marka;
        }
    }
}
