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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) //burada e bize KeyEventArgs'i verir.
            {
                case Keys.Left:
                    pbTop.Left -= 5;
                    break;
                case Keys.Right:
                    pbTop.Left += 5;
                    break;
                case Keys.Up:
                    pbTop.Top -= 5;
                    break;
                case Keys.Down:
                    pbTop.Top += 5;
                    break;
                case Keys.D:
                    timer1.Start();
                    break;
                case Keys.S:
                    timer1.Stop();
                    break;
                case Keys.T:
                    timer1.Start();
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTop.Left += 5; //d harfine basildiginda saga dogru gidiyor. Formun sag tarafina carpip sola gitmeye devam etsin.
            pbTop.Top += 5; //t harfine basildiginda yukari dogru gidiyor. Formun ust tarafina carpip asagi gitmeye devam etsin.
        }
    }
}
