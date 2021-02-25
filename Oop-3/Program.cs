using System;
using System.Collections.Generic;

namespace Oop_3
{
    class Program
    {
        static void Main(string[] args)
        {
          İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
         ////   ihtiyacKrediManager.Hesapla();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
         ////   tasitKrediManager.Hesapla();
          KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();
           IKrediManager ihtiyacKrediManager2 = new İhtiyacKrediManager();
         //   ihtiyacKrediManager2.Hesapla();
         IKrediManager tasitKrediManager2 = new TasitKrediManager();
         //   tasitKrediManager2.Hesapla();
          IKrediManager konutKrediManager2 = new KonutKrediManager();
         //   konutKrediManager2.Hesapla();

            Console.WriteLine("\n\n\n");
            ILoggerService dataBaseLoggerService = new DataBaseLogService();
            ILoggerService fileLogService = new FileLogService();
            BasvuruManager basvuruManager = new BasvuruManager();
            BasvuruManager basvuruManager2 = new BasvuruManager();
           // basvuruManager.BasvuruYap(konutKrediManager2, dataBaseLoggerService);
            IKrediManager  esnafKrediManager = new EsnafKrediManager();
         //   basvuruManager2.BasvuruYap(esnafKrediManager, fileLogService);
            // basvuruManager.BasvuruYap(ihtiyacKrediManager);
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

            ILoggerService smsLoggerService = new SmsLoggerService();
            BasvuruManager basvuruManager3 = new BasvuruManager();
            basvuruManager3.BasvuruYap(esnafKrediManager, new List<ILoggerService> { smsLoggerService ,dataBaseLoggerService});

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
