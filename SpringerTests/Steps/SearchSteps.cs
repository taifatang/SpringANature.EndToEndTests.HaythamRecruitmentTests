using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SpringerTests.Framework;
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
            StateManager.Save("result", _searchPage.SearchResult);
            StateManager.Save("error-result", _searchPage.NotFound);
        }
    }
}
