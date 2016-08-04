using FlipSwitch.Pages.LMSPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FlipSwitch.Automation.SpecFlow.UI.Tests.Steps
{
    [Binding]
    public sealed class ClassroomSteps
    {
        [When(@"I launch the session")]
        public void WhenILaunchTheSession()
        {
            new LMSClassRoomPage().ClickLaunch();
        }
    }
}
