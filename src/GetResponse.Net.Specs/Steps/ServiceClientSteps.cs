using GetResponse.Net.Service;
using GetResponse.Net.Specs.Fakes;
using System;
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
            var responseMessage = new HttpResponseMessage();
            responseMessage.Content = new GetResponseContent(result);

            _handler =
                new GetResponseMessageHandler(responseMessage);
        }
        
        [When(@"I send a request")]
        public void WhenISendARequest()
        {
            var client = new Client(_url, _handler);
            _result = client.GetResult(_request);

            
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
    }
}
