using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //butonlara basildiginda rasgele 1-6 arasi sayi gelecek(zar atilacak) hangi taraf kazandiysa asagidaki label'da sonuc: 2 numarali oyuncu kazandi vs. gorunecek.

        //instance=> ornek alma. Bir nesnenin ram uzerine orneginiz alma islemi. Asagidaki sekilde yapilir:
        Random rnd = new Random(); //burada rnd instance oluyor. Boylece bu kopya silindiginde veya bir islem yapildiginda, orijinaline dokunmamis oluyoruz.
        // rnd.Next(); //rasgele rakam olusturmak istiyoruz. Bu yuzden next komutunu kullandik.
            //int rasgeleSayi = rnd.Next();
            //MessageBox.Show(rasgeleSayi.ToString()) ;
            //int rasgele = rnd.Next(6);
            //lblSonuc.Text = rasgele.ToString();

        private void btnZar1_Click(object sender, EventArgs e)
        {  
            //Olusturulacak deer 1 ile 6 arasinda olmali:
            int rasgele = rnd.Next(1, 7); //min degerin kendisi, max degerin 1 azini alir. Bunun sebebi C#'in sayma islemini 0'dan baslatmasidir.
            lblZar1.Text = rasgele.ToString();
            btnZar2.Enabled = true;
            btnZar1.Enabled = false;
        }
        int sayi1 = 0;
        int sayi2 = 0;
        private void btnZar2_Click(object sender, EventArgs e)
        {
            int rasgele2 = rnd.Next(1,7);
            lblZar2.Text = rasgele2.ToString();
            btnZar2.Enabled = false;
            sayi1 = int.Parse(lblZar1.Text);
            sayi2 = int.Parse(lblZar2.Text);

            if (sayi1>sayi2)
            {
                lblSonuc.Text = "1. oyuncu kazandi!";
                toplamPuan1 += ortadakiPuan;
                lblToplamPuan1.Text = toplamPuan1.ToString();
                
            }
            else if (sayi2>sayi1)
            {
                lblSonuc.Text = "2. oyuncu kazandi!";
                toplamPuan2 += ortadakiPuan;
                lblToplamPuan2.Text = toplamPuan2.ToString();

            }
            else if (sayi1==sayi2)
            {
                lblSonuc.Text = "Berabere! Tekrar Deneyin.";
                btnZar1.Enabled = true;
                btnZar2.Enabled = true;
            }          
            
        }
        int toplamPuan1 = 0;
        int toplamPuan2 = 0;
        int puanCek1 = 0;
        int puanCek2 = 0;
        int puanYatir1 = 0;
        int puanYatir2 = 0;
        int katil1 = 0;
        int katil2 = 0;
        int ortadakiPuan = 0;
        string mesaj = "Yetersiz Bakiye."; 
        private void Form1_Load(object sender, EventArgs e)
        {
            toplamPuan1 = 500;
            lblToplamPuan1.Text=toplamPuan1.ToString();
            toplamPuan2 = 500;
            lblToplamPuan2.Text = toplamPuan2.ToString();

            btnZar1.Enabled = false;
            btnZar2.Enabled = false;
            btnYatir2.Enabled = false;
        }

        private void btnPuanCek1_Click(object sender, EventArgs e)
        {
            if (toplamPuan1>=puanCek1)
            {
                puanCek1 = Convert.ToInt32(nudPuanCek1.Value);
                toplamPuan1 -= puanCek1;
                lblToplamPuan1.Text = toplamPuan1.ToString();
            }
            else
            {
                MessageBox.Show(mesaj);
            }
            
        }

        private void btnPuanCek2_Click(object sender, EventArgs e)
        {
            if (toplamPuan2 >= puanCek2)
            {
                puanCek2 = Convert.ToInt32(nudPuanCek2.Value);
                toplamPuan2 -= puanCek2;
                lblToplamPuan2.Text = toplamPuan2.ToString();
            }
            else
            {
                MessageBox.Show(mesaj);
            }
        }

        private void btnPuanYatir1_Click(object sender, EventArgs e)
        {
            puanYatir1 = Convert.ToInt32(nudPuanYatir1.Value);
            toplamPuan1 += puanYatir1;
            lblToplamPuan1.Text = toplamPuan1.ToString();
        }

        private void btnPuanYatir2_Click(object sender, EventArgs e)
        {
            puanYatir2 = Convert.ToInt32(nudPuanYatir2.Value);
            toplamPuan2 += puanYatir2;
            lblToplamPuan2.Text = toplamPuan2.ToString();
        }

        private void btnYatir1_Click(object sender, EventArgs e)
        {
            if (toplamPuan1>=katil1)
            {
                katil1 = Convert.ToInt32(nudKatil1.Value);
                ortadakiPuan = int.Parse(lblOrtadakiPuan.Text);
                ortadakiPuan += katil1;
                toplamPuan1 -= katil1;
                lblToplamPuan1.Text = toplamPuan1.ToString();
                lblOrtadakiPuan.Text = ortadakiPuan.ToString();
            }
            else
            {
                MessageBox.Show(mesaj);
            }
            btnYatir2.Enabled = true;
            btnYatir1.Enabled = false;
            
        }

        private void btnYatir2_Click(object sender, EventArgs e)
        {
            btnZar1.Enabled = true;
            if (toplamPuan2>=katil2)
            {
                katil2 = Convert.ToInt32(nudKatil2.Value);
                ortadakiPuan = int.Parse(lblOrtadakiPuan.Text);
                ortadakiPuan += katil2;
                toplamPuan2 -= katil2;
                lblToplamPuan2.Text = toplamPuan2.ToString();
                lblOrtadakiPuan.Text = ortadakiPuan.ToString();
            }
            else
            {
                MessageBox.Show(mesaj);
            }
        }
    }
}
