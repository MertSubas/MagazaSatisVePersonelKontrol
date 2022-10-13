using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinesLogicLayer
{
    public  class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriListesi()
        {
            return DALMusteri.MusteriListesi();
        }
        public static int BLLMusteriEkle(EntityMusteri p)
        {
            if (p.Musteriad != " " && p.Musterisoyad != " " )
            {
                return DALMusteri.MusteriEkle(p);
            }
            else
            {
                return -1;
            }




        }
        public static bool BLLMusteriSil(int par)

        {
            if (par != null)
            {
                return DALMusteri.MusteriSil(par);
            }
            return false;
        }

        public static List<EntityMusteri> BLLMusteriGetir(int p)
        {
            return DALMusteri.Musterigetir(p);
        }

        public static bool MusteriGuncelle(EntityMusteri p)
        {
            if(p.Musteriad!=" " && p.Musterisoyad!=" ")
            {
                return DALMusteri.MusteriGüncelle(p);
            }
            return false;
        }
        
    }
   
}
  