using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
              * İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
             */

            IKrediManager ihtiyacKrediManager2 = new İhtiyacKrediManager();
            
            IKrediManager konutKrediManager2 = new KonutKrediManager();
            
            IKrediManager tasitKrediManager2 = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager2,new DatabasaLoggerService());
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager2,tasitKrediManager2 };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
