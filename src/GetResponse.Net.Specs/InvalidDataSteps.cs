using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using Xunit;
using GetResponse.Net.Models;
using System.Net;

namespace GetResponse.Net.Specs
{
    [Binding]
    public class InvalidDataSteps
    {
        private string _response;
        private Api _api;
        private PingResponse _pingResponse;
        private int? _statusCode;

        [Given(@"an invalid params API response, '(.*)'")]
        public void GivenAnInvalidParamsAPIResponse(string response)
        {
            _response = response;
        }

        [Given(@"a parse error API response, '(.*)'")]
        public void GivenAParseErrorAPIResponse(string response)
        {
            _response = response;
        }

        [Given(@"an unsuccessful status code, (.*)")]
        public void GivenAnUnsuccessfulStatusCode(int statusCode)
        {
            _statusCode = statusCode;
        }

        [When(@"I request the ping API method")]
        public void WhenIRequestThePingAPIMethod()
        {
            int statusCode = (_statusCode != null)
                ? Convert.ToInt32(_statusCode) : 200;

            var responseMessage = new HttpResponseMessage((HttpStatusCode)statusCode);

            var response = (!String.IsNullOrEmpty(_response))
                ? _response : "";

            responseMessage.Content = new GetResponseContent(response);

            var messageHandler =
                new GetResponseMessageHandler(responseMessage);

            var client = new HttpClient(messageHandler);

            var key = "valid Key";
            var url = "http://api2.getresponse.com";

            Assert.DoesNotThrow(() =>
                _api = new Api(key, url, client));

            _pingResponse = _api.Ping();
            
        }
        
        [Then(@"the error message should be ""(.*)""")]
        public void ThenTheErrorMessageShouldBe(string message)
        {
            Assert.Equal(message, _pingResponse.Error.Message);
        }
        
        [Then(@"the error code should be (.*)")]
        public void ThenTheErrorCodeShouldBe(int code)
        {
            Assert.Equal(code, _pingResponse.Error.Code);
        }

        [Then(@"the status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(int statusCode)
        {
            Assert.Equal((HttpStatusCode)statusCode, _pingResponse.StatusCode);
        }
    }
}
