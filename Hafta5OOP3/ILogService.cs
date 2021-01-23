using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta5OOP3
{
    interface ILogService
    {
        void Log();
        //Bu interfaceyi her referans alan sınıf log methodunu kullanmak zorunda...
        //İnterface İçinde sadece imza methodlar olacak , başka birşey olamaz.
    }
}
