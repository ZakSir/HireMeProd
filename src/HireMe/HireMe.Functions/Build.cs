using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace HireMe.Functions
{
    public static class Build
    {
        [FunctionName("BuildTrigger")]
        public static async Task<HttpResponseMessage> Run(
            [HttpTrigger(AuthorizationLevel.Function, "GET", "POST")] HttpRequestMessage req,
            TraceWriter log)
        {
            log.Info("first");

            return req.CreateResponse(HttpStatusCode.OK, "First");
        }
    }
}
