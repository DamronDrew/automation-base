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
    public class LMSLeftMainNavPage : PageBase
    {
        #region Ctor

        public LMSLeftMainNavPage()
            : base()
        {

        }

        #endregion

        #region Elements

        [FindsBy(How = How.XPath, Using = "//*[@id='leftnavigationitemClassroom']")]
        private IWebElement divClassRoom;

        #endregion

        #region Methods

        public LMSClassRoomPage ClickClassRoom()
        {
            WaitUtils.WaitForElementClickable(divClassRoom).Click();
            return new LMSClassRoomPage();
        }

        public override bool PageIsDisplayed()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
