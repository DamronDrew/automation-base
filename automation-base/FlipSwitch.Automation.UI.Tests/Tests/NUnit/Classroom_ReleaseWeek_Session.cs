using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlipSwitch.Pages.LMSPages;
using automation_base.Utils;

namespace FlipSwitch.Automation.UI.Tests.Tests.NUnit
{
    [TestClass]
    public class Classroom_ReleaseWeek_Session : TestBase
    {
        public Classroom_ReleaseWeek_Session()
            : base()
        {
            
        }

        [TestMethod]
        public void Classroom_Session_Launch_Test()
        {
            var LMSClassSessionPage = new LMSLoginPage()
                .EnterUserName("alextester")
                .EnterPassword("Test1234")
                .ClickLogin()
                .ClickClassRoom()
                .ClickLaunch();
            Assert.IsTrue(LMSClassSessionPage.PageIsDisplayed());

        }
    }
}
