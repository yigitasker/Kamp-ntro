using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)                 // IKrediManager hepsinin referansını tutabildiğimden dolayı bütün mirasçılar buraya gönderilebilir. örneğin tasıtKredisi yolladın //IKrediManager krediManager// kısmı artık ona göre refrans tutar
        {
            // Başvuran bilgilerini değerlendirme
            // 
            //KonutKrediManager konutKrediManager = new KonutKrediManager();               // tüm başvurular sadece KonutKrediManager a bağlı kaldı.
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();                                                      // örneğin KonutKrediManager gönderilrse  KonutKrediManager ın Hesapla kısmı çalışır.
            loggerService.Log();
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)               // birden fazla bilgi göndermek istedim. Türüde IKrediManager olsun.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();                                                      // herbir kredi seçeneğimiz için Hesapla metodu türe(ihtiyacKrediManager, tasıtKrediManager) göre çalışacak
            }
        }
    }
}
