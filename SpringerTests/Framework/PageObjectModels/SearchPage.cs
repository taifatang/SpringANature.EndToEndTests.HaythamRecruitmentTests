using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpringerTests.Framework.PageObjectModels
{
    public class SearchPage : BaseSearchPage
    {
        private const string SearchPageUrl = "https://link.springer.com";
        private readonly IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "query")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement SearchButton { get; set; }

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
    }
}
