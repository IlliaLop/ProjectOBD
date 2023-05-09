using Diploma.Automation.Pages;
using Diploma.Automation.Personas;
using Dipoma.Automation.Tests.TestSuport;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipoma.Automation.Tests.Tests
{
    [TestFixture]
    public class СontentTest : TestBase
    {
        [Test]
        public void AddCategory()
        {
            FactoryPages.LoginPage.Goto().NewLogIn(KnownPersonas.SystemAdmin.Username, KnownPersonas.SystemAdmin.Password); ;
            Assert.AreEqual($"Hello {KnownPersonas.SystemAdmin.Username}!", FactoryPages.HomePage.GetCurrentUser());
            Assert.IsTrue(FactoryPages.HomePage.AdminNavbarIsVisible);

            FactoryPages.HomePage.OpenCategoryPage();
            FactoryPages.СategoryPage.pressAddButton().AddNewCategory("Test", "111");
        }
    }
}
