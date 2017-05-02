using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Microservices.Timetable.Services
{
    public static class JsonStringResultExtension
    {
        /// <summary>
        /// Adds an extension method to any class derived from ApiController.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="jsonContent"></param>
        /// <param name="statusCode"></param>
        /// <returns> A JsonStringResult object containig the request, a status code and the content for the request. </returns>
        public static JsonStringResult JsonString(this ApiController controller, string jsonContent, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            var result = new JsonStringResult(controller.Request, statusCode, jsonContent);
            return result;
        }

        /// <summary>
        /// The result in JSON format returned by methods from API.
        /// </summary>
        public class JsonStringResult : IHttpActionResult
        {
            private readonly string _json;
            private readonly HttpStatusCode _statusCode;
            private readonly HttpRequestMessage _request;

            public JsonStringResult(HttpRequestMessage httpRequestMessage, HttpStatusCode statusCode = HttpStatusCode.OK, string json = "")
            {
                _request = httpRequestMessage;
                _json = json;
                _statusCode = statusCode;
            }

            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {
                return Task.FromResult(Execute());
            }

            private HttpResponseMessage Execute()
            {
                var response = _request.CreateResponse(_statusCode);
                response.Content = new StringContent(_json, Encoding.UTF8, "application/json");
                return response;
            }
        }
    }
}