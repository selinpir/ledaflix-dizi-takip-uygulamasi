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
    public partial class Diziayrinti : Form
    {
       

        public Diziayrinti()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection();
      
        public int diziID { get; private set; }
        public int diziadi { get; private set; }
        public int dizituru1 { get; private set; }
        public int bolumsayi { get; private set; }
        public int sezonsayi { get; private set; }
        public int dizidurumu { get; private set; }
        public int aciklama { get; private set; }

        private void Diziayrinti_Load(object sender, EventArgs e)
        {
            Listele(0);

            Baglanti = new SqlConnection("Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True");
            Baglanti.Open();

            SqlCommand KomutA = new SqlCommand();
          //  Baglanti.Open();
            KomutA.CommandText = "SELECT * FROM diziInfo";
            KomutA.Connection = Baglanti;
          
            DataTable Tablo= new DataTable();
            SqlDataAdapter Adap= new SqlDataAdapter(KomutA);
          
            Adap.Fill(Tablo);

            TID.Text = Tablo.Rows[0]["diziID"].ToString();
            TAD.Text = Tablo.Rows[1]["diziadi"].ToString();
            TTÜR.Text = Tablo.Rows[6]["dizituru1"].ToString();
            TBÖL.Text = Tablo.Rows[3]["bolumsayi"].ToString();
            TSEZ.Text = Tablo.Rows[2]["sezonsayi"].ToString();
            TDUR.Text = Tablo.Rows[4]["dizidurumu"].ToString();
            richTextBox1.Text = Tablo.Rows[9]["aciklama"].ToString();
            Baglanti.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Baglanti = new SqlConnection("Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True");
            Baglanti.Open();

            SqlCommand KomutA = new SqlCommand();
            //  Baglanti.Open();
            KomutA.CommandText = "SELECT * FROM diziInfo";
            KomutA.Connection = Baglanti;

            DataTable Tablo = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter(KomutA);

            Adap.Fill(Tablo);

            TID.Text = Tablo.Rows[Tablo.Rows.Count]["diziID"].ToString();
            TAD.Text = Tablo.Rows[Tablo.Rows.Count]["diziadi"].ToString();
            TTÜR.Text = Tablo.Rows[Tablo.Rows.Count]["dizituru1"].ToString();
            TBÖL.Text = Tablo.Rows[Tablo.Rows.Count]["bolumsayi"].ToString();
            TSEZ.Text = Tablo.Rows[Tablo.Rows.Count]["sezonsayi"].ToString();
            TDUR.Text = Tablo.Rows[Tablo.Rows.Count]["dizidurumu"].ToString(); 
            richTextBox1.Text = Tablo.Rows[Tablo.Rows.Count]["aciklama"].ToString();

            Baglanti.Close();
        }

        private void Listele(int sayac)
        {
            Baglanti = new SqlConnection("Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True");
            Baglanti.Open();

            SqlCommand KomutA = new SqlCommand();
            //  Baglanti.Open();
            KomutA.CommandText = "SELECT * FROM diziInfo";
            KomutA.Connection = Baglanti;

            DataTable Tablo = new DataTable();
            SqlDataAdapter Adap = new SqlDataAdapter(KomutA);

            Adap.Fill(Tablo);

            TID.Text = Tablo.Rows[sayac]["diziID"].ToString();
            TAD.Text = Tablo.Rows[sayac]["diziadi"].ToString();
            TTÜR.Text = Tablo.Rows[sayac]["dizituru1"].ToString();
            TBÖL.Text = Tablo.Rows[sayac]["bolumsayi"].ToString();
            TSEZ.Text = Tablo.Rows[sayac]["sezonsayi"].ToString();
            TDUR.Text = Tablo.Rows[sayac]["dizidurumu"].ToString();
            richTextBox1.Text = Tablo.Rows[sayac]["aciklama"].ToString();
            Baglanti.Close();
        }

        int sayici = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {      
            try
            {

                sayici++;
                Listele(sayici);
            }

            catch
            {
                MessageBox.Show("Sonraki kayıt yoktur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {               
                 sayici--;
                Listele(sayici);
            }

            catch
            {
                MessageBox.Show("Önceki kayıt yoktur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Anasf Anasf=new Anasf();
            Anasf.Show();
            this.Hide();
        }

        private void Dbutton2_Click(object sender, EventArgs e)
        {
            Cikis Cikis=new Cikis();
            Cikis.Show();
            this.Hide();
        }
    }       
}
            