using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransAdi = txtBrans.Text;
            bransListesi.Add(brans);
            cmbBrans.Items.Add(brans.BransAdi);
            cmbRandevuBrans.Items.Add(brans.BransAdi);
            txtBrans.Text = "";
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Ad = txtDoktorAd.Text;
            
            if (txtDoktorAd.Text != "" && cmbBrans.SelectedIndex != -1)
            {
                foreach (Brans brans in bransListesi)
                {
                    if (brans.BransAdi.ToLower() == cmbBrans.Text.ToLower())
                    {
                        doktor.Brans = brans; //bu doktorun bransi gelen veriye esit olacak.
                        doktorListesi.Add(doktor);
                        
                    }
                }              
            }                     
            txtDoktorAd.Text = "";
            cmbBrans.Text = "";           
        }
        List<Doktor> doktorListesi = new List<Doktor>();
        List<Brans> bransListesi = new List<Brans>();

        double saat = 8.00;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text !="" && txtTckn.Text != "" && cmbRandevuBrans.SelectedIndex !=-1 && cmbRandevuDoktor.SelectedIndex != -1)
            {
                if (dateTimePicker1.Value <= DateTime.Now)
                {
                    MessageBox.Show("Gecerli bir tarih secimi yapiniz!");
                }
                else
                {
                    for (int i = 1; i < 10; i++)
                    {
                        
                        Button btn = new Button();
                        btn.Width = 60;
                        btn.Height = 30;
                        btn.BackColor = Color.Green;
                        saat += 1.00;
                        btn.Text = saat.ToString()+":00";
                        flowLayoutPanel1.Controls.Add(btn);
                        
                        btn.Click += Btn_Click;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lutfen bilgilerinizi eksiksiz giriniz!");
            }           
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            btn.Enabled = false;

            DialogResult dr = MessageBox.Show("Randevu Onaylansin mi?","Randevu Onayi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr==DialogResult.Yes)
            {
                MessageBox.Show("Randevunuz Onaylandi!");
            }
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRandevuDoktor.Items.Clear();
            foreach (Doktor doktor in doktorListesi)
            {
                
                if (doktor.Brans.BransAdi==cmbRandevuBrans.Text)
                {
                    cmbRandevuDoktor.Items.Add(doktor);
                }
            }
            cmbRandevuDoktor.Text = "";          
        }
    }
}
