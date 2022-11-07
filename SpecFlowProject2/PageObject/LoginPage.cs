using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver) { }

        private IWebElement btnBankManagerLogin => driver.FindElement(By.XPath("//button[@ng-click='manager()']"));

        public void ClickLogin() => btnBankManagerLogin.Click();
    }
}
