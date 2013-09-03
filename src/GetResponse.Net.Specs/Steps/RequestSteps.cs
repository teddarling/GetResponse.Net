using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;
using GetResponse.Net.Service;
using System.Net;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class RequestSteps
    {
        private string _url = "http://api2.getresponse.com";
        private string _expectedResponse;
        private string _key;
        private string _actualResponse;
        private int? _statusCode;
        private Request _request;

        private GetResponseMessageHandler _handler;

        [Given(@"a request URL '(.*)'")]
        public void GivenARequestURL(string url)
        {
            _url = url;
        }
        
        [Given(@"the an api response of '(.*)'")]
        public void GivenTheAnApiResponseOf(string response)
        {
            _expectedResponse = response;

            HttpResponseMessage responseMessage;

            if (_statusCode != null)
                responseMessage = new HttpResponseMessage((HttpStatusCode)_statusCode);
            else
                responseMessage = new HttpResponseMessage();

            responseMessage.Content = new GetResponseContent(response);

            _handler =
                new GetResponseMessageHandler(responseMessage);
        }
        
        [Given(@"a request api key '(.*)'")]
        public void GivenARequestApiKey(string apiKey)
        {
            _key = apiKey;
        }
        
        [Given(@"the following request data")]
        public void GivenTheFollowingRequestData(Table table)
        {
            _request = table.CreateInstance<Request>();
        }
        
        [Given(@"an API return code, (.*)")]
        public void GivenAnAPIReturnCode(int statusCode)
        {
            _statusCode = statusCode;
        }
        
        [When(@"I send my request")]
        public void WhenISendMyRequest()
        {
            var request = new Request
            {
                Id = "1",
                Jsonrpc = "2.0",
                Method = "ping",
                Params = new object[] { _key }
            };

            var client = new Client
            {
                Url = _url,
                HttpClient = new HttpClient(_handler)
            };

            try
            {
                _actualResponse = client.GetResult(request.ToJson());
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception", ex);
            }
        }
        
        [When(@"I send my request with no HttpClient")]
        public void WhenISendMyRequestWithNoHttpClient()
        {
            var request = new Request
            {
                Id = "1",
                Jsonrpc = "2.0",
                Method = "ping",
                Params = new object[] { _key }
            };

            var client = new Client
            {
                Url = _url
            };

            try
            {
                _actualResponse = client.GetResult(request.ToJson());
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception", ex);
            }
        }
        
        [Then(@"the response should be the api response")]
        public void ThenTheResponseShouldBeTheApiResponse()
        {
            Assert.Equal(_expectedResponse, _actualResponse);
        }
        
        [Then(@"the response should throw an '(.*)'")]
        public void ThenTheResponseShouldThrowAn(string exception)
        {
            var ex = ScenarioContext.Current["Exception"];
            var actual = ex.GetType().ToString();
            Assert.Equal(exception, actual);
        }
        
        [Then(@"the response should throw an inner exception '(.*)'")]
        public void ThenTheResponseShouldThrowAnInnerException(string innerException)
        {
            var ex = ScenarioContext.Current["Exception"];
            var actualException = (Exception)ex;
            var actual = actualException.InnerException.GetType().ToString();
            Assert.Equal(innerException, actual);
        }

        [Then(@"the response id should match the api response id")]
        public void ThenTheResponseIdShouldMatchTheApiResponseId()
        {
            var expected = "1";
            var actual = _actualResponse.ToResponse();

            Assert.Equal(expected, actual.Id);
        }

        [Then(@"the response jsonrpc should match the api jsonrpc")]
        public void ThenTheResponseJsonrpcShouldMatchTheApiJsonrpc()
        {
            var expected = "2.0";
            var actual = _actualResponse.ToResponse();

            Assert.Equal(expected, actual.Jsonrpc);
        }
    }
}
