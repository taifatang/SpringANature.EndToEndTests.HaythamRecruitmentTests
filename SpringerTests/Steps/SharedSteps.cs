using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SpringerTests.Framework;
using TechTalk.SpecFlow;

namespace SpringerTests.Steps
{
    [Binding]
    public class SharedSteps
    {
        [Then(@"I receive search results with the (.*) in a title")]
        public void ThenIReceiveSearchResultsWithTheInATitle(string expectedKeyword)
        {
            var result = StateManager.Get<IWebElement>("result");

            Assert.That(result.Text.Contains(expectedKeyword));
        }
        [Then(@"I receive not found message")]
        public void ThenIReceiveNotFoundMessage()
        {
            var notFoundPage = StateManager.Get<IWebElement>("error-result");
            Assert.That(notFoundPage.Displayed);
        }
    }
}
