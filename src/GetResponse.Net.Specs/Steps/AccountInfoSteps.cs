using GetResponse.Net.Specs.Fakes;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using Xunit;
using GetResponse.Net.Models;

namespace GetResponse.Net.Specs.Steps
{
    [Binding]
    public class AccountInfoSteps
    {
        private string _response;
        private AccountInfoResponse _infoResponse;
        private Api _api;

        [Given(@"the following Account Info API response '(.*)'")]
        public void GivenTheFollowingAccountInfoAPIResponse(string response)
        {
            _response = response;
        }
        
        [When(@"I send an account info request")]
        public void WhenISendAnAccountInfoRequest()
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
            _infoResponse = _api.AccountInfo();
        }
        
        [Then(@"the from name should be '(.*)'")]
        public void ThenTheFromNameShouldBe(string name)
        {
            Assert.Equal(name, _infoResponse.Result.FromName);
        }
        
        [Then(@"the from email should be '(.*)'")]
        public void ThenTheFromEmailShouldBe(string email)
        {
            Assert.Equal(email, _infoResponse.Result.FromEmail);
        }
        
        [Then(@"the login should be '(.*)'")]
        public void ThenTheLoginShouldBe(string login)
        {
            Assert.Equal(login, _infoResponse.Result.Login);
        }
    }
}
