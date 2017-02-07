using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class ElementsMailRu
    {
        public static IWebElement mailbox_login(IWebDriver driver)
        {
            return driver.FindElement(By.Id("mailbox__login"));
        }
        public static IWebElement mailbox__password(IWebDriver driver)
        {
            return driver.FindElement(By.Id("mailbox__password"));
        }
        public static IWebElement mailbox__auth__button(IWebDriver driver)
        {
            return driver.FindElement(By.Id("mailbox__auth__button"));
        }
    }
}
