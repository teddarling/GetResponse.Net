using GetResponse.Net.Model;
using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using Xunit;

namespace GetResponse.Net.Specs
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

        [Given(@"I have a valid API key '(.*)'")]
        public void GivenIHaveAValidAPIKey(string apiKey)
        {
            _apiKey = apiKey;
        }

        [Given(@"valid Api URL '(.*)'")]
        public void GivenValidApiURL(string url)
        {
            _apiUrl = url;
        }

        [Given(@"a valid HttpClient with the following response '(.*)'")]
        public void GivenAValidHttpClientWithTheFollowingResponse(string apiResponse)
        {
            _response = apiResponse;

            // Setup the HttpClient with fake data.
            var responseMessage = new HttpResponseMessage();
            responseMessage.Content = new GetResponseContent(apiResponse);
            var messageHandler = new GetResponseMessageHandler(responseMessage);
            _httpClient = new HttpClient(messageHandler);
            _httpClient.BaseAddress = new Uri(_apiUrl);
        }

        [When(@"I send a ping request")]
        public void WhenISendAPingRequest()
        {
            _api = new Api(_apiKey, _apiUrl, _httpClient);
            _pingResponse = _api.Ping();
        }

        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            PingResponse response = new PingResponse();
            response.Id = "1";
            response.Jsonrpc = "2.0";
            response.Result = _response;

            Assert.Equal(response.Id, _pingResponse.Id);
            Assert.Equal(response.Jsonrpc, _pingResponse.Jsonrpc);
            Assert.Equal(response.Result, _pingResponse.Result);
        }
    }
}
