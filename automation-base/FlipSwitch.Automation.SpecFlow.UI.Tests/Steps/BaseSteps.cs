using automation_base;
using FlipSwitch.Pages.LMSPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FlipSwitch.Automation.SpecFlow.UI.Tests.Steps
{
    [Binding]
    public sealed class BaseSteps
    {

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement screenshot here on failed scenario
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            WebDriverBase.CreateDriver("https://devflms.flipswitch.com/", "Chrome");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            WebDriverBase.GetWebDriver().Quit();
        }


        [Given(@"I have logged in as ""(.*)""")]
        public void GivenIHaveLoggedInAs(string userType)
        {
            //TODO: Some form of TDM here to go get the user you need to perform the test.
            //For the purposes of this POC, will use "alextester, Test1234"
            new LMSLoginPage().LogIn("alextester", "Test1234");
        }
    }
}
