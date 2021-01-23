using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta5OOP3
{
    class DatabaseLoggerService:ILogService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına log atıldı.");
        }
        //İmplement etmek zorunda.
    }
}
