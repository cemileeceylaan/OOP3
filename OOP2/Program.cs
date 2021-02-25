using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Cemile";
            //musteri1.Soyadi = "Ceylan";
            //musteri1.Id = 1;
            //musteri1.TcNo = "33333";
            //musteri1.MusteriNo = "4444";

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12234";
            musteri1.Adi = "Cemile";
            musteri1.Soyadi = "Ceylan";
            musteri1.TcNo = "1522545";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54555";
            musteri2.SirketAdi = "esogü";
            musteri2.VergiNo = "25566544";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
