using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_KalitimOdevUygulama
{
    public static class SanalDataBase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }

        public static bool dbBarkodKontrol(string dbbarkod)
        {
            bool kontrolIslemi = false;
            if (db!=null && db.Count>0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    BaseClass bc = (BaseClass)db[i];
                    if (bc.barkod == dbbarkod)
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }

        public static void yazdir()
        {
            foreach (Bilgisayar item in SanalDataBase.db)
            {
                Console.WriteLine("Marka: " + item.marka + " model: " + item.model + " işlemci: " + item.islemci + " alış fiyatı: " + item.alisFiyat + " satış fiyatı: " + item.satisFiyat + " kampanya fiyatı: " + item.kampanyaFiyat + " barkod: " + item.barkod);
            }

        }
    }

}
