using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diploma.Automation.Suport;
using SeleniumExtras.PageObjects;

namespace Diploma.Automation.Pages
{
    public static class FactoryPages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }
        }
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, loginPage);
                return loginPage;
            }
        }

        public static RegisterPage RegisterPage
        {
            get
            {
                var registerPage = new RegisterPage();
                PageFactory.InitElements(Browser.Driver, registerPage);
                return registerPage;
            }
        }

        public static СategoryPage СategoryPage
        {
            get
            {
                var categoryPage = new СategoryPage();
                PageFactory.InitElements(Browser.Driver, categoryPage);
                return categoryPage;
            }
        }

    }
}
