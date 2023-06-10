using System;
using System.Data.SqlClient;

namespace eheh
{
    internal class Class1
    {
        public Class1()
        {
        }

        internal SqlConnection Baglanti()
        {
            // baglanti
            throw new NotImplementedException();
        }
        public SqlConnection selinbgl() //selinbgl metod
        {
            SqlConnection Baglan = new SqlConnection("Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True");
            Baglan.Open();
            return Baglan;
            

        }
     

        public static SqlConnection bgl = new SqlConnection("Data Source=SELINPIR;Initial Catalog=db_leda_oop;Integrated Security=True");

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}
