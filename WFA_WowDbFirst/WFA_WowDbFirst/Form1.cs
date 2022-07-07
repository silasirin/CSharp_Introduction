using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_WowDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WowDbEntities db = new WowDbEntities();
        private void btnSave_Click(object sender, EventArgs e)
        {
            AddCharacter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Skill s in db.Skills)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.Race.RaceName.ToString();
                lvi.SubItems.Add(s.Class.ClassName);
                lvi.SubItems.Add(s.SkillName);
                lvi.SubItems.Add(s.SkillPower.ToString());
               
                listView1.Items.Add(lvi);
            }
        }

        private void AddCharacter()
        {
            try
            {
                Race r = new Race();
                Class c = new Class();
                Skill s = new Skill();
                r.RaceName = txtRace.Text;
                c.ClassName=txtClass.Text;
                s.SkillName = txtSkillName.Text;
                s.SkillPower = Convert.ToInt32(nudSkillPower.Value);
                db.Races.Add(r);
                db.Classes.Add(c);
                db.Skills.Add(s);

                db.SaveChanges();

                MessageBox.Show("Karakter eklendi!");
                GetCharacters();
                txtRace.Text = "";
                txtClass.Text = "";
                txtSkillName.Text = "";
                nudSkillPower.Value = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetCharacters()
        {
            listView1.Items.Clear();
            foreach (Skill s in db.Skills)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.Race.RaceName.ToString();
                lvi.SubItems.Add(s.Class.ClassName);
                lvi.SubItems.Add(s.SkillName);
                lvi.SubItems.Add(s.SkillPower.ToString());

                listView1.Items.Add(lvi);
            }
        }
    }
}
