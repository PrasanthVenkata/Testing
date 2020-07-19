using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace TestingProject
{
    [Binding]
    public class FunctionalTestsSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            p0.Should().BeLessThan(10, "P0 should be less than 10");
           
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {

        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            p0.Should().BeGreaterOrEqualTo(100, "P0 should be always 100");

        }
    }
}
