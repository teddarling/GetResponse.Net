using GetResponse.Net.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GetResponse.Net.Tests
{
    public class RequestTests
    {
        [Fact]
        public void ConvertRequestToJson()
        {
            // Arrange
            var request = new Request
            {
                Id = "1",
                Jsonrpc = "2.0",
                Method = "ping",
                Params = new object[] { "valid api key" }
            };

            var expected = "{\"id\":\"1\",\"jsonrpc\":\"2.0\",\"method\":\"ping\",\"params\":[\"valid api key\"]}";

            // Act
            string actual = request.ToJson();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
