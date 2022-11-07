using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab2.Steps
{
    [Binding]
    public class BaseSteps
    {
        protected static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeauture()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}
