using System;
using System.Collections.Generic;

namespace Hafta5OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager vehicleCreditmn = new VehicleCreditManager(); 
            ICreditManager houseCreditmn = new HouseCreditManager();
            ILogService smsLogService = new SmsLoggerService();
            ILogService fileLogService = new FileLoggerService();
            ILogService dataBaseLogService = new DatabaseLoggerService();
            ICreditManager sallerCreditmn = new SallerCreditManager();

            //İnterface üzerinden referans oluşturduk...
            CreditApplicationManager creditApplicationManager = new CreditApplicationManager();        
            //Bizden creditApplicationManager , kredi nesnesi istedi , hangi kredi nesnesi olacak ise başvuru da ona gidecek. 

            List<ICreditManager> creditList = new List<ICreditManager>() { houseCreditmn,sallerCreditmn};
            List<ILogService> logList = new List<ILogService>() { fileLogService, dataBaseLogService,smsLogService};
            creditApplicationManager.DoCreditPreliminaryInformation(creditList,logList);




        }

    }
}
