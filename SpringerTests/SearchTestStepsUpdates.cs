using System;
using TechTalk.SpecFlow;

namespace SpringerTests
{
    [Binding]
    public class SearchTestSteps
    {
        [Given(@"I am a user")]
        public void GivenIAmAUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to the '(.*)'")]
        public void GivenINavigateToThe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for the Maths")]
        public void WhenISearchForTheMaths()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for the !£\$%\^&")]
        public void WhenISearchForThe()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search each field individually: Maths, , , , , ")]
        public void WhenISearchEachFieldIndividuallyMaths()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search each field individually with an invalid text: !£\$%\^&, , , , , ")]
        public void WhenISearchEachFieldIndividuallyWithAnInvalidText()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input a valid date in the (.*)")]
        public void WhenIInputAValidDateInThe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I input an invalid date in the (.*)")]
        public void WhenIInputAnInvalidDateInThe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I receive search results with the Maths in a title")]
        public void ThenIReceiveSearchResultsWithTheMathsInATitle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I receive search results with the sorry message Sorry")]
        public void ThenIReceiveSearchResultsWithTheSorryMessageSorry()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I receive search results with books of the pulished date (.*)")]
        public void ThenIReceiveSearchResultsWithBooksOfThePulishedDate(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
    }
}
