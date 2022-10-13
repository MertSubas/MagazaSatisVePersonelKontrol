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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
           
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("DEPARTMANLIST", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader rt = komut.ExecuteReader();
                   
            while (rt.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Personelid=int.Parse(rt["PERSONELID"].ToString());
                ent.Personelad=rt["PERSONELAD"].ToString();
                ent.Personelsoyad=rt["PERSONELSOYAD"].ToString() ;
                ent.Personeldep = rt["departmanad"].ToString();
                ent.Personelmaas=decimal.Parse(rt["PERSONELMAAS"].ToString()) ;
                
                ent.Personelfotograf = rt["PERSONELFOTOGRAF"].ToString();
                degerler.Add(ent);

            }
            rt.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut4 = new SqlCommand("insert into TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) values (@P1,@P2,@P3,@P4)", Baglanti.bgl);

            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", p.Personelad);
            komut4.Parameters.AddWithValue("@p2", p.Personelsoyad);
            komut4.Parameters.AddWithValue("@p3", p.Personeldepartman);
            komut4.Parameters.AddWithValue("@p4", p.Personelmaas);


            return komut4.ExecuteNonQuery();

        }
    }
}
