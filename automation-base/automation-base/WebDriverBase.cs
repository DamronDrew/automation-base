using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace automation_base
{
    public static class WebDriverBase
    {
        private static ThreadLocal<IWebDriver> threadDriver;

        public static IWebDriver GetWebDriver()
        {
            if (threadDriver.Value == null)
            //if (webDriver == null)
            {
                throw new NullReferenceException("The driver instance was not initialized. You should first call the method startDriver.");
            }
            return threadDriver.Value;
        }

        public static void CreateDriver()
        {
            threadDriver = new ThreadLocal<IWebDriver>(() =>
            {
                return new ChromeDriver(String.Format("{0}\\{1}\\", Environment.CurrentDirectory, "Drivers", "chromedriver.exe"));
            }, true);
        }

        public static void NavigateTo(String url)
        {
            GetWebDriver().Navigate().GoToUrl("https://www.google.com/");
        }
    }
}