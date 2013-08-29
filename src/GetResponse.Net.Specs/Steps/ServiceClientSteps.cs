using GetResponse.Net.Service;
using GetResponse.Net.Specs.Fakes;
using System;
using System.Net;
using System.Net.Http;
using TechTalk.SpecFlow;
using Xunit;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class ServiceClientSteps
    {
        private string _url;
        private string _request;
        private string _result;
        private GetResponseMessageHandler _handler;
        private int? _statusCode;

        [Given(@"an api URL '(.*)'")]
        public void GivenAnApiURL(string url)
        {
            _url = url;
        }

        [Given(@"a request value of '(.*)'")]
        public void GivenARequestValueOf(string request)
        {
            _request = request;
        }

        [Given(@"an API return value of '(.*)'")]
        public void GivenAnAPIReturnValueOf(string result)
        {
            HttpResponseMessage responseMessage;

            if (_statusCode != null)
                responseMessage = new HttpResponseMessage((HttpStatusCode)_statusCode);
            else
                responseMessage = new HttpResponseMessage();

            responseMessage.Content = new GetResponseContent(result);

            _handler =
                new GetResponseMessageHandler(responseMessage);
        }

        [Given(@"an API status code, (.*)")]
        public void GivenAnAPIStatusCode(int statusCode)
        {
            _statusCode = statusCode;
        }
        
        [When(@"I send a request")]
        public void WhenISendARequest()
        {
            try
            {
                var client = new Client(_url, _handler);
                _result = client.GetResult(_request);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception", ex);
            }
            
        }

        [Then(@"the result should not be '(.*)'")]
        public void ThenTheResultShouldNotBe(string resultJson)
        {
            Assert.NotEqual(resultJson, _result);
        }

        [Then(@"the service result should be '(.*)'")]
        public void ThenTheServiceResultShouldBe(string result)
        {
            Assert.Equal(result, _result);
        }

        [Then(@"the client should throw an error")]
        public void ThenTheClientShouldThrowAnError()
        {
            var ex = ScenarioContext.Current["Exception"];
            Assert.Equal(typeof(AggregateException), ex.GetType());
        }
    }
}
