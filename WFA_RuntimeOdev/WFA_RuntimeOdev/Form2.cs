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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //2. Odev: button sayisi sinif sayisi kadar. uzerinde numaralar yazacak. O numaralardan herhangi birine tiklandiginda siniftan rastgele biri gelecek.

            

           
            int yatay = 50;
            int dikey = 50;
            int sayac = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Button btn = new Button();

                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Text = sayac.ToString();
                    btn.Left = yatay * (j);
                    btn.Top = dikey * (i);
                    sayac++;

                    this.Controls.Add(btn);
                    this.Width = yatay * j + btn.Width * 2;
                    this.Height = dikey * i + btn.Height * 2;

                    btn.Click += Btn_Click;
                }
            }

        }
        string[] sinifAdlar = { "Mert", "Azad", "Umut", "Sila", "Mert", "Onur", "Emre", "Enes", "Furkan Semih", "Kaan", "Bahadir", "Mert", "Burak", "Ahmet Caner", "Tuba", "Mahmure", "Arya", "Berk" };
        int rastgele = 0;
        string[] siniftakiler = new string[18];

        Random rnd = new Random();
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            rastgele = rnd.Next(0,sinifAdlar.Length);

           
            for (int i = 0; i < sinifAdlar.Length; i++)
            {

                if (!siniftakiler.Contains(rastgele.ToString()))
                {
                    btn.Name = sinifAdlar[rastgele];
                }
            }
            MessageBox.Show(btn.Name);



        }
    }
}
