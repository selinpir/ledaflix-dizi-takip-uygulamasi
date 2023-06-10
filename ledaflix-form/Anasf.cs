using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eheh
{
    public partial class Anasf : Form
    {
        public Anasf()
        {
            InitializeComponent();
        }
        public string Kad;//1
        private void Anasf_Load(object sender, EventArgs e)
        {
            label1.Text = Kad;//2
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dbutton1_Click(object sender, EventArgs e)
        {
            DiziListesi DiziListesi = new DiziListesi();
            DiziListesi.Show();
            this.Hide();
        }

        private void Dbutton4_Click(object sender, EventArgs e)
        {

        }

        private void Dbutton3_Click(object sender, EventArgs e)
        {

        }

        private void Dbutton2_Click(object sender, EventArgs e)
        {
            Cikis Cikis=new Cikis();
            Cikis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diziayrinti Diziayrinti=new Diziayrinti();
            Diziayrinti.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
