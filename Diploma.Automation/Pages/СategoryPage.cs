using Diploma.Automation.Suport;
using OpenQA.Selenium;
using System;

namespace Diploma.Automation.Pages
{
    public class СategoryPage
    {
        private readonly By addButton = By.CssSelector(".fas.fa-plus");
        
        public AddCategory pressAddButton()
        {
            Browser.Driver.FindElement(addButton).Click();
            return new AddCategory();
        }      
    }
}