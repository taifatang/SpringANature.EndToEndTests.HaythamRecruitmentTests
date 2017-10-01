using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpringerTests.Framework;
using SpringerTests.Framework.PageObjectModels;
using TechTalk.SpecFlow;

namespace SpringerTests.Steps
{
    [Binding]
    public class AdvanceSearchSteps
    {
        private readonly IWebDriver _driver;
        private AdvanceSearchPage _advanceSearchPage;

        public AdvanceSearchSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _advanceSearchPage = PageFactory.InitElements<AdvanceSearchPage>(_driver);
        }

        [Given(@"I am on Advance Search Page")]
        public void GivenIAmOnAdvanceSearchPage()
        {
            _advanceSearchPage.Navigate();
        }

        [When(@"I submit advance advance search")]
        public void WhenISubmitAdvanceAdvanceSearch()
        {
            _advanceSearchPage.Search();
            StateManager.Save("result", _advanceSearchPage.SearchResult);
            StateManager.Save("error-result", _advanceSearchPage.NotFound);
        }


        [When(@"I Enter (.*) in all search field")]
        public void WhenIEnterInAllSearchField(string query)
        {
            _advanceSearchPage.AllKeyWordsInput.Clear();
            _advanceSearchPage.AllKeyWordsInput.SendKeys(query);
        }

        [When(@"I Enter (.*) in exact search field")]
        public void WhenIEnterInExactSearchField(string query)
        {
            _advanceSearchPage.ExactSearchInput.Clear();
            _advanceSearchPage.ExactSearchInput.SendKeys(query);
        }

        [When(@"I Enter (.*) in oneOfTheWords search field")]
        public void WhenIEnterInOneOfTheWordsSearchField(string query)
        {
            _advanceSearchPage.LeastWordsSearchInput.Clear();
            _advanceSearchPage.LeastWordsSearchInput.SendKeys(query);
        }

        [When(@"I Enter (.*) in withOut search field")]
        public void WhenIEnterInWithOutSearchField(string query)
        {
            _advanceSearchPage.WithoutWordsSearchInput.Clear();
            _advanceSearchPage.WithoutWordsSearchInput.SendKeys(query);
        }

        [When(@"I Enter (.*) in title search field")]
        public void WhenIEnterInTitleSearchField(string query)
        {
            _advanceSearchPage.TitleSearchInput.Clear();
            _advanceSearchPage.TitleSearchInput.SendKeys(query);
        }

        [When(@"I Enter (.*) in author search field")]
        public void WhenIEnterInAuthorSearchField(string query)
        {
            _advanceSearchPage.AuthorsSearchInput.Clear();
            _advanceSearchPage.AuthorsSearchInput.SendKeys(query);
        }

        [When(@"I input a date in the (.*) and (.*)")]
        public void WhenIInputADateInTheAnd(string publishDateBefore, string publishDateAfter)
        {
            _advanceSearchPage.PublishDateBefore.Clear();
            _advanceSearchPage.PublishDateBefore.SendKeys(publishDateBefore);

            _advanceSearchPage.PublishDateAfter.Clear();
            _advanceSearchPage.PublishDateAfter.SendKeys(publishDateAfter);
        }

        [Then(@"I receive search results inbetween (.*) and (.*)")]
        public void ThenIReceiveSearchResultsInbetweenAnd(string publishDateBefore, string publishDateAfter)
        {
            var resultElement = StateManager.Get<IWebElement>("result");
            var dateElementText = resultElement.FindElement(By.ClassName("facet-link")).Text;
            var withInDateRange = dateElementText.Contains(publishDateBefore) && dateElementText.Contains(publishDateAfter);

            Assert.That(withInDateRange);
        }
    }
}
