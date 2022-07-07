using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIslemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal guncelTutar = 0.00m;
        decimal cekilenTutar = 0;
        decimal yatirilanTutar = 0;
        string hataMesaj = "Islem gerceklestirilemedi. Hesabinizda yeterli para yok.";
        
        //todo: fiyatlar istege bagli guncellenebilir olsun. View-TaskList
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Uygulama calistirildiginda bakiye 500 tl gosterilecek. Para cek butonuna basildiginda belirtilen miktar kadar tanimli tutar bakiyeden dusecek. para yatira tiklandiginda belirtilen tutar bakiyeye eklenecek. bakiye 0 veya 0dan kucuk ise para cekme islemi gerceklestirilemeyecek ve kullaniciya mesaj gosterilecek ve para cek isimli butona tiklanamayacak. para yatir bolumune en az 1 tl yazilabilecek. her yapilan islemde bakiye degeri guncellenecek. yapilan her islem listbox'a eklenecek. format-> para cekme: cekilen miktar, guncel bakiye, para yatirma: yatirilan miktar, guncel bakiye seklinde olacak.
            guncelTutar = 500.00m; //uygulama baslatildiginda gunceltutar'in 500 gorunmesi icin, global alanda tanimladigimiz degiskeni bu alanda 500'e esitledik ve decimal tutar tanimladigimiz icin sonuna m harfiniz ekledir (m for money)
            lstAlisveris.Items.Clear(); //Uygulama baslatildiginda listboxlar bos olsun.
            lstIslem.Items.Clear();
            lblTutar.Text = guncelTutar.ToString()+" TL"; // veya  ToString("C2"); 
            //"(C2)" bolgenin para kodunu temsil eder. Burada TL olarak kullaniliyor.
            // tanimladigimiz decimal money tutari label bakiyede gorunsun.

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            cekilenTutar = nudParaCek.Value;

            if (guncelTutar >= cekilenTutar) 
            {
                
                guncelTutar -= cekilenTutar;
                lstIslem.Items.Add("Cekilen Tutar: " + cekilenTutar + " TL,  Guncel Tutar:" + guncelTutar + "TL");
                lblTutar.Text = guncelTutar.ToString() + " TL";              
            }
            else
            {
                MessageBox.Show(hataMesaj);
                lblTutar.Text = guncelTutar.ToString() + " TL";
            }
            if (guncelTutar == 0) 
            {
                btnParaCek.Visible = false; 
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            
                btnParaCek.Visible = true;
                yatirilanTutar = nudParaYatir.Value;
                guncelTutar += yatirilanTutar;
                lblTutar.Text = guncelTutar.ToString() + " TL";
                lstIslem.Items.Add("Yatirilan Tutar: " + yatirilanTutar + " TL,  Guncel Tutar:" + guncelTutar + " TL");

            
        }

        //Alisveris Sepeti Odev:
        //Alisverisi tamamla butonuna tiklandiginda secim yapilmis olan checkbox'larin fiyatlari toplanacak, toplanan fiyat alisveris listesi altinda bulunan listbox'a yazdirilacak. OR: peynir 45tl, ekmek 4 tl => toplam 49 tl
        //Bu islemin gerceklestirilmesi icin toplam tutarin bakiyeye esit ya da kucuk olmasi gerekmektedir. 

        private void btnAlisveris_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0; //alisveris listesi degiskenimiz her if dongusune girdiginde kendiyle toplanarak artiyor. Bu nedenle dongu basa geldiginda 0'lanmasi icin alisveris tutari'ni 0 tanimladik.
            string siparis = "";

            if (guncelTutar>0)
            {
                if (chkEkmek.Checked)
                {
                    toplamTutar += 4;
                    siparis += " Ekmek ";
                }
                if (chkYumurta.Checked)
                {
                    toplamTutar +=20;
                    siparis += " Yumurta ";
                }
                if (chkPeynir.Checked)
                {
                    toplamTutar += 45;
                    siparis += " Peynir ";
                }
                if (chkCikolata.Checked)
                {
                    toplamTutar += 30;
                    siparis += " Cikolata";
                }
                if (chkCay.Checked)
                {
                    toplamTutar += 35;
                    siparis += " Cay";
                }

                if (toplamTutar<=guncelTutar)
                {
                    lblToplam.Text = toplamTutar.ToString() + " TL";
                    lstAlisveris.Items.Add(siparis + " Toplam: " + toplamTutar.ToString() + " TL");
                    guncelTutar -= toplamTutar;
                    lblTutar.Text = guncelTutar.ToString() + " TL";
                    lblToplam.ForeColor = Color.Green;
                }
                else
                {
                    lblToplam.ForeColor = Color.Red;
                    MessageBox.Show(hataMesaj);
                }
            }
            else
            {
                MessageBox.Show(hataMesaj);
            }

        }

        

    }
}
