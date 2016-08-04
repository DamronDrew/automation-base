using automation_base;
using automation_base.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipSwitch.Pages.LMSPages
{
    public class LMSClassSessionPage : PageBase
    {
        #region Ctor

        public LMSClassSessionPage()
            : base()
        {

        }

        #endregion

        #region Elements

        #endregion

        #region Methods

        public override bool PageIsDisplayed()
        {
            return WaitUtils.WaitForElementVisible(By.Id("learning-session")).Displayed;
        }

        #endregion
    }
}
