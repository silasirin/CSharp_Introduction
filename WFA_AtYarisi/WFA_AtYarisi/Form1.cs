using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            //atlar finish cizgisine dogru hareket edecekler. Hangi atin finish cizgisine once geleceginiz bilmeyecegiz. 

            //pbAt1.Left += 50; //soldan saga 50ser artarak ilerler
            //pbAt1.Right Read Only'dir.Komut verilemez. picturebox'i sola kaydirmak icin kullanamayiz. bunun icin pbAt1.Left -=50; olarak tanimlamamiz gereklidir.
            //Atlari random degerde kosturma:

            if (rastgeleRenk == 1)
            {
                this.BackColor = Color.Blue;
                pbAt1.Left += rnd.Next(30, 40);
                pbAt2.Left += rnd.Next(10, 30);
                pbAt3.Left += rnd.Next(10, 30);
            }
            else if (rastgeleRenk == 2)
            {
                this.BackColor = Color.Green;
                pbAt1.Left += rnd.Next(10, 30);
                pbAt2.Left += rnd.Next(30, 40);
                pbAt3.Left += rnd.Next(10, 30);
            }
            else if (rastgeleRenk == 3)
            {
                this.BackColor = Color.Gray;
                pbAt1.Left += rnd.Next(10, 30);
                pbAt2.Left += rnd.Next(10, 30);
                pbAt3.Left += rnd.Next(30, 40);
            }


            if (pbAt1.Right>pbAt2.Right && pbAt1.Right>pbAt3.Right)
            {
                lblSpiker.Text = "Birinci At Onde";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "Ikinci At Onde";
            }
            else if (pbAt3.Right > pbAt2.Right && pbAt3.Right > pbAt1.Right)
            {
                lblSpiker.Text = "Ucuncu At Onde";
            }

            //Kazanma durumu
            if (rastgeleRenk == 1)
            {
                pbAt1.Left += rnd.Next(30, 40);
                pbAt2.Left += rnd.Next(10, 30);
                pbAt3.Left += rnd.Next(10, 30);
            }
            else if (rastgeleRenk == 2)
            {
                pbAt1.Left += rnd.Next(10, 30);
                pbAt2.Left += rnd.Next(30, 40);
                pbAt3.Left += rnd.Next(10, 30);
            }
            else if (rastgeleRenk == 3)
            {
                pbAt1.Left += rnd.Next(10, 30);
                pbAt2.Left += rnd.Next(10, 30);
                pbAt3.Left += rnd.Next(30, 40);
            }
            if (pbAt1.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("1. at kazandi!\nKazanilan Para: "+kazanilanPara1+" TL\nTekrar Oynamak Ister misiniz?", " Oyun Bitti.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 4;
                    pbAt2.Left = 4;
                    pbAt3.Left = 4;
                    rastgeleRenk = rnd.Next(1, 4);

                }
                else
                {
                    Application.Exit();
                }


            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("2. at kazandi!\nKazanilan Para: " + kazanilanPara2 + " TL\nTekrar Oynamak Ister misiniz?", " Oyun Bitti.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 4;
                    pbAt2.Left = 4;
                    pbAt3.Left = 4;
                    rastgeleRenk = rnd.Next(1, 4);

                }
                else
                {
                    Application.Exit();
                }

            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("3. at kazandi!\nKazanilan Para: " + kazanilanPara3 + " TL\nTekrar Oynamak Ister misiniz?", " Oyun Bitti.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 4;
                    pbAt2.Left = 4;
                    pbAt3.Left = 4;
                }
                else
                {
                    Application.Exit();
                }
            }
            

        }
        int rastgeleRenk;
        Color backGround1;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;
            rastgeleRenk = rnd.Next(1,4);

            if (rastgeleRenk == 1)
            {
                backGround1 = Color.Blue;
            }
            else if (rastgeleRenk == 2)
            {
                backGround1 = Color.Green;
            }
            else if (rastgeleRenk == 3)
            {
                backGround1 = Color.Gray;
            }
            this.BackColor = backGround1;

        }
        double kazanilanPara1;
        double kazanilanPara2;
        double kazanilanPara3;
        string mesaj = "Lutfen Sayisal Bir Oran Giriniz.";


        private void btnYatir1_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = true;
            try
            {
                kazanilanPara1 = double.Parse(txtOran1.Text) * (Convert.ToDouble(nud1.Value));
            }
            catch (Exception)
            {
                MessageBox.Show(mesaj);
            }
           
        }

        private void btnYatir2_Click(object sender, EventArgs e)
        {
            try
            {
                btnBaslat.Enabled = true;
                kazanilanPara2 = Double.Parse(txtOran2.Text) * (Convert.ToDouble(nud2.Value));

            }
            catch (Exception)
            {
                MessageBox.Show(mesaj);
            }
            
        }

        private void btnYatir3_Click(object sender, EventArgs e)
        { 
            try
            {
                btnBaslat.Enabled = true;
                kazanilanPara3 = Double.Parse(txtOran3.Text) * (Convert.ToDouble(nud3.Value));
            }
            catch (Exception)
            {
                MessageBox.Show(mesaj);
            }
           
        }
    }
}
