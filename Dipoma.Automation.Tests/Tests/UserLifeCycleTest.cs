using Diploma.Automation.Pages;
using Diploma.Automation.Personas;
using Dipoma.Automation.Tests.TestSuport;
using NUnit.Framework;

namespace Dipoma.Automation.Tests
{
    [TestFixture]
    public class UserLifeCycleTest : TestBase
    {
        [Test]
        public void LogInUserAsAdmin()
        {
            FactoryPages.LoginPage.Goto().NewLogIn(KnownPersonas.SystemAdmin.Username, KnownPersonas.SystemAdmin.Password); ;         
            Assert.AreEqual($"Hello {KnownPersonas.SystemAdmin.Username}!", FactoryPages.HomePage.GetCurrentUser());
            Assert.IsTrue(FactoryPages.HomePage.AdminNavbarIsVisible);
        }
        [Test]
        public void LogInUser()
        {
            FactoryPages.LoginPage.Goto().NewLogIn(KnownPersonas.SystemUser.Username, KnownPersonas.SystemUser.Password); ;
            Assert.AreEqual($"Hello {KnownPersonas.SystemUser.Username}!", FactoryPages.HomePage.GetCurrentUser());
        }
    }
}
