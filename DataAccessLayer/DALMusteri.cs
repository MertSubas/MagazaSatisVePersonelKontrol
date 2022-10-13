using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()

        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select *From TBLMUSTERI", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int MusteriEkle(EntityMusteri p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) VALUES (@p1,@p2)", Baglanti.bgl);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Musteriad);
            komut2.Parameters.AddWithValue("@p2", p.Musterisoyad);


            return komut2.ExecuteNonQuery();

        }

        public static bool MusteriSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TBLMUSTERI WHERE MUSTERIID=@P1", Baglanti.bgl);

            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityMusteri> Musterigetir(int id)

        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select *From TBLMUSTERI WHERE MUSTERIID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                //ent.Musteriid = int.Parse(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool MusteriGüncelle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBLMUSTERI SET MUSTERIAD=@P1,MUSTERISOYAD=@P2 WHERE MUSTERIID=@P3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Musteriad);
            komut.Parameters.AddWithValue("@P2", p.Musterisoyad);
            komut.Parameters.AddWithValue("@P3", p.Musteriid);
            return komut.ExecuteNonQuery() > 0 ;
        }
    }

}
