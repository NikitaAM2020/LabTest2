using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObject
{
    public class MenuPage : BasePage
    {
        public MenuPage(IWebDriver webDriver) : base(webDriver) { }

        private IWebElement btnCustomers => driver.FindElement(By.XPath("//button[@ng-click='showCust()']"));

        public void ClickCustomers() => btnCustomers.Click();
    }
}
