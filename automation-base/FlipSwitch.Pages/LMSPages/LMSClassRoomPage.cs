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
    public class LMSClassRoomPage : PageBase
    {
        #region Ctor

        public LMSClassRoomPage()
            : base()
        {
            PageIsDisplayed();
        }

        #endregion

        #region Elements

        [FindsBy(How = How.ClassName, Using = "btn-launch")]
        private IList<IWebElement> btnLaunch;
        
        #endregion

        #region Methods

        public LMSClassSessionPage ClickLaunch()
        {
            WaitUtils.WaitForElementClickable(btnLaunch.FirstOrDefault()).Click();
            TabUtils.SwitchToTab("Flipswitch Virtual Classroom - Index");
            return new LMSClassSessionPage();
        }

        public override bool PageIsDisplayed()
        {
            FrameUtils.SwitchToFrame(By.Id("ClassRoomFrame"));
            return true;
        }

        #endregion
    }
}
