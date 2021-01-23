using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta5OOP3
{
    class SmsLoggerService : ILogService
    {
        public void Log()
        {
            Console.WriteLine("Sms Log tutuldu.");
        }
    }
}
