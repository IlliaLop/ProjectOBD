using Diploma.Automation.Suport;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Automation.Pages
{
    public class LoginPage
    {
        public static string PageUrl = ("Identity/Account/Login");

        private readonly By EmailInputLocator = By.Id("Input_Email");
        private readonly By PasswordInputLocator = By.Id("Input_Password");
        private readonly By LoginButonLocator = By.CssSelector(".btn.btn-primary");

        public void NewLogIn(string email, string password)
        {
            Browser.Driver.FindElement(EmailInputLocator).SendKeys(email);
            Browser.Driver.FindElement(PasswordInputLocator).SendKeys(password);
            Browser.Driver.FindElement(LoginButonLocator).Click();       
        }

        public LoginPage Goto()
        {
            Browser.Goto(Browser.FullURL(PageUrl));
            WaitUtil.ShouldLocate(Browser.Driver, Browser.FullURL(PageUrl));
            return this;
        }

    }
}
