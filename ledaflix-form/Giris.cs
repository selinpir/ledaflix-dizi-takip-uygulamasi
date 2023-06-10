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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eheh
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Class1 Bgl = new Class1();

      

        private void Girisbtn_Click(object sender, EventArgs e)
        {
            // giriş yap
            SqlCommand komut2 = new SqlCommand("Select * from kullanicilarimizInfo where kullaniciAdi = @p1 and sifre = @p2 ",Bgl.selinbgl());


            komut2.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut2.Parameters.AddWithValue("@p2", TextBox2.Text);

            // giriş kontrol 
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                Anasf Anasf = new Anasf
                {
                    Kad = TextBox1.Text
                };
                Anasf.Show();
                this.Hide();
                MessageBox.Show("Giriş Başarılı.");

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!Tekrar Deneyiniz.");

            }
        
            dr.Close();
            Bgl.selinbgl().Close();
            
        }
   
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit Kayit=new Kayit();
            Kayit.Show();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
