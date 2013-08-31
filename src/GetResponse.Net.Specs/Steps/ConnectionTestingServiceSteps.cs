using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using Xunit;
using GetResponse.Net.Service;
using System.Net;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class ConnectionTestingServiceSteps
    {
        private string _key;
        private string _result;
        private HttpResponseMessage _responseMessage;
        private ConnectionTestingService _service;

        [BeforeScenario]
        public void Setup()
        {
            _responseMessage = new HttpResponseMessage();
        }

        [Given(@"a connection testing service status code (.*)")]
        public void GivenAConnectionTestingServiceStatusCode(int statusCode)
        {
            _responseMessage = new HttpResponseMessage((HttpStatusCode)statusCode);
        }

        [Given(@"an connection testing service API key of '(.*)'")]
        public void GivenAnConnectionTestingServiceAPIKeyOf(string key)
        {
            _key = key;
        }

        [Given(@"a connection testing return of  '(.*)'")]
        public void GivenAConnectionTestingReturnOf(string response)
        {
            _responseMessage.Content = new GetResponseContent(response);
        }

        [Given(@"a connection testing service")]
        public void GivenAConnectionTestingService()
        {
            var handler =
                new GetResponseMessageHandler(_responseMessage);

            var client = new Client
            {
                HttpClient = new HttpClient(handler)
            };

            _service = new ConnectionTestingService(_key, client);
        }
        
        [When(@"I call ping")]
        public void WhenICallPing()
        {
            try
            {
                _result = _service.Ping();
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception", ex);
            }
        }
        
        [Then(@"the ping result should be '(.*)'")]
        public void ThenThePingResultShouldBe(string result)
        {
            Assert.Equal(result, _result);
        }
        [Then(@"the connection testing service should throw an error")]
        public void ThenTheConnectionTestingServiceShouldThrowAnError()
        {
            var ex = ScenarioContext.Current["Exception"];
            Assert.Equal(typeof(AggregateException), ex.GetType());
        }
    }
}
