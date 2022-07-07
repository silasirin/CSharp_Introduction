using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCaseMevsimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAylar_Click(object sender, EventArgs e)
        {
            string mevsim = txtMevsim.Text.ToLower();
            string aylar = "";

            #region if else
            //if (mevsim=="ilkbahar")
            //{
            //    aylar = "ILKBAHAR AYLARI:\nMart\nNisan\nMayis";
            //}
            //else if (mevsim=="yaz")
            //{
            //    aylar = "YAZ AYLARI:\nHaziran\nTemmuz\nAgustos";
            //}
            //else if (mevsim=="sonbahar")
            //{
            //    aylar = "SONBAHAR AYLARI:\nEylul\nEkim\nKasim";
            //}
            //else if (mevsim=="kis")
            //{
            //    aylar = "KIS AYLARI:\nAralik\nOcak\nSubat";
            //}
            //else
            //{
            //    aylar = "Boyle bir mevsim bulunamadi!";
            //}
            //lblAylar.Text = aylar; 

            #endregion
            switch (mevsim)
            {
                case "kis":
                    aylar = "Aralik\nOcak\nSubat";

                    break;

                case "yaz":
                    aylar = "Haziran\nTemmuz\nAgustos";
                    break;

                case "ilkbahar":
                    aylar = "Mart\nNisan\nMayis";
                    break;

                case "sonbahar":
                    aylar = "Eylul\nEkim\nKasim";
                    break;

                default:
                    aylar = "Boyle bir mevsim bulunamadi!";
                    break;
            }
            lblAylar.Text = aylar;
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //txtKontrol'e girilen admin moderator yonetici ceo baskan girilirse mesaj kutusunda yonetim paneline yonlendiriliyorsunuz. uye ise anasayfaya yonlendiriliyorsunuz. harici bir deger girilirse bu sayfayi goruntulemeye yetkiniz bulunmamaktadir mesaji gorunsun.

            string gelenDeger = txtKontrol.Text.ToLower();

            switch (gelenDeger)
            {
                case "admin":
                case "moderator":
                case "yonetici":
                case "ceo":
                case "baskan":
                    MessageBox.Show("Yonetim paneline yonlendiriliyorsunuz.");
                    break;

                case "uye":
                    MessageBox.Show("Anasayfaya yonlendiriliyorsunuz.");
                    break;
                default:
                    MessageBox.Show("Bu sayfayi goruntulemeye yetkiniz bulunmamaktadir.");
                    break;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //kullanici adi: bilgeadam , sifre: 1234
            // dogru girilirse "profil sayfasina yonlendiriliyorsunuz, kullanici adi yanlissa "kullanici adi yanlis, sifreye bakmadim bile",kullanici adi dogru, sifre yanlissa "kullanici adi dogru, sifreniz hatali" yazacak.
            string kullaniciAdi = txtKullaniciAdi.Text.ToLower();
            string sifre = txtSifre.Text.ToLower();

            switch (kullaniciAdi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "1234":
                            MessageBox.Show("Profil Sayfasina Yonlendiriliyorsunuz.");
                            break;
                        default:
                            MessageBox.Show("Kullanici adi dogru, sifre hatali!");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullanici adi hatali, sifreye bakmadim bile!");
                    break;
            }

        }

    }
}
