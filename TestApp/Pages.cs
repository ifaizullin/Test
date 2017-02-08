using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{
    class Mail_ru : ElementsMailRu
    {
        public  void GoToMainPage(IWebDriver driver, string site)
        {
            if (site == "http://mail.ru")
                driver.Navigate().GoToUrl(site);
            else
                driver.Close();
        }
        public  void Login(IWebDriver driver, string Username, string Password)
        {
            text_mailbox_login(driver).Clear();
            text_mailbox_login(driver).SendKeys(Username);
            text_mailbox_password(driver).Clear();
            text_mailbox_password(driver).SendKeys(Password);
            button_mailbox_auth(driver).Click();
        }
        public  void InitSendEmail(IWebDriver driver)
        {
            button_send_new_mail(driver).Click();
        }
        public  void FillEmail(IWebDriver driver, string mail, string subject)
        {
            text_mail_to(driver).Clear();
            text_mail_to(driver).SendKeys(mail);
            text_mail_subject(driver).Clear();
            text_mail_subject(driver).SendKeys(subject);
        }
        public  void SendEmail(IWebDriver driver)
        {
            button_send_mail(driver).Click();
            Thread.Sleep(2000);
            button_accept_sending(driver).Click();
        }
        public  void Logout(IWebDriver driver)
        {
            button_logout(driver).Click();
        }
    }
}
