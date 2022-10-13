using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;




namespace DataAccessLayer
{
    public class DALUrun
    {
        public static List<EntitUrun> UrunListesi()
        {
            List<EntitUrun> degerler = new List<EntitUrun>();

            SqlCommand komut = new SqlCommand("Select *from TBLURUN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitUrun ent = new EntitUrun();
                ent.Urunid = byte.Parse(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                ent.Urunadet = int.Parse(dr["URUNADET"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int UrunEkle(EntitUrun p)
        {
            SqlCommand komut3 = new SqlCommand("insert into TBLURUN (URUNAD,URUNFIYAT,URUNADET) VALUES (@p1,@p2,@P3)", Baglanti.bgl);

            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p.Urunad);
            komut3.Parameters.AddWithValue("@p2", p.Urunfiyat);
            komut3.Parameters.AddWithValue("@p3", p.Urunadet);


            return komut3.ExecuteNonQuery();

        }
    }
}
