using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Ekle butonuna tiklandiginda, yan yana 10x10 buttonla dolacak. uzerlerinde sirayla satirxsutun numarasi yazacak (2x3 vs) ve bu buttonlar ekrana ciktiginda, form ekrani tam buttonlarin genislik ve yuksekligine getirecek.
           

            int yatay = 50;
            int dikey = 50;


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();

                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Left =yatay * (j);
                    btn.Top = dikey * (i);
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);

                    this.Controls.Add(btn);                   
                }
             
            }
            this.AutoSize = true;
            btnEkle.Visible = false;

        }

    }
}