using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //whopper 25 tl, steakhouse 35 tl, tavuklu 20 tl, boyutlar kucuk 0 tl orta 3 tl buyuk 5 tl, ekstralar 2 tl fiyat farkiyla ekleniyor.
        //Hesaplaya basildiginda whopper orta(ketcap mayonez) 1 adet 32 tl seklinde listboxa eklenecek
        //Siparisi tamamlaya tiklandiginda pop up cikacak evet hayir, hayir secilirse kaldigi yerden devam, evet secilirse siparis komple listview'a aktarilacak. Sonra listview disindaki butun alanlar silinecek.


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("Whopper Menu");
            cmbMenu.Items.Add("SteakHouse Menu");
            cmbMenu.Items.Add("TavukluBiSey Menu");
        }

        //method
        void Ekle()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = cmbMenu.Text;
            lvi.SubItems.Add(boyut);
            lvi.SubItems.Add(ekstralar);
            lvi.SubItems.Add(urunAdedi.ToString());
            lvi.SubItems.Add((lblFiyat).ToString());

            listView1.Items.Add(lvi);
        }


        int urunAdedi = 0;
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            urunAdedi = lstSiparis.Items.Count;

            DialogResult dr = MessageBox.Show("Siparis Adedi:" + urunAdedi + "\nSiparis Toplam Tutari:" + lblFiyat + "\nSiparisi Tamamlamak Istediginize Emin Misiniz?", "Siparis Onayi", MessageBoxButtons.YesNo);


            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Siparisiniz Onaylandi!");
                Ekle();
                genelToplam += lblFiyat;
                lblGenelToplam.Text = genelToplam.ToString();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txt = (TextBox)ctrl; //unboxing /cast
                        txt.Text = "";
                    }
                    else if (ctrl is NumericUpDown)
                    {
                        NumericUpDown nud = (NumericUpDown)ctrl;
                        nud.Value = 1;
                    }
                    else if (ctrl is Label)
                    {
                        Label lbl = (Label)ctrl;

                        if (lbl.Name == "lblToplam")
                        {
                            lbl.Text = "";
                        }


                    }
                    else if (ctrl is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)ctrl;
                        cmb.SelectedIndex = -1;
                    }
                    else if (ctrl is RadioButton)
                    {
                        RadioButton rdb = (RadioButton)ctrl;
                        rdb.Checked = false;
                    }
                    else if (ctrl is ListBox)
                    {
                        ListBox lst = (ListBox)ctrl;
                        lst.Items.Clear();
                    }
                }
                foreach (Control ctrl in groupBox1.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ctrl;
                        chk.Checked = false;
                    }
                }

            }

        }

        int toplamFiyat = 0;
        string boyut = "";
        string menuAdi = "";
        string ekstralar = "";
        int adet = 0;
        int lblFiyat = 0;
        int genelToplam = 0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            toplamFiyat = 0;
            adet = 0;
            ekstralar = " ";

            adet = Convert.ToInt32(nudAdet.Value);

            if (cmbMenu.SelectedIndex != -1)
            {
                if (cmbMenu.SelectedIndex == 0)
                {
                    menuAdi = "Whopper Menu";
                    toplamFiyat += 25;
                }
                else if (cmbMenu.SelectedIndex == 1)
                {
                    menuAdi = "Steakhouse Menu";
                    toplamFiyat += 35;
                }
                else if (cmbMenu.SelectedIndex == 2)
                {
                    menuAdi = "Tavuklu Bi Sey Menu";
                    toplamFiyat += 20;
                }
                else
                {
                    MessageBox.Show("Lutfen menu seciniz!");
                }


                if (rbBuyuk.Checked)
                {
                    boyut = "Buyuk";
                    toplamFiyat += 5;
                }
                else if (rbOrta.Checked)
                {
                    boyut = "Orta";
                    toplamFiyat += 3;
                }
                else if (rbKucuk.Checked)
                {
                    boyut = "Kucuk";
                    toplamFiyat += 0;
                }
                else
                {
                    boyut = "Kucuk";
                    toplamFiyat += 0;
                }

                if (chkMayonez.Checked)
                {
                    toplamFiyat += 2;
                    ekstralar += "Mayonez ";
                }
                if (chkKetcap.Checked)
                {
                    toplamFiyat += 2;
                    ekstralar += "Ketcap ";
                }
                if (chkRanch.Checked)
                {
                    toplamFiyat += 2;
                    ekstralar += "Ranch ";
                }
                if (chkSarimsakli.Checked)
                {
                    toplamFiyat += 2;
                    ekstralar += "Sarimsakli Mayonez ";
                }
                if (chkBuffalo.Checked)
                {
                    toplamFiyat += 2;
                    ekstralar += "Buffalo ";
                }
                if (chkCheddar.Checked)
                {
                    toplamFiyat += 2;
                    ekstralar += "Cheddar ";
                }
                toplamFiyat *= adet;
                lblFiyat += toplamFiyat;
                string format = string.Format(" {0} Adet {1} {2} {3} {4} TL", adet, menuAdi, boyut, ekstralar, toplamFiyat);

                lstSiparis.Items.Add(format);
                lblToplam.Text = lblFiyat.ToString() + " TL ";
            }
            else
            {
                MessageBox.Show("Menu secimi yapiniz!");
            }

        }


    }
}
