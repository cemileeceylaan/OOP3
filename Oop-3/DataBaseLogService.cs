using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_3
{
    class DataBaseLogService:ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
