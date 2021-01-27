using System;
using System.Collections.Generic;

namespace Genericsİntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();            // Lİst dediğimiz olayda bir class seviyesinde bir yapıdır. ve içini methodlarla doldurmuşlar List ile beraber liste yapısı üzerinde işlemler yapabiliyoruz. sehirler yapısı bir liste artık. ve ona ait özellikleri üzerinde barındaracak.
            sehirler.Add("Yiğit");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Pınar");
            Console.WriteLine(sehirler2.Count);


        }
    }


    class MyList<T>                         // Generic class olduğunu belirttim. => <>,  collections = listeler
    {
        T[] _array;
        T[] _tempArray;                     // eski adreste kalan elemanları tutacak.
        public MyList()
        {
            _array = new T[0];             // MyList<string> sehirler2 = new MyList<string>(); bu işlemin sonucunda burası çalışıyor(constructor). ve bunu bir obje(sehirler2) için bir kere yaptığımızdan dolayı constructor bölümü birdaha çalışmaz. sıfır elemanlı bir array yani dizi oluşturmuş oldum. array oluşturulurken eleman sayısı belirtilmelidr en başta. burdada sıfır elemanlı bir array oluşturuduğumuz belirttk.
        }


        public void Add(T item)
        {
            _tempArray = _array;                              // tempArray, array in adresini aldı. bunu yapmamın amacı aşağıda new yaptığımda anda array için adres bilgisi değişecek ve bilgiler kaybolacak. bunun olmaması kaybolcak olan adresi tempArray e tutturuyorum.
            _array = new T[_array.Length + 1];                // ekleme işlemi yaptığımdan dolayı önce array in içini say ona bir ekle dedik. çünkü Add ile bir eleman ekleyebileceğiz. ve new ledik

            for (int i = 0; i < _tempArray.Length; i++)      // eski adresi tutan temparray içindeki bilgileri array in içine eşitliyorum.
            {
                _array[i] = _tempArray[i];                   
            }

            _array[_array.Length - 1] = item;               // en son işlemde de Add den gelen elemanı ekledim.
                
        }

        public int Count
        {
            get { return _array.Length; }                            // tanımlamış olduğum array in eleman sayısını vericek =>  T[] _array;
        }
    }
}
