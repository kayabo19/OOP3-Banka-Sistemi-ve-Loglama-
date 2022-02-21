using System;
using System.Collections.Generic;

namespace OOP3
{
   class Program
    {
        static void Main(string[] args)
        {
            BasvuruManager basvuruManager = new BasvuruManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SMSLoggerService();
            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager, tasitKrediManager, ihtiyacKrediManager}; 
            List<ILoggerService> loggerServices = new List<ILoggerService>() {databaseLoggerService, fileLoggerService, smsLoggerService};       

            basvuruManager.BasvuruYap(konutKrediManager, loggerServices);
            basvuruManager.KrediBilgilendirmesiYap(krediler, smsLoggerService);
               
           

        }
    }
}
