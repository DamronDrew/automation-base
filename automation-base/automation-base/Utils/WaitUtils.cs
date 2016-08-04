using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_base.Utils
{
    public static class WaitUtils
    {
        public static IWebElement WaitForElementClickable(IWebElement element)
        {
            var wait = new WebDriverWait(WebDriverBase.GetWebDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }

        public static IWebElement WaitForElementPresent(By by)
        {
            var wait = new WebDriverWait(WebDriverBase.GetWebDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(by));
            return WebDriverBase.GetWebDriver().FindElement(by);
        }

        public static IWebElement WaitForElementVisible(By by)
        {
            var wait = new WebDriverWait(WebDriverBase.GetWebDriver(), TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
            return WebDriverBase.GetWebDriver().FindElement(by);
        }

        public static void waitForNumberOfWindowsToEqual(int numberOfWindows)
        {
            var driver = WebDriverBase.GetWebDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(x => driver.WindowHandles.Count() == numberOfWindows);
        }

    }
}
