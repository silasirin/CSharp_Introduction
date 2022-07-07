using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstractProduct.FakeDatabase
{
    public  class Database
    {
      public static List<Product> productList = new List<Product>();
      public static List<Category> categoryList = new List<Category>();
      public static List<Supplier> supplierList = new List<Supplier>();
    }
}
