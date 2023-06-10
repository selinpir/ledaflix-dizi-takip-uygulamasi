using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eheh
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Giris Giris = new Giris();
            Giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit Kayit = new Kayit();
            Kayit.Show();
            this.Hide();
        }

        private void Baslangic_Load(object sender, EventArgs e)
        {

        }
    }
}
