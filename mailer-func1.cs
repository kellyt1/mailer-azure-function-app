using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace myorg
{
    public class mailer_func1
    {
        private readonly ILogger _logger;

        public mailer_func1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<mailer_func1>();
        }

        [Function("mailer_func1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");
 
            return response;
        }
    }
}
