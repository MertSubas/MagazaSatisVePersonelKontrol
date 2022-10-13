using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinesLogicLayer
{
    public class BLLUrun
    {

        public static List<EntitUrun> BLLUrunListesi()
        {
            return DALUrun.UrunListesi();
        }
        public static int BLLUrunEkle(EntitUrun p)
        {
            if (p.Urunad != " " && p.Urunfiyat != 0 && p.Urunadet != 0 && p.Urunfiyat >= 1)
            {
                return DALUrun.UrunEkle(p);
            }
            else
            {
                return -1;
            }




        }

    }

}
