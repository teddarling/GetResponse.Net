using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GetResponse.Net.Specs.Fakes
{
    public class GetResponseMessageHandler 
        : HttpMessageHandler
    {
        private HttpResponseMessage _response;

        public GetResponseMessageHandler(
            HttpResponseMessage response)
        {
            _response = response;
        }
        
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, 
            CancellationToken cancellationToken)
        {
            var responseMessage =
                new TaskCompletionSource<HttpResponseMessage>();

            responseMessage.SetResult(_response);

            return responseMessage.Task;
        }
    }
}
