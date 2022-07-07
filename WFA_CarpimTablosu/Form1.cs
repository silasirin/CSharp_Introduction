using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CarpimTablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Form yuklendiginde, 1'den 10'a kadar carpim tablosunuz listbox'a ekleyin. Her bir tablo arasina -------- konulsun.

            for (int i = 1; i <= 10; i++)
            {
                
                //listBox1.Items.Add(sayi + "x" + i + " = " + sonuc);

                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    string format = string.Format("{0} {1} {2} {3} {4}", i," x ", j , "=" , sonuc );
                    listBox1.Items.Add(format);

                }
                listBox1.Items.Add("-------------");

            }
            
            





        }
    }
}
