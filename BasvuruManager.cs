using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
     class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var logs in loggerServices)
            {
                logs.Log();
            }
        }

        public void KrediBilgilendirmesiYap(List<IKrediManager> krediler,ILoggerService loggerservice)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                
                
            }
            loggerservice.Log();
        }
        
    }
}
