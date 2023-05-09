using Diploma.Automation.Suport;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Automation.Pages
{
    public class AddCategory
    {
        private readonly By NameLocator = By.Id("Name");
        private readonly By DisplayOrderLocator = By.Id("DisplayOrder");
        private readonly By CreateLocator = By.CssSelector(".btn.btn-info.w-100");

        public void AddNewCategory(string name, string displayOrder)
        {
            Browser.Driver.FindElement(NameLocator).SendKeys(name);
            Browser.Driver.FindElement(DisplayOrderLocator).SendKeys(displayOrder);
            Browser.Driver.FindElement(CreateLocator).Click();
        }
    }
}
