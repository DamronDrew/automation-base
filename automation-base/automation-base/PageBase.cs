using automation_base.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automation_base
{
    public abstract class PageBase
    {
        public PageBase()
        {
            PageFactory.InitElements(WebDriverBase.GetWebDriver(), this);
        }

        public abstract bool PageIsDisplayed();
    }
}
