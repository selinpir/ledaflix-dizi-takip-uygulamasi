using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eheh
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        Class1 Bgl = new Class1();
        private void Kayitbtn_Click(object sender, EventArgs e)
        {
            // sınıf çagırma
           
            SqlCommand komut = new SqlCommand("insert into kullanicilarimizInfo (adSoyad,kullaniciAdi,sifre,cinsiyet,email) values(@p1,@p2,@p3,@p4,@p5)", Bgl.selinbgl());

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            //adSoyad @p1
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            //kullaniciAdi @p2
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            //sifre @p3
            komut.Parameters.AddWithValue("@p5", textBox4.Text);
            //email @p5
            komut.Parameters.AddWithValue("@p4", comboBox1.Text);
            //cinsiyet @p4 --combobox



            // captcha
            string kullaniciGirdisi = textBox5.Text;
            string olusturulanKod = label8.Text;

            if (kullaniciGirdisi == olusturulanKod)
            {
                MessageBox.Show("Doğru kod! Kayıt Onaylandı.Şifreniz :" + textBox3.Text);
                Anasf anasf = new Anasf();
                anasf.Kad = textBox2.Text; //3
                anasf.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış kod! Lütfen tekrar deneyin.");
                Kayit Kayit = new Kayit();
                Kayit.Show();
                this.Hide();
            }

            komut.ExecuteNonQuery();
            Bgl.selinbgl().Close();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

            // dogrulama
            string[] sembol1 = { "s", "e", "i", "n", "P", "R", "M", "g", "f", "x" };
            string[] sembol2 = { "*", "-", "+", "/", "@", "#" };
            Random r = new Random();
            int a1, a2, a3;
            a1 = r.Next(0, sembol1.Length);
            a2 = r.Next(0, sembol2.Length);
            a3 = r.Next(0, 10);
            label8.Text = sembol1[a1].ToString() + sembol2[a2].ToString() + a3.ToString();
            //
            // foto=cinsiyet
            PictureBox2.Visible = false;
            PictureBox3.Visible = false;
            PictureBox4.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //secime göre fotoğraf
            string cinsiyetsec = comboBox1.SelectedItem.ToString(); // cinsiyet seç
            if (cinsiyetsec == "ERKEK")
            {
                PictureBox2.Visible = true;
                PictureBox3.Visible = false;
                PictureBox4.Visible = false;
            }
            else if (cinsiyetsec == "KADIN")
            {
                PictureBox2.Visible = false;
                PictureBox3.Visible = true;
                PictureBox4.Visible = false;
            }
            else if (cinsiyetsec == "DİĞER")
            {
                PictureBox2.Visible = false;
                PictureBox3.Visible = false;
                PictureBox4.Visible = true;
            }
            else
            {
                PictureBox2.Visible = false;
                PictureBox3.Visible = false;
                PictureBox4.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris Giris = new Giris();
            Giris.Show();
            this.Hide();
        }
    }
}
