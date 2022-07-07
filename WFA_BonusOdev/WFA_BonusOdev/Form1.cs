using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BonusOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("T-Shirt");
            cmbKategori.Items.Add("Sweatshirt");
            cmbKategori.Items.Add("Kazak");
            cmbKategori.Items.Add("Gomlek");
            cmbKategori.Items.Add("Hirka");
        }


        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = txtUrunAdi.Text;
            lvi.SubItems.Add(cmbKategori.Text);
            lvi.SubItems.Add((nudFiyat.Value).ToString() + " TL");

            string seciliRenk = "";

            if (chkBeyaz.Checked)
            {
                seciliRenk += " Beyaz";
                
            }
            if (chkFusya.Checked)
            {
                seciliRenk += " Fusya";
            }
            if (chkKirmizi.Checked)
            {
                seciliRenk += " Kirmizi";
            }
            if (chkMavi.Checked)
            {
                seciliRenk += " Mavi";
            }
            if (chkSari.Checked)
            {
                seciliRenk += " Sari";
            }
            if (chkSiyah.Checked)
            {
                seciliRenk += " Siyah";
            }
            if (chkTitanBeyazi.Checked)
            {
                seciliRenk += " Titan Beyazi";
            }
            if (chkToricelliMavisi.Checked)
            {
                seciliRenk += " Toricelli Mavisi";
            }
            if (chkYavruAgzi.Checked)
            {
                seciliRenk += " Yavruagzi";
            }
            if (chkYeşil.Checked)
            {
                seciliRenk += " Yesil";
            }
            
            lvi.SubItems.Add(seciliRenk);
            listView1.Items.Add(lvi);

            chkYeşil.Checked = false;
            chkYavruAgzi.Checked = false;
            chkToricelliMavisi.Checked = false;
            chkTitanBeyazi.Checked = false;
            chkSiyah.Checked = false;   
            chkSari.Checked = false;
            chkMavi.Checked = false;
            chkKirmizi.Checked = false;
            chkFusya.Checked = false;
            chkBeyaz.Checked = false;
            txtUrunAdi.Clear();
            cmbKategori.Text = "";
            nudFiyat.Value = 0;

            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            lblSeciliUrunAd.Text = listView1.SelectedItems[0].SubItems[0].Text;
            lblSeciliKategori.Text = listView1.SelectedItems[0].SubItems[1].Text;
            lblSeciliFiyat.Text = listView1.SelectedItems[0].SubItems[2].Text;
            lblRenk.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count>0)
            {
                DialogResult dr = MessageBox.Show("Silmek istediginize emin misiniz?","Silme Islemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);    
                    MessageBox.Show("Silme islemi gerceklestirildi!");
                }
                else
                {
                    MessageBox.Show("Silme islemi iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Secili urun yok!");
            }
            lblSeciliUrunAd.Text = "";
            lblSeciliKategori.Text = "";
            lblSeciliFiyat.Text = "";
            lblRenk.Text = "";
        }
    }
}
