using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_AbstractProduct.FakeDatabase;

namespace WFA_AbstractProduct
{
    public class Category:BaseClass
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string Add(object obj)
        {
            Category c = (Category)obj;
            Database.categoryList.Add(c);
            return "Kategori Eklendi";
        }

        public override string ToString()
        {
            return CategoryName;
        }

    }
}
