using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObject
{
    public class CustomersPage : BasePage
    {
        public CustomersPage(IWebDriver webDriver) : base(webDriver) { }

        private IWebElement btnPostCode => driver.FindElement(By.XPath("//tr/td[3]"));
        private List<IWebElement> firstPostCodeElements => driver.FindElements(By.XPath("//tr/td[3][@class='ng-binding']")).ToList<IWebElement>();

        public void ClickPostCode() => btnPostCode.Click();
        public List<string> GetPostCodes() => firstPostCodeElements.Select(el => el.Text).ToList<string>();
    }
}
