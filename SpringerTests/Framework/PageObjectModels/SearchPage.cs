using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpringerTests.Framework.PageObjectModels
{
    public class SearchPage : IBrowsable
    {
        private const string SearchPageUrl = "https://link.springer.com";
        private readonly IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "query")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "results")]
        public IWebElement SearchResult { get; set; }

        [FindsBy(How = How.Id, Using = "no-results-message")]
        public IWebElement NotFound { get; set; }

        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(SearchPageUrl);
        }

        public void Search(string input)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(input);
            SearchButton.Click();
        }

        public void ValidateSearchResult(string expectedKeyWord)
        {
            Assert.That(SearchResult.Text.Contains(expectedKeyWord));
        }
        public void ValidateSearchNotFound()
        {
            Assert.That(NotFound.Displayed);
        }
    }

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
            SearchInput.Clear();
            SearchInput.SendKeys(input);
            SearchButton.Click();
        }
    }
}
