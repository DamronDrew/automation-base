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
        string frameId = "ClassRoomFrame";

        #region Ctor

        public LMSClassRoomPage()
            : base()
        {
            switchToClassFrame();
        }

        #endregion

        #region Elements

        [FindsBy(How = How.ClassName, Using = "btn-launch")]
        private IWebElement btnLaunch;

        #endregion

        #region Methods

        private void switchToClassFrame()
        {
            FrameUtils.SwitchToFrame(frameId);
        }

        public LMSClassSessionPage ClickLaunch()
        {
            WaitUtils.WaitForElementClickable(btnLaunch).Click();
            TabUtils.SwitchToTab("Flipswitch Virtual Classroom - Index");
            return new LMSClassSessionPage();
        }

        public override bool PageIsDisplayed()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
