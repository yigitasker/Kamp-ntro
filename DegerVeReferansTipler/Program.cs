using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;                // sayi1 in DEĞERİ 10 
            int sayi2 = 30;                // sayi2 in DEĞERİ 30

            sayi1 = sayi2;                // sayi1 in değeri = sayi2 nin değeri => yani sadece değeri. sayi2 ile bir alakamız yok. yani sayi1 kendi değerini kendi değiştirebilir.

            sayi2 = 65;                   // sayi1, sayi2 nin o anki değerine eşitlendi(yukarıda). sayi1 bu işlemden etkilenmez. 

            // sayi1 = 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            int[] sayilar3 = new int[0];                          // sıfır elemanlı bir array tanımlamış oldum
            int[] sayilar4;                                       // referans numarası tutmayan sadece stack kısmında oluşturulmuş  bir array, new lemek veya referansını tutabileceği  bir değere eşitlenmelidir.


            sayilar1 = sayilar2;                 // sayi1, sayi2 nin adres bilgisini alıyor. ve böylelikle sayi1 için eski adresi silinir tabi adrste tutulan bilgilerle beraber => {10 ,20, 30}
            sayilar2[0] = 999;

            // sayilar1[0] = 999               // aynı adres bilgilerini almalarından dolayı değişikler sayi1 ve sayi2 içinde aynı gerçekleşir.
            // sayilar2[1] = 200



            // int, decimal, float, double, bool = değer tip = anlık olarak eşitleme gerçekleşiyor. => STACK

            // array(dizi), class, interpace = referans tip = adresleme gerçekleşiyor. yani adresler eşitleniyor. => HEAP





            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirtName = "Yiğit";

            person2 = person1;                        // referance tip. person2 ninde FirstName i Yiğit olur. person2 artık person1 in adres bilgisini tutuyor.
            person1.FirtName = "Derin";               // person1 ve person2 içinde FirstName değeri Derin olarak değişir.(adreslemeden dolayı)

            Console.WriteLine(person2.FirtName);



            Customer customer = new Customer();

            customer.FirtName = "Pınar";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();

            employee.FirtName = "Veli";


            // customer = employee              aynı türde olmayan ifadeleri birbirine eşitleyemezsin int = string yapamadığın gibi

            Person person3 = customer;          // burda problem çıkmadı. çünkü  aşağıda Costumer aynı zamanda bir Person demiştik. adres eşitlemesi yaptık.
            Console.WriteLine(person3.FirtName);


            // Boxing

            Console.WriteLine(((Customer)person3).CreditCardNumber);           // person3 üzerinden kart bilgisine ulaşmamın sağladı. Belirtilen tip(Customer) çerçevesinde boxing yapıldı.


            PersonManager personManager = new PersonManager();

            // add fonksiyonuna üç tipte veriyi gönderebiliyorum.
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);

        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }

    }


    // base class => Person temel class değerimiz Customer kapsanan class değeri
    class Customer:Person                               // Customer aynı zamanda bir Person dır demiş olduk. Başka bir deyişle Person için tanımlanan özellikler Customer içinde de geçerlidir.
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {

        public void Add(Person person)    // buraya gönderilince çalışacak tipler = Person,Customer,Emloyee
        {
            Console.WriteLine(person.FirtName);
        }

    } 

}
