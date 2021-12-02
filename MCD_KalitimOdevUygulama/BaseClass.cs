using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
   public class BaseClass
    {
        public static int sayac = 1; //İlk oluştuğu zaman 1 değerini otomatik olarak alsın.

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                 // bir sayac içerisindeki değerden faydalanmak isitiyoruz.
                 // _id = sayac
                 //sayac += 1;
                 //Nedeni set alanı private olarak işaretlendi...
            }
        }

        public BaseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslem = SanalDataBase.dbBarkodKontrol(value);
                if (!kontrolIslem)//Değeri sanalDataBase içerisinde bulamadık!
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        }

        public DateTime olusturmaTarih { get; set; }

        public int olusturanKullanıcı { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }
        public bool silindi { get; set; }


    }
}
