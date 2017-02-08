using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Test
    {
        [Test]
        public static void SendMailTest(IWebDriver driver, Data data)
        {
            
            Mail_ru mail_ru = new Mail_ru();
            mail_ru.GoToMainPage(driver, data.Site);
            mail_ru.Login(driver, data.Login, data.Password);
            mail_ru.InitSendEmail(driver);
            mail_ru.FillEmail(driver, data.Mail, data.Subject);
            mail_ru.SendEmail(driver);
            mail_ru.Logout(driver);

        }
    }
}
