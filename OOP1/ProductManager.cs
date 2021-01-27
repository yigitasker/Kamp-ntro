using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // Encapsulation
        public void Add(Product product)                               // Product türünde bir parametre istiyoruz.
        {
            // product.ProductName = "Kamera";

            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }













        //public int Topla(int sayi1, int sayi2)                      // int kullanarak return kullanılabilir ve çıkan değerimiz başka bir yerde kullanabiliyoruz. dikkat edilmesi gereken çıkan değer int olmak zorunda çıktımı string alamam.
        //{
        //    return sayi1 + sayi2;                                   // int toplamaSonucu = productManager.Topla(3,6)      => sonucumuz artık toplamaSonucu'nun içinde
        //}


        //public void Topla2(int sayi1, int sayi2)                     // void de return yapamazsın işlemleri dışarda kullanamazsınız.
        //{
        //    Console.WriteLine(sayi1 + sayi2);                        // productManager.Topla2(3,6)
        //}



        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}

    }
}
