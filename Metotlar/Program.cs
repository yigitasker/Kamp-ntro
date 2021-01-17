using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();           // Urun class ına ait bir obje oluşturuyoruz(urun1) 

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
              
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };          // Urun veri tipine ait bir dizi oluşturuyorum. Yani dizinin içeriisndeki verilerin tipi sadece Urun classına ait veriler olacak.

            foreach (Urun urun in urunler)                       // baştaki Urun veri tipini ifade etmektedir. type safe -- tip güvenliği
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");

            }


            Console.WriteLine("--------------Metotlar---------------");

            // instance - class örneği oluşturmak.
            // encapsulation

            SepetManager sepetManager = new SepetManager();              // SepetManager class ına ait obje oluşturdum.

            sepetManager.Ekle(urun1);                // ve obje üzerinden metot çağırdım. ekle metoduna veri yolladım.
            sepetManager.Ekle(urun2);




            sepetManager.Ekle2("Armut", "Yeşil", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır ", 12, 8);






        }
    }
}

