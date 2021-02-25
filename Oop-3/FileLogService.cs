using System;

namespace Oop_3
{
    class FileLogService : ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
