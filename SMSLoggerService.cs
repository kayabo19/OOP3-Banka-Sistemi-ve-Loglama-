using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class SMSLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Logu Yapıldı");
        }
    }
}
