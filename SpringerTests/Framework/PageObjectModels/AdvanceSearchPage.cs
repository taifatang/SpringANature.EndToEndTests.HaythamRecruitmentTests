using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpringerTests.Framework.PageObjectModels
{
    public class AdvanceSearchPage : BaseSearchPage
    {
        private const string AdvanceSearchUrl = "https://link.springer.com/advanced-search";
        private readonly IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "all-words")]
        public IWebElement AllKeyWordsInput { get; set; }

        [FindsBy(How = How.Name, Using = "exact-phrase")]
        public IWebElement ExactSearchInput { get; set; }

        [FindsBy(How = How.Name, Using = "least-words")]
        public IWebElement LeastWordsSearchInput { get; set; }

        [FindsBy(How = How.Name, Using = "without-words")]
        public IWebElement WithoutWordsSearchInput { get; set; }

        [FindsBy(How = How.Name, Using = "title-is")]
        public IWebElement TitleSearchInput { get; set; }

        [FindsBy(How = How.Name, Using = "author-is")]
        public IWebElement AuthorsSearchInput { get; set; }

        [FindsBy(How = How.Id, Using = "submit-advanced-search")]
        public IWebElement AdvanceSearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "facet-start-year")]
        public IWebElement PublishDateBefore { get; set; }

        [FindsBy(How = How.Id, Using = "facet-end-year")]
        public IWebElement PublishDateAfter { get; set; }
        public AdvanceSearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(AdvanceSearchUrl);
        }

        public void Search()
        {
            AdvanceSearchButton.Click();
        }
    }
}