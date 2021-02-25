using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            // basvuran bilgilerini degerlendirme
            krediManager.Hesapla(); // basvuru krediden bağımsız hale geldi.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
