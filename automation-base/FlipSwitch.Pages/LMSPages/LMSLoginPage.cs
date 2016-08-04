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
    public class LMSLoginPage : PageBase
    {

        #region Elements

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement txtUserName;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement txtPassword;

        [FindsBy(How = How.ClassName, Using = "loginbutton")]
        private IWebElement btnLogIn;

        #endregion

        #region Ctor

        public LMSLoginPage()
            : base()
        {

        }

        #endregion

        #region Methods

        public LMSLoginPage EnterUserName(string userName)
        {
            WaitUtils.WaitForElementClickable(txtUserName).SendKeys(userName);
            return this;
        }

        public LMSLoginPage EnterPassword(string password)
        {
            WaitUtils.WaitForElementClickable(txtPassword).SendKeys(password);
            return this;
        }

        public LMSLeftMainNavPage ClickLogin()
        {
            WaitUtils.WaitForElementClickable(btnLogIn).Click();
            return new LMSLeftMainNavPage();
        }

        public void LogIn(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickLogin();
        }

        public override bool PageIsDisplayed()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
