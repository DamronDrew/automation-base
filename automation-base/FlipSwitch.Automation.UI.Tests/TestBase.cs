using automation_base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipSwitch.Automation.UI.Tests
{
    public class TestBase
    {
        [TestInitialize()]
        public void setupTest()
        {
            WebDriverBase.CreateDriver("https://devflms.flipswitch.com/", "Chrome");
        }

        [TestCleanup()]
        public void cleanUp()
        {
            WebDriverBase.GetWebDriver().Quit();
        }

        public TestBase()
        {
            
        }
    }
}
