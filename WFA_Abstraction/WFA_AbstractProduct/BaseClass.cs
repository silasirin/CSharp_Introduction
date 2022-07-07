using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstractProduct
{
    public abstract class BaseClass
    {
        //Custom Properties
        public  DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        //Methods

        public abstract string Add(object obj);


    }
}
