﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
    public class Piyano : MuzikAleti
    {
        public override string Cal()
        {
            return "Piyano çalınıyor... ";
        }
        public override string ToString()
        {
            return "Piyano " + Marka;
        }
    }
}
