using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };         // bu şekilde de yazılabilir.

            ProductManager productManager = new ProductManager();               // productManager türünde productManager isminde obje tanımlamış olduk.

            productManager.Add(product1);



           








            // Console.WriteLine(product1.ProductName);              // Kamera cevabını alırız. çünkü referans tip 


            //int sayi = 100;                                   
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);                         // 100 cevabını alırız. Değer tip. ilk eşitlemeden sonra bağlantı kopuyor. 



            /// int, double, bool,,,  değer tip
            /// diziler, class, abstract, interface... referans tip 








        }
    }
}
