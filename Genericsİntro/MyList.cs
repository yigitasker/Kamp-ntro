using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T>                 // T yerine istediğiniz yazabilrisn farketmez.Bu Tip te verileri class içinde kullanabileceğim örneğin string,int,bool,....
    {
        T[] items;                 //  items adında array(dizi) oluşturduk. Tipi = T
        
       
        public MyList()             // ctor, constructor
        {
            items = new T[0];        // yeni bir array oluşturup kullanmam için new'lemem gerekiyor bu durumdan dolayı constructor ı kullandık. yani  items bir adres bilgisi tutmuş oluyor. new = adres alma
        }

        public void Add(T item)         // T = string,int,bool...  sen ne değer gönderirsen item => parametre 
        {
            T[] tempArray = items;      // bildiğiniz gibi array larda eleman sayısı arttırdığımızda (aşağıda yaptığımız gibi) adres değişiyor bu durumdan dolayı eski adres bilgimi tempArray a tutturuyorum.
         
            items = new T[items.Length+1];       // dizinin eleman sayısnı bir arttırıyorum.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];                              // tempArray içerisne aldığım eski verilerimi items içerisine alıyorum.
            }

            items[items.Length - 1] = item;              // en son aşamada da  public void Add(T item) den gelen değerimi item da boş olan en son boşluğa ekledim.
        }

    }
}
