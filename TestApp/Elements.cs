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
        //Поле логина
        protected static IWebElement text_mailbox_login(IWebDriver driver)
        {
            return driver.FindElement(By.Id("mailbox__login"));
        }
        //Поле пароля
        protected static IWebElement text_mailbox_password(IWebDriver driver)
        {
            return driver.FindElement(By.Id("mailbox__password"));
        }
        //Кнопка авторизации
        protected static IWebElement button_mailbox_auth(IWebDriver driver)
        {
            return driver.FindElement(By.Id("mailbox__auth__button"));
        }
        //Кнопка написать новое письмо
        protected static IWebElement button_send_new_mail(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("span.b-toolbar__btn__text.b-toolbar__btn__text_pad"));
        }
        //Поле для адреса нового письма
        protected static IWebElement text_mail_to(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("textarea.js-input.compose__labels__input"));
        }
        //Поле темы нового письма
        protected static IWebElement text_mail_subject(IWebDriver driver)
        {
            return driver.FindElement(By.Name("Subject"));
        }
        //Кнопка отправить
        protected static IWebElement button_send_mail(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//div[@id='b-toolbar__right']/div[3]/div/div[2]/div/div/span"));
        }
        //Кнопка подтверждение отправки
        protected static IWebElement button_accept_sending(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("(//button[@type='submit'])[6]"));
        }
        //Кнопка логаут
        protected static IWebElement button_logout(IWebDriver driver)
        {
            return driver.FindElement(By.Id("PH_logoutLink"));
        }
    }
}
