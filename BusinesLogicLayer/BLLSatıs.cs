using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinesLogicLayer
{
    public class BLLSatıs
    {
        public static List<EntitySatis> BLLSATISLISTESI()
        {
            return DALSatıs.SatısListesi();
        }
        public static int BLLSatıslEkle(EntitySatis p)
        {
            if (p.Fiyat != 0 )
            {
                return DALSatıs.SatışEkle(p);
            }
            else
            {
                return -1;
            }




        }
    }

}
