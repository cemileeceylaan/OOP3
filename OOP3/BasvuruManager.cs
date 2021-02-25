using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            // kaç tane kredinin hesaplanması gerektiğni bilemeyeceğimiz için List kullandık.

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
