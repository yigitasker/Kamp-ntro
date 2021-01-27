using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacKrediManager : IKrediManager    // sistem IKredimanager üzerinden referansını tuttuğu İhtiyacKrediManager içindeki Hesala() yı çalıştırıyor.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
