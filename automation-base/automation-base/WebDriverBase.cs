using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
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

        public static void CreateDriver(String url, String browser)
        {
            DesiredCapabilities capabilities;
            switch (browser)
            {
                case "Chrome":
                    capabilities = DesiredCapabilities.Chrome();
                    capabilities.SetCapability("platform", "WINDOWS");
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("start-maximized");
                    capabilities.SetCapability(ChromeOptions.Capability, options);
                    threadDriver = new ThreadLocal<IWebDriver>(() =>
                    {
                        return new ChromeDriver("C:/Temp/", options);
                    }, true);
                    break;
                default:
                    break;
            }
            NavigateTo(url);
        }

        public static void NavigateTo(String url)
        {
            GetWebDriver().Navigate().GoToUrl(url);
        }
    }
}