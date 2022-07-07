using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_AbstractProduct.FakeDatabase;
namespace WFA_AbstractProduct
{
    public class Product:BaseClass
    {
       
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        public override string Add(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
