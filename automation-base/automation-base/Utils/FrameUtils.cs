using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_base.Utils
{
    public static class FrameUtils
    {
        public static void SwitchToFrame(string frameId)
        {
            var wait = new WebDriverWait(WebDriverBase.GetWebDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(frameId));
        }
    }
}
