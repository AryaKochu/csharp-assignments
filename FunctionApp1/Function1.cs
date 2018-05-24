using System;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.AspNetCore.Mvc;

namespace FunctionApp1
{
    class PingResponseClass
    {
        public string Ping { get; set; }
    }

    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<object> Run([HttpTrigger(AuthorizationLevel.Anonymous, "POST")]
            HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");
            var result = await req.Content.ReadAsStringAsync();
            var jsonContent = JsonConvert.DeserializeObject<PingResponseClass>(result);

            if (jsonContent?.Ping == null)
            {
                return req.CreateErrorResponse(HttpStatusCode.BadRequest, "Please pass a ping guid to ping back.");
            }
            var pongResponse = new
            {
                pong = jsonContent?.Ping
            };

            var resultant = JsonConvert.SerializeObject(pongResponse);

            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(resultant)
            };
            resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return resp;
        }
    }
}
