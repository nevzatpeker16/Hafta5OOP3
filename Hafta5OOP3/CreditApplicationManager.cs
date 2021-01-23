using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta5OOP3
{
    class CreditApplicationManager
    {
        public void DoApplication(ICreditManager creditManager, ILogService logService)
        {
            //Başvurular Değerlendiriliyor...
            creditManager.Hesapla();
            //Hangi loglayıcı veya hangi kredi seçildiyse ona göre hesaplama ve loglama yapacak...
            //Dependency ve Method Injection var.
            logService.Log();
        }
        //ICreditManager hepsinin referansını tuttuğu için , direk o interfaceyi yazarız , burada hangi kredi tipi ile başvurulur ise ona göre hesaplama yapılacak...
        //Hangi referans başvurur ise , onun hesaplama işlemi çalışacak.

        public void DoCreditPreliminaryInformation(List<ICreditManager> creditList , List<ILogService> logList)
        {
            //creditManager listesinde bulunan bütün krediler için hesaplayacak.
            foreach ( var credit in creditList)
            {
                credit.Hesapla();
                foreach (var log in logList)
                {
                    log.Log();
                }

            }

        }
       



    }
}
