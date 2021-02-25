using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabasaLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
