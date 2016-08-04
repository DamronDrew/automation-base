using FlipSwitch.Pages.LMSPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FlipSwitch.Automation.SpecFlow.UI.Tests.Steps
{
    [Binding]
    public sealed class ClassRoomSessionSteps
    {
        [Then(@"the Classroom should be displayed")]
        public void ThenTheClassroomShouldBeDisplayed()
        {
            Assert.IsTrue(new LMSClassSessionPage().PageIsDisplayed());
        }
    }
}
