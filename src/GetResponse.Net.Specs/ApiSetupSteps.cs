using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GetResponse.Net.Specs
{
    [Binding]
    public class ApiSetupSteps
    {
        private string _key;
        private string _url;

        [Given(@"I have an API key, '(.*)'")]
        public void GivenIHaveAnAPIKey(string key)
        {
            _key = key;
        }
        
        [Given(@"I have an API URL, '(.*)'")]
        public void GivenIHaveAnAPIURL(string url)
        {
            _url = url;
        }
        
        [When(@"I instantiate the API")]
        public void WhenIInstantiateTheAPI()
        {
            try
            {
                var api = new Api(_key, _url);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception", ex);
            }
        }
        
        [Then(@"I should receive an ArgumentNullException")]
        public void ThenIShouldReceiveAnArgumentNullException()
        {
            var ex = ScenarioContext.Current["Exception"];
            Assert.Equal(typeof(ArgumentNullException), ex.GetType());
        }
        
        [Then(@"I should not receive an Exception")]
        public void ThenIShouldNotReceiveAnException()
        {
            object ex;
            var hasException = ScenarioContext.Current.TryGetValue("Exception", out ex);
            Assert.False(hasException);
        }
    }
}
