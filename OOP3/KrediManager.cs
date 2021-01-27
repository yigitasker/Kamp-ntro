using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // eğer bir class değeri interface değerine kapsatılırsa, Kapsananlar interface bloğunda bulunan öğeleri barındırmak zorundadır.
    interface IKrediManager                      // interfacelerde,  base olan ifade(IKrediManager) için mirascı olan ifadeler(KonutKrediManager,TasıtKrediManager,İhtiyacKrediManager) kendi özelliklerine göre doldurmalıdır. 
    {                                            // interfaceleri birbirnin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. hepsinde Hesapla var ancak içlerindeki (İhtiyacKrediManager, TasıtKrediManager , KonutKrediManager ) kodlar farklılık gösterir. 
        void Hesapla();                          // referans numarası hangi Hesapla() için eşleşiyorsa onun için çalışır. => İhtiyacKrediManager, KonutKrediManager,...
        void BiseyYap();
    
    }
}
// bir interface oluşturulduğunda => içerisindeki operasyonlar, alternatif sistemler(İhtiyacKrediManager, KonutKrediManager,...) için şablon ve referans tutucu görevi görürler.
// interface = şablon, referans tutucu