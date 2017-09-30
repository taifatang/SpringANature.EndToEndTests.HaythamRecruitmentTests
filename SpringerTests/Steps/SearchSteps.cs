using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SpringerTests.Framework.PageObjectModels;
using TechTalk.SpecFlow;

namespace SpringerTests.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly IWebDriver _driver;
        private SearchPage _searchPage;

        public SearchSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _searchPage = PageFactory.InitElements<SearchPage>(_driver);
        }

        [Given(@"I am on Search Page")]
        public void GivenIAmOnSearchPage()
        {
            _searchPage.Navigate();
        }

        [When(@"I search for the (.*)")]
        public void WhenISearchForThe(string userInput)
        {
            _searchPage.Search(userInput);
        }

        [Then(@"I receive search results with the (.*) in a title")]
        public void ThenIReceiveSearchResultsWithTheInATitle(string expectedKeyword)
        {
            _searchPage.ValidateSearchResult(expectedKeyword);
        }

        [Then(@"I receive not found message")]
        public void ThenIReceiveNotFoundMessage()
        {
            _searchPage.ValidateSearchNotFound();
        }
    }
}
