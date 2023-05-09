using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Automation.Suport
{
    public static class Browser
    {
        private static IWebDriver webDriver;
        public static WebDriverWait wait;
        public static string BASEURL = "https://localhost:44390/";

        public static void Init()
        {
            webDriver = new ChromeDriver(@"C:\CD");
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static IWebDriver Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }

        public static string FullURL(string pageUrl)
        {
            return BASEURL + pageUrl;
        }
    }
}
