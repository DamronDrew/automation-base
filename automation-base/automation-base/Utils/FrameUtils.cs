using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace automation_base.Utils
{
    public static class FrameUtils
    {
        public static void SwitchToFrame(By by)
        {
            var wait = new WebDriverWait(WebDriverBase.GetWebDriver(), TimeSpan.FromSeconds(20));
            Thread.Sleep(8000);
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(by)); 
        }
    }
}
