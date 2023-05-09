using Diploma.Automation.Suport;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Automation.Pages
{
    public class HomePage
    {
        public static string PageUrl = ("Index");

        private readonly By manageLocator = By.Id("manage");

        private readonly By adminNavbarDropdownLocator = By.Id("navbarDropdown");

        private readonly By categoryDropdownLocator = By.XPath("//a[text() = 'Category']");



        public string GetCurrentUser()
        {
            return Browser.Driver.FindElement(manageLocator).Text;
        }

        public bool AdminNavbarIsVisible =>
            Browser.Driver.FindElement(adminNavbarDropdownLocator).Displayed;

        public void OpenCategoryPage()
        {
            Browser.Driver.FindElement(adminNavbarDropdownLocator).Click();
            Browser.Driver.FindElement(categoryDropdownLocator).Click();          
        }



        public HomePage Goto()
        {
            Browser.Goto(Browser.FullURL(PageUrl));
            WaitUtil.ShouldLocate(Browser.Driver, Browser.FullURL(PageUrl));
            return this;
        }
    }
}
