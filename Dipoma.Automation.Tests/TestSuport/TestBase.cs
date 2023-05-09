using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diploma.Automation.Suport;

namespace Dipoma.Automation.Tests.TestSuport
{
    [TestFixture]
    public class TestBase
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Browser.Init();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Browser.Close();
        }

    }
}
