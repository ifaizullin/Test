using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestApp
{    
    class Program
    {
        
        static void Main(string[] args)
        {           
            
            Data data = new Data();
            if (args.Length > 0)
            {
                data.FromXml(data, args[0]);
                Console.WriteLine(args[0]);
            }
            else data.FromXml(data, "xml.xml");
            Browser browser = new Browser();
            browser.ChooseDriver(data.Browser);
            Program pro = new Program();
            Test.SendMailTest(browser.driver, data);
            pro.CleanUp(browser.driver);
        }
        [SetUp]
        public void Initialize()
        {
        }
        [TearDown]
        public void CleanUp(IWebDriver driver)
        {
            driver.Close();            
        }
    }
    class Data
    {                       
        public string Browser { get; set; }
        public string Site { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public void FromXml(Data data, string fileName)
        {
            
            XDocument doc = XDocument.Load(fileName);
            foreach (XElement el in doc.Root.Elements())
            {
                foreach (XElement element in el.Elements())
                {
                    if (element.Name == "browser")
                        data.Browser = element.Value;

                    if (element.Name == "site")
                        data.Site = element.Value;

                    if (element.Name == "mail")
                        data.Mail = element.Value;

                    if (element.Name == "subject")
                        data.Subject = element.Value;

                    if (element.Name == "login")
                        data.Login = element.Value;

                    if (element.Name == "password")
                        data.Password = element.Value;
                }
            }
        }


    }

}
