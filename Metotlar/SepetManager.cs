using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager             
    {
        public void Ekle(Urun urun)         // pythonda ki def, parantez görüyorsanız bilinki orda bir metot çalışıyor. urun adında bir parametre gönderebilecez.
        {
            Console.WriteLine("Tebrikler, Sepete eklendi."+ urun.Adi);         // Urun veri tipinde olduğu için Adi çıkar.
        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti)              // yapılmaması gereken bir yöntemdir.
        {
            Console.WriteLine("Tebrikler, Sepete eklendi." + urunAdi);
        }
    }
}
