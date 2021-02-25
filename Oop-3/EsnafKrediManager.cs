using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_3
{
    class EsnafKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("esnaf kredisi ödeme plani hesaplandi");
        }
    }
}
