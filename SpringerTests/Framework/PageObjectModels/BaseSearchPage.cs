using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpringerTests.Framework.PageObjectModels
{
    public abstract class BaseSearchPage
    {
        [FindsBy(How = How.Id, Using = "results")]
        public IWebElement SearchResult { get; set; }

        [FindsBy(How = How.Id, Using = "no-results-message")]
        public IWebElement NotFound { get; set; }
    }
}
