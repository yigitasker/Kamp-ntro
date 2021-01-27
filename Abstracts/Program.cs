using System;

namespace Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Class, ortak özellikli Class’lara Base(taban) Class olma görevini üstlenir. 
            // Örneğin siz projenizde birden fazla Class oluşturup kullanmak istiyorsunuz.
            // Ve oluşturacağınız Class’lar pek çok yönden ortak özellikleri içerisinde barındırıyor. 
            // İşte bu durumda Abstract Class kullanmanız kodunuzun daha sağlıklı olmasını sağlayacaktır.


            // TemelSinif, abstract bir sınıf olduğu için sadece kalıtım amaçlı(miras bırakma) kullanılabilir.
            // Metot_1(), TemelSinif‘dan türetilen sınıflara(TuretilmisSinif) doğrudan aktarılacaktır.
            // Bildirimi yapılmış olan Metot_2()‘nin ise türetilmiş sınıflar içerisinde tanımlanması(metot gövdesinin yazılması) gerekmektedir.


            // TuretilmisSınıf, TemelSinif‘dan türetildiği için TuretilmisSınıf içerisinde Metot_2()‘nin tanımlamasını yapmamız gerekmektedir.
            // Bu örnekten de anlaşılacağı üzere abstract sınıfları arayüzler(interface) gibi kullanabiliriz.


            //Abstract sınıf içerisinde bildirimi yapılmış olan metotları(Bkz: Metot_2()) türetilmiş sınıflar içerisinde tanımlayabilmemiz için
            // override anahtar sözcüğünü kullanmamız gerekmektedir.


            TuretilmisSinif turetilmisSinif = new TuretilmisSinif();

            turetilmisSinif.Metot_1();
            turetilmisSinif.Metot_2();


        }
    }

    public abstract class TemelSinif
    {
        public void Metot_1()
        {
            Console.WriteLine("Abstract sınıf içerisinde tanımlanmış metot.");
        }
        public abstract void Metot_2();
    }


    public class TuretilmisSinif : TemelSinif
    {
        public override void Metot_2()
        {
            Console.WriteLine("Türetilmiş sınıf içerisinde tanımlanmış metot.");
        }
    }











}
