using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TopSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hizYatay = 30;
        int hizDikey = 30;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            #region aciklama
            //MessageBox.Show("aktif");
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(e.KeyCode.ToString());

            //bool isA = e.KeyCode == Keys.A;
            //if (isA)
            //{
            //    MessageBox.Show("A tuşu aktif");
            //}

            //if (e.KeyCode == Keys.Left)
            //{
            //    pbTop.Left -= 5;
            //} 
            //KeyUp: parmagi tustan cektigin anda calisir
            //KeyDown: basarken calisir
            //KeyPress: basinca calisir

            #endregion

            switch (e.KeyCode)
            {
                case Keys.Left:
                    pbBall.Left -= hizYatay;
                    break;
                case Keys.Right:
                    pbBall.Left += hizYatay;
                    break;

                case Keys.Up:
                    pbBall.Top -= hizDikey;
                    break;

                case Keys.Down:
                    pbBall.Top += hizDikey; 
                    break;

                case Keys.D:
                    timer1.Start();
                    break;
                case Keys.T:
                    timer2.Start();
                    break;
                case Keys.S:
                    timer1.Stop();
                    timer2.Stop();
                    break;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBall.Left += hizYatay;
            if (pbBall.Right>=this.Width)
            {
                hizYatay -= 30;
            }
            else if (pbBall.Left<=0)
            {
                hizYatay += 30;
            }           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbBall.Top += hizDikey;
            
            if (pbBall.Bottom >= this.Height)
            {
                hizDikey -= 30;
            }
            else if (pbBall.Top <= 0)
            {
                hizDikey += 30;
            }
        }



    }
}
