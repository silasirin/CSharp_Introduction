using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Abstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MuzikAleti> muzikAletleri = new List<MuzikAleti>();
        List<Muzisyen> muzisyenler = new List<Muzisyen>();

        private void Form1_Load(object sender, EventArgs e)
        {


            //Klasik Gitar
            KlasikGitar klasikGitar = new KlasikGitar();
            klasikGitar.Marka = "ABC";
            klasikGitar.Model = "xyz";
            klasikGitar.Tur = "Telli";
            klasikGitar.Fiyat = 5000;
            muzikAletleri.Add(klasikGitar);

            //Keman
            Keman keman = new Keman();
            keman.Marka = "TTT";
            keman.Model = "ttt";
            keman.Tur = "Telli";
            keman.Fiyat = 10000;
            muzikAletleri.Add(keman);

            //Piyano
            Piyano piyano = new Piyano();
            piyano.Marka = "Yamaha";
            piyano.Model = "kafabinbeşyüz";
            piyano.Tur = "Tuşlu";
            muzikAletleri.Add(piyano);

            //Muzisyen 1
            Muzisyen muzisyen1 = new Muzisyen();
            muzisyen1.Ad = "Sıla";
            muzisyen1.CaldigiEnstruman = klasikGitar;
            muzisyenler.Add(muzisyen1);

            //Muzisyen 2
            Muzisyen muzisyen2 = new Muzisyen();
            muzisyen2.Ad = "Caner";
            muzisyen2.CaldigiEnstruman = piyano;
            muzisyenler.Add(muzisyen2);


            //Muzisyen 3
            Muzisyen muzisyen3 = new Muzisyen();
            muzisyen3.Ad = "Tuba";
            muzisyen3.CaldigiEnstruman = keman;
            muzisyenler.Add(muzisyen3);


            listBox1.DataSource = muzisyenler.ToList();

            foreach (MuzikAleti muzikAleti in muzikAletleri)
            {
                if(muzikAleti is Keman)
                {
                    Keman k =(Keman) muzikAleti;
                    lstKeman.Items.Add(k);
                }
                else if(muzikAleti is KlasikGitar)
                {
                    KlasikGitar g = (KlasikGitar)muzikAleti;
                    lstKlasikGitar.Items.Add(g);
                }
                else if(muzikAleti is Piyano)
                {
                    Piyano p = (Piyano)muzikAleti;
                    lstPiyano.Items.Add(p);
                }
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
