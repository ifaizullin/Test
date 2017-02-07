using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            string brow = "Chrome";
            string site = "http://mail.ru";
            Browser browser = new Browser();
            browser.ChooseDriver(brow);
            Program pro = new Program();
            pro.SendMailTest(browser.driver,site);
            pro.CleanUp(browser.driver);
            
        }
        [SetUp]
        public void Initialize()
        {     
        }
        
        [Test]
        public void SendMailTest(IWebDriver driver,string site)
        {
            GoToMainPage(driver,site);
            Login(driver,"Goraki3", "Ildar2005");
            InitSendEmail(driver);
            FillEmail(driver);
            SendEmail(driver);
            Logout(driver);

        }
        private void GoToMainPage(IWebDriver driver, string site)
        {
            if (site == "http://mail.ru")
            driver.Navigate().GoToUrl(site);
        }
        private void Login(IWebDriver driver,string Username, string Password)
        {
            ElementsMailRu.mailbox_login(driver).Clear();
            ElementsMailRu.mailbox_login(driver).SendKeys(Username);
            ElementsMailRu.mailbox__password(driver).Clear();
            ElementsMailRu.mailbox__password(driver).SendKeys(Username);
            driver.FindElement(By.Id("mailbox__login")).Clear();
            driver.FindElement(By.Id("mailbox__login")).SendKeys(Username);
            driver.FindElement(By.Id("mailbox__password")).Clear();
            driver.FindElement(By.Id("mailbox__password")).SendKeys(Password);
            driver.FindElement(By.Id("mailbox__auth__button")).Click();
        }
        private void InitSendEmail(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("span.b-toolbar__btn__text.b-toolbar__btn__text_pad")).Click();
        }

        
         public void FillEmail(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("textarea.js-input.compose__labels__input")).Clear();
            driver.FindElement(By.CssSelector("textarea.js-input.compose__labels__input")).SendKeys("Goraki3@mail.ru");
            driver.FindElement(By.Name("Subject")).Clear();
            driver.FindElement(By.Name("Subject")).SendKeys("test");
        }
        public void SendEmail(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//div[@id='b-toolbar__right']/div[3]/div/div[2]/div/div/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//button[@type='submit'])[6]")).Click();
        }
        public void Logout(IWebDriver driver)
        {
            driver.FindElement(By.Id("PH_logoutLink")).Click();
        }
        [TearDown]
        public void CleanUp(IWebDriver driver)
        {
            driver.Close();            
        }
    }

}
