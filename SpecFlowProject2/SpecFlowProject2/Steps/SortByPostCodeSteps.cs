using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using PageObject;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Lab2.Steps
{
    [Binding]
    public class SortByPostCodeSteps : BaseSteps
    {
        private LoginPage loginPage;
        private MenuPage menuPage;
        private CustomersPage customersPage;
        List<string> actualPostCodes = new List<string>();
        List<string> expectedPostCodes = new List<string>();

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            loginPage = new LoginPage(driver);
            TimeSpan.FromSeconds(5);
        }
        
        [Given(@"I click on the Bank Manager Login link")]
        public void GivenIClickOnTheBankManagerLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [Given(@"I click on the Customers menu item")]
        public void GivenIClickOnTheCustomersMenuItem()
        {
            menuPage = new MenuPage(driver);
            TimeSpan.FromSeconds(5);
            menuPage.ClickCustomers();
        }
        
        [When(@"I click on the Post Code header")]
        public void WhenIClickOnThePostCodeHeader()
        {
            customersPage = new CustomersPage(driver);
            TimeSpan.FromSeconds(5);
            expectedPostCodes = customersPage.GetPostCodes();
            expectedPostCodes.Sort((a, b) => b.CompareTo(a));
            customersPage.ClickPostCode();
            TimeSpan.FromSeconds(5);
            actualPostCodes = customersPage.GetPostCodes();
            TimeSpan.FromSeconds(5);
        }
        
        [Then(@"I should see postcode records sorted in descending order")]
        public void ThenIShouldSeePostcodeRecordsSortedInDescendingOrder()
        {
            Assert.AreEqual(actualPostCodes, expectedPostCodes);
        }
    }
}
