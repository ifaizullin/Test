using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Browser
    {
        public IWebDriver driver;
        public void ChooseDriver(string driv)
        {
            if (driv == "Chrome")
            {
                driver = new ChromeDriver();
            }
            if (driv == "Firefox")
            {
                driver = new FirefoxDriver();
            }
        }
    }
}
