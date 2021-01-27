using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();

            Musteri1.Id = 1;
            Musteri1.Ad = "Pınar";
            Musteri1.Soyad = "Yıldız";

            MusteriManager Musterislemleri = new MusteriManager();

            Musterislemleri.MusteriEkle(Musteri1);


            
        }
    }
}
