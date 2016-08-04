using FlipSwitch.Pages.LMSPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FlipSwitch.Automation.SpecFlow.UI.Tests.Steps
{
    [Binding]
    public sealed class MainNavigationSteps
    {
        [Given(@"I have clicked on the ""(.*)"" navigation item")]
        public void GivenIHaveClickedOnTheNavigationItem(string navItem)
        {
            new LMSLeftMainNavPage().NavigateTo(navItem);
        }
    }
}
