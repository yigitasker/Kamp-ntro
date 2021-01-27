using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();

            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "8234289234";
            //musteri1.MusteriNo = "12723";
            //musteri1.SirketAdi = "?";                      // müşterinin şirket adı olabilirmi

            // Gerçek Müşteri - Tüzel Müşteri            => birbirlerinin yerine kullanılmamalı. Yukardaki örnekteki gibi 
            // SOLİD 






            // Engin demir

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demir";
            musteri1.TcNo = "123456789";


            // Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "54738";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "23423424";



            // Musteri classı hem GercekMusteri nın referans numarasını tutabiliyor hemde TuzelMusterinin referansını tutabiliyor. çünkü onların ebeveyni. 

            Musteri musteri3 = new GercekMusteri();        // new => bellekte referans no,  başka bir deyişle inheritance ile birlikte Müşteri class ı GerçekMusteri class na ait olan referans numaralarını tutabilir. stack heap ten 
            Musteri musteri4 = new TuzelMusteri();         // Class türü Musteri, tutulan referans türü TuzelMusteri



            MusteriManager musteriManager = new MusteriManager();

            // aşağıdakilerin hepsi sorunsuz çalışır.
            musteriManager.Add(musteri1);                   // GercekKisi mırasçı, Musteri ebeveyn => miraşcılar ebeveynlerinin özelliklerini alırlar.
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);







        }
    }
}
