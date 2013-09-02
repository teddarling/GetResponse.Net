using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using GetResponse.Net.Service;
using Xunit;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class AccountServiceSteps
    {
        private string _key = "valid API key";
        private string _response;
        private string _result;
        private HttpResponseMessage _responseMessage;
        private AccountService _service;

        [BeforeScenario]
        public void Setup()
        {
            _responseMessage = new HttpResponseMessage();
        }

        [Given(@"a account service return value '(.*)'")]
        public void GivenAAccountServiceReturnValue(string result)
        {
            _response = result;
            _responseMessage.Content = new GetResponseContent(result);
        }
        
        [Given(@"an account service")]
        public void GivenAnAccountService()
        {
            var handler =
                new GetResponseMessageHandler(_responseMessage);

            var client = new Client
            {
                HttpClient = new HttpClient(handler)
            };

            _service = new AccountService(_key, client);
        }

        [Given(@"the following From data")]
        public void GivenTheFollowingFromData(Table table)
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
            _result = _service.GetInfo();
        }
        
        [When(@"I call GetFromFields")]
        public void WhenICallGetFromFields()
        {
            _result = _service.GetFromFields();
        }
        
        [When(@"I call GetFromField with a value of '(.*)'")]
        public void WhenICallGetFromFieldWithAValueOf(string fromId)
        {
            _result = _service.GetFromField(fromId);
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
            Assert.Equal(_response, _result);
        }
    }
}
