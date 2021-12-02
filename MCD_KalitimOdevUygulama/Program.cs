using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
            //B1.id = 1; girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum...
            B1.marka = "Lenovo";
            B1.model = "z50";
            B1.alisFiyat = 1000;
            B1.satisFiyat = 1500;
            B1.kampanyaFiyat = 1000;
            B1.barkod = "1234567890";
            SanalDataBase.yeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();
           B2.marka = "Lenovo";
           B2.model = "z50";
           B2.alisFiyat = 1000;
           B2.satisFiyat = 1500;
           B2.kampanyaFiyat = 1000;
           B2.barkod = "1234567890";
            SanalDataBase.yeniUrunEkle(B2);

            SanalDataBase.yazdir();
            Console.ReadKey();



        }
    }
}
