using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpringerTests.Framework.PageObjectModels
{
    public class AdvanceSearchPage
    {
        private const string AdvanceSearchUrl = "https://link.springer.com/advanced-search";
        private readonly IWebDriver _driver;

        public AdvanceSearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(AdvanceSearchUrl);
        }

        public void Search(string input)
        {
            throw new NotImplementedException();
        }
    }
}