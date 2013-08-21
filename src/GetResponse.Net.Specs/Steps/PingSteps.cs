using GetResponse.Net.Models;
using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using Xunit;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class PingSteps
    {
        private string _apiKey;
        private string _apiUrl;
        private string _response;
        private HttpClient _httpClient;
        private Api _api;
        private PingResponse _pingResponse;

        [Given(@"the following API response '(.*)'")]
        public void GivenTheFollowingAPIResponse(string response)
        {
            _response = response;
        }

        [When(@"I send a ping request")]
        public void WhenISendAPingRequest()
        {
            var responseMessage = new HttpResponseMessage();

            var response = (!String.IsNullOrEmpty(_response))
                ? _response : "";

            responseMessage.Content = new GetResponseContent(response);

            var messageHandler =
                new GetResponseMessageHandler(responseMessage);

            var client = new HttpClient(messageHandler);

            var key = "valid Key";
            var url = "http://api2.getresponse.com";

            _api = new Api(key, url, client);
            _pingResponse = _api.Ping();
        }

        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string apiResponse)
        {
            Assert.Equal(apiResponse, _pingResponse.Result.Ping);
        }

    }
}
