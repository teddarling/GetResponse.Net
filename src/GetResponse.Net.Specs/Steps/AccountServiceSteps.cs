using System;
using TechTalk.SpecFlow;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class AccountServiceSteps
    {
        [Given(@"a account service return value '(.*)'")]
        public void GivenAAccountServiceReturnValue(string result)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"an account service")]
        public void GivenAnAccountService()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a from name of '(.*)'")]
        public void GivenAFromNameOf(string name)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a from email of '(.*)'")]
        public void GivenAFromEmailOf(string email)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a domain id of '(.*)'")]
        public void GivenADomainIdOf(string domainId)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the following customs data")]
        public void GivenTheFollowingCustomsData(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"custom Id of '(.*)'")]
        public void GivenCustomIdOf(string customId)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"custom contents of '(.*)', '(.*)' and '(.*)'")]
        public void GivenCustomContentsOfAnd(string p0, string p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call GetInfo")]
        public void WhenICallGetInfo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call GetFromFields")]
        public void WhenICallGetFromFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call GetFromField with a value of '(.*)'")]
        public void WhenICallGetFromFieldWithAValueOf(string fromId)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call AddFromField")]
        public void WhenICallAddFromField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call GetDomains")]
        public void WhenICallGetDomains()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call GetDomain with the domain id")]
        public void WhenICallGetDomainWithTheDomainId()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call GetCustoms")]
        public void WhenICallGetCustoms()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call AddCustom")]
        public void WhenICallAddCustom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call SetCustomContent")]
        public void WhenICallSetCustomContent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I call DeleteCustom")]
        public void WhenICallDeleteCustom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the account service result should be the account service return value")]
        public void ThenTheAccountServiceResultShouldBeTheAccountServiceReturnValue()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
