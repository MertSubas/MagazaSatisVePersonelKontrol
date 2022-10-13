using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALSatıs
    {
        public static List<EntitySatis> SatısListesi()

        {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            //ÜST TARAFTA YAZDIĞIMIZ ŞEY TABLODAN DEĞİL PROSEDURDEN DEĞER ALMAMIZI SAĞLIYOR. 
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.Satisid = int.Parse(dr["SATISID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
                //ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Musteriad = dr["MUSTERI"].ToString();
                ent.Fiyat = decimal.Parse(dr["TUTAR"].ToString());
                //satıslar prosedurunde AS oalrak aldıgın şeyi yazıyorsun
                //ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
        public static int SatışEkle(EntitySatis p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLSATIS (URUN,PERSONEL,TUTAR,MUSTERI) values (@P1,@P2,@P3,@P4)", Baglanti.bgl);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Urun);
            komut2.Parameters.AddWithValue("@P2", p.Personel);
            komut2.Parameters.AddWithValue("@P3", p.Fiyat);
            komut2.Parameters.AddWithValue("@P4", p.Musteri);


            return komut2.ExecuteNonQuery();

        }
    }
}
