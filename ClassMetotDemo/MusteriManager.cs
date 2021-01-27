using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri Musteri)
        {
            Console.WriteLine("Sisteme eklenen müşteri = "+"İd : "+ + Musteri.Id + " = " + Musteri.Ad + " " + Musteri.Soyad );
        
        }
    }
}
