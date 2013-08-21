using System;
using TechTalk.SpecFlow;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class AccountInfoSteps
    {
        [Given(@"the following Account Info API response '(.*)'")]
        public void GivenTheFollowingAccountInfoAPIResponse(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I send an account info request")]
        public void WhenISendAnAccountInfoRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the from name should be '(.*)'")]
        public void ThenTheFromNameShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the from email should be '(.*)'")]
        public void ThenTheFromEmailShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the login should be '(.*)'")]
        public void ThenTheLoginShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
