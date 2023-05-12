using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            if (p.OGRAD != null && p.OGRSOYAD != null && p.OGRNUMARA != null && p.OGRSIFRE != null && p.OGRFOTO != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if(p >= 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }

            return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.OGRAD != null && p.OGRSOYAD != null && p.OGRNUMARA != null && p.OGRSIFRE != null && p.OGRFOTO != null && p.OGRID > 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
