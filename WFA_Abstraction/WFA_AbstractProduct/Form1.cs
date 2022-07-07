using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_AbstractProduct.FakeDatabase;

namespace WFA_AbstractProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = "Beverages";

           string result= category.Add(category);
            MessageBox.Show(result);


            foreach (Category c in Database.categoryList)
            {
                MessageBox.Show(c.CategoryName);
            }

            //ListBox lst = new ListBox();
            //lst.Width = 300;
            //lst.Height=500;
            //lst.Name = "lstCategory";
            //lst.DataSource = Database.categoryList.ToList();

            //this.Controls.Add(lst);
          
        }

        
    }
}
