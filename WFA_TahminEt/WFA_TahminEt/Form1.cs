using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int tutulanSayi; //programin random tuttugu sayi
        int tahminEdilenSayi; //bizim textbox'a girdigimiz sayi
        int tahminHakki=5;
        int seviye = 1;
        int seviyeCarpani = 10;
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (tahminHakki > 0)
                {

                    tahminEdilenSayi = int.Parse(txtTahmin.Text);
                    tahminHakki = int.Parse(lblTahminHakki.Text);
                    seviye = int.Parse(lblSeviye.Text);

                    if (tahminEdilenSayi > tutulanSayi)
                    {
                        lblSonuc.Text = "Daha kucuk bir deger giriniz.";
                        tahminHakki--;
                        lblTahminHakki.Text = tahminHakki.ToString();
                    }
                    else if (tahminEdilenSayi < tutulanSayi)
                    {
                        lblSonuc.Text = "Daha buyuk bir deger giriniz.";
                        tahminHakki--;
                        lblTahminHakki.Text = tahminHakki.ToString();
                    }
                    else if (tahminEdilenSayi == tutulanSayi)
                    {
                        lblSonuc.Text = "Tebrikler, kazandiniz!";
                        tahminHakki = 5;
                        seviye++;
                        lblSeviye.Text = seviye.ToString();
                        lblTahminHakki.Text = tahminHakki.ToString();

                        tutulanSayi = rnd.Next(1,seviye*seviyeCarpani+1);
                        this.Text = tutulanSayi.ToString();
                    }

                    lstIslem.Items.Add("Tahmin Edilen Sayi: " + tahminEdilenSayi + ", Seviye: " + seviye);
                }
                else
                {
                    MessageBox.Show("Kaybettiniz!");
                    tahminHakki = 5;
                    seviye = 1;
                    lblSeviye.Text = seviye.ToString();
                    lblTahminHakki.Text = tahminHakki.ToString();
                    tutulanSayi = rnd.Next(1, 11);
                }
            }
            catch (Exception)
            {

                lblSonuc.Text = "Lutfen gecerli bir deger giriniz!";
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = tahminHakki.ToString();
            tutulanSayi = rnd.Next(1,11);
            this.Text = tutulanSayi.ToString(); //formun text'i sol ust kosede bulunuyor.
           // rasgele = rnd.Next(1, 11);

           // this.Text=rasgele.ToString(); //this ait olunan ana kapsayiciyi temsil eder. bu alanda form1'i temsil ediyor.
           //form1 veya groupbox'in ozelliklerine ulasabilmek icin this kullanilir.
        }
    }
}
