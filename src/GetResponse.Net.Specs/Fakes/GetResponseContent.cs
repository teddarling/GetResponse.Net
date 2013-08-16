using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GetResponse.Net.Specs.Fakes
{
    public class GetResponseContent : HttpContent
    {
        private string _content;

        public GetResponseContent(string content)
        {
            _content = content;
        }

        protected async override Task SerializeToStreamAsync(
            Stream stream, 
            TransportContext context)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(_content);
            await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        protected override bool TryComputeLength(
            out long length)
        {
            length = _content.Length;
            return true;
        }
    }
}