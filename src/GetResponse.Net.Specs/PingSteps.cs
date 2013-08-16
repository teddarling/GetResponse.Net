using System;
using TechTalk.SpecFlow;

namespace GetResponse.Net.Specs
{
    [Binding]
    public class PingSteps
    {
        [Given(@"I have a valid API key '(.*)'")]
        public void GivenIHaveAValidAPIKey(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I send a '(.*)' request")]
        public void WhenISendARequest(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
