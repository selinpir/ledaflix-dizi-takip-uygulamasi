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
    

    public partial class DiziListesi : Form
    {    
        
        SqlConnection Baglanti;
        SqlCommand Komut;
        SqlDataAdapter Da;
        void DiziGetir()
        {
            Baglanti = new SqlConnection("Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True");
            // "Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True"
            Baglanti.Open();
            Da = new SqlDataAdapter("SELECT * FROM diziInfo", Baglanti);
            DataTable Tablo = new DataTable();
            Da.Fill(Tablo);
            dataGridView1.DataSource=Tablo;
            Baglanti.Close();
        }

        public DiziListesi()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {       
            DiziGetir();
        }
          
        private void m(object sender, EventArgs e)
        {
           
        }
        //diziekle
        private void Button4_Click(object sender, EventArgs e)

        {

            try
            {
                string Sorgu = "INSERT INTO diziInfo (diziadi,sezonsayi,bolumsayi,dizidurumu,izlemedurumun,dizituru1,hangisezon,hangibolum) VALUES(@diziadi,@sezonsayi,@bolumsayi,@dizidurumu,@izlemedurumun,@dizituru1,@hangisezon,@hangibolum)";

              
                Komut = new SqlCommand(Sorgu, Baglanti);
    
                Komut.Parameters.AddWithValue("@diziID", Convert.ToInt32(TID.Text));
               

                Komut.Parameters.AddWithValue("@diziadi", TAD.Text); //diziadi
                Komut.Parameters.AddWithValue("@dizituru1", TTÜR.Text); //dizituru1
                Komut.Parameters.AddWithValue("@bolumsayi", Convert.ToInt32(TBÖL.Text)); //bolumsayi
                Komut.Parameters.AddWithValue("@sezonsayi", Convert.ToInt32(TSEZ.Text)); //sezonsayi
                Komut.Parameters.AddWithValue("@dizidurumu", TDUR.Text); //dizidurumu
                Komut.Parameters.AddWithValue("@izlemedurumun", TDURMA.Text); //izlemedurumun
                Komut.Parameters.AddWithValue("@hangisezon", Convert.ToInt32(textBox1.Text)); //hangisezon
                Komut.Parameters.AddWithValue("@hangibolum", Convert.ToInt32(textBox2.Text)); //hangibolum
                
                Baglanti.Open();
                Komut.ExecuteNonQuery();
                Baglanti.Close();
                DiziGetir();
            }
            catch 
            {
                MessageBox.Show("Bir Hata Oluştu.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //sil
        private void Button5_Click(object sender, EventArgs e)
        {
            string Sorgu = "DELETE FROM diziInfo WHERE diziID=@diziID ";          
          
            Komut = new SqlCommand(Sorgu, Baglanti);
            Komut.Parameters.AddWithValue("@diziID", Convert.ToInt32(TID.Text));
            Komut.Parameters.AddWithValue("@diziadi", TAD.Text); //diziadi
            Komut.Parameters.AddWithValue("@dizituru1", TTÜR.Text); //dizituru1
            Komut.Parameters.AddWithValue("@bolumsayi",Convert.ToInt32( TBÖL.Text)); //bolumsayi
            Komut.Parameters.AddWithValue("@sezonsayi", Convert.ToInt32(TSEZ.Text)); //sezonsayi
            Komut.Parameters.AddWithValue("@dizidurumu", TDUR.Text); //dizidurumu
            Komut.Parameters.AddWithValue("@izlemedurumun", TDURMA.Text); //izlemedurumun
            Komut.Parameters.AddWithValue("@hangisezon", Convert.ToInt32( textBox1.Text)); //hangisezon
            Komut.Parameters.AddWithValue("@hangibolum", Convert.ToInt32 (textBox2.Text)); //hangibolum
       
            Baglanti.Open();
            Komut.ExecuteNonQuery();
            Baglanti.Close();
            DiziGetir();
        }
        //güncelle
        private void Button6_Click(object sender, EventArgs e)
        {
            string Sorgu = "UPDATE diziInfo SET hangisezon=@hangisezon,hangibolum=@hangibolum,izlemedurumun=@izlemedurumun WHERE diziID=@diziID ";
            
            Komut = new SqlCommand(Sorgu, Baglanti);

            Komut.Parameters.AddWithValue("@diziID", Convert.ToInt32(TID.Text));
            Komut.Parameters.AddWithValue("@hangisezon", Convert.ToInt32(textBox1.Text)); //hangisezon
            Komut.Parameters.AddWithValue("@hangibolum", Convert.ToInt32(textBox2.Text)); //hangibolum
            Komut.Parameters.AddWithValue("@izlemedurumun", TDURMA.Text); //izlemedurumun
            Baglanti.Open();
            Komut.ExecuteNonQuery();
            Baglanti.Close();
            DiziGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diziayrinti Diziayrinti=new Diziayrinti();
            Diziayrinti.Show();
            this.Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Anasf Anasf = new Anasf();
            Anasf.Show();
            this.Hide();

        }



     

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            TID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TTÜR.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TBÖL.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TSEZ.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TDUR.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TDURMA.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


          
        }

        

    

    }
   }

