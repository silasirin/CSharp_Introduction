using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKayitFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //COMBOBOX DEGER TANIMLAMA
            //cmbDeger.Items.Add("Mercedes");
            //cmbDeger.Items.Add("Renault");
            //cmbDeger.Items.Add("Honda");

            //COMBOBOX DEGER CAGIRMA
            //int secili = cmbDeger.SelectedIndex;
            //MessageBox.Show(secili.ToString()); //secili item'in index degerini verir.
            //MessageBox.Show(cmbDeger.SelectedItem.ToString()); //secili item'i verir.

            //MessageBox.Show(cmbDeger.Items[1].ToString()); --> Butona basinca renault'u goster

        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Listview
            //lvi.Text --> 0. index'i temsil eder (marka). Digerleri subitems'tir(diger basliklar).
            //lvi.Text = "Renault"; //0. index
            //lvi.SubItems.Add("Megane"); //1. index
            //lvi.SubItems.Add("Benzin"); //2. index
            //lvi.SubItems.Add("Otomatik"); //3. index
            //listView1.Items.Add(lvi); //listbox'a ekleme.
            //Bu ekleme sisteminde, 1. index'i atlayip 2.ye deger gireyim diye bir durum mumkun degil. 2.ye gecebilmek icin mutlaka 1. index'e bos da olsa bir deger girilmeli!

            //uygulama calistirildiginda cmbmarka'nin icerisine yukaridaki markalari ekle. Secilen markaya gore cmbmodelin icerisini doldur. 
            #endregion

            //ComboBox'a marka ekleme:
            cmbMarka.Items.Clear();
            cmbMarka.Items.Add("Alfa Romeo");
            cmbMarka.Items.Add("Renault");
            cmbMarka.Items.Add("Ferrari");
            cmbMarka.Items.Add("Porsche");
            cmbMarka.Items.Add("Tesla");

            //Yakit Tipi:
            cmbYakit.Items.Add("Dizel");
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Elektrikli");

            //Vites Tipi:
            cmbVites.Items.Add("Otomatik");
            cmbVites.Items.Add("Manuel");
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            switch (cmbMarka.Text)
            {
                case "Alfa Romeo":
                    cmbModel.Items.Add("Giulietta");
                    cmbModel.Items.Add("Quadrofoglio");
                    cmbModel.Items.Add("Giulia");
                    break;
                case "Renault":
                    cmbModel.Items.Add("Megane");
                    cmbModel.Items.Add("Clio");
                    cmbModel.Items.Add("Laguna");
                    break;
                case "Ferrari":
                    cmbModel.Items.Add("California");
                    cmbModel.Items.Add("Roma");
                    cmbModel.Items.Add("SF90");
                    break;
                case "Porsche":
                    cmbMarka.Items.Add("Cayman");
                    cmbModel.Items.Add("Boxster");
                    cmbModel.Items.Add("Carrera");
                    break;
                case "Tesla":
                    cmbMarka.Items.Add("X");
                    cmbModel.Items.Add("Y");
                    cmbModel.Items.Add("S");
                    break;
            }
        }
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(); //Listview kutuphanesinden instance aldik. bu islemi listview'a item ekleyebilmek icin yapiyoruz.
            lvi.UseItemStyleForSubItems = false; //subitem'larda stil islemi yapilacaksa, bu ozellik false olarak tanimlanmalidir.
            lvi.Text=cmbMarka.Text; // 0
            lvi.SubItems.Add(cmbModel.Text); // 1
            lvi.SubItems.Add(cmbYakit.Text); // 2
            lvi.SubItems.Add(cmbVites.Text); // 3
            lvi.SubItems.Add(""); // 4
            lvi.SubItems[4].BackColor = btnRenk.BackColor; //4. index'i boyamasi icin.
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString());

            listView1.Items.Add(lvi);
            lblAdet.Text = listView1.Items.Count.ToString();

        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = colorDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("islem iptal edildi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {//messageBox.Show'da yazilan 1. kisim yazilacak metin, 2. kisim acilan pop-up'in ustunde yazan yaziyi, 3. kisim yapabilecegimiz secimleri, 4. kisim pop-up'ta gorunecek ikonu temsil eder.
            
            if (listView1.SelectedItems.Count>0)
            {
                DialogResult dr = MessageBox.Show("Silmek istediginize emin misiniz?", "Silme Islemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]); //buradaki 0 -> 0. indexi temsil ediyor. Yani bizim silinmesi icin sectigimiz index. Eger listede silinecek item yoksa, uygulama hata verir. Bunun olmamasi icin if else kullaniriz.
                    MessageBox.Show("Veri silindi.");
                }
                else
                {
                    MessageBox.Show("Islem iptal edildi.");
                }
                
            }
            else
            {
                MessageBox.Show("Secili urun yok!");
            }
            lblAdet.Text = listView1.Items.Count.ToString();
        }
    }
}
