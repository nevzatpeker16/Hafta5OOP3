using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta5OOP3
{
    class FileLoggerService : ILogService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");
        }
    }
}
