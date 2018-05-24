using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.AspNetCore.Mvc;

namespace FunctionApp2
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
        {
            log.Info($"Webhook was triggered!");
            dynamic jsonContent = await req.Content.ReadAsAsync<object>();
            log.Info($"requestBody: {JsonConvert.SerializeObject(jsonContent)}");

            if (jsonContent?.ping == null)
            {
                return req.CreateResponse(HttpStatusCode.BadRequest, new
                {
                    error = "Please pass a ping guid to pingback"
                });
            }
            var pongResponse = new
            {
                pong = jsonContent?.ping
            };

            return req.CreateResponse(HttpStatusCode.OK, pongResponse);
        }
    }
}
