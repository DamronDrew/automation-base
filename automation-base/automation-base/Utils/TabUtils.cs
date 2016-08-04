using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_base.Utils
{
    public static class TabUtils
    {
        public static void SwitchToTab(string windowName)
        {
            var driver = WebDriverBase.GetWebDriver();
            WaitUtils.waitForNumberOfWindowsToEqual(2);
            foreach (var window in driver.WindowHandles)
            {
                driver.SwitchTo().Window(window);
                if (driver.Title == windowName)
                    return;
            }
            throw new Exception(String.Format("Couldn't locate the window '{0}'", windowName));   
        }
    }
}
