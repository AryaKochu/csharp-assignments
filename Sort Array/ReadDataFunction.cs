
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace SortArray
{
    public class RequestMessage {
        public string Key { get; set; }
        public List<int> ArrayOfValues { get; set; }
    }
    public static class ReadDataFunction
    {
        [FunctionName("ReadDataFunction")]
        public static async Task<object> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestMessage req,
            [Queue("myqueue-items")] ICollector<RequestMessage> queue,
             TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            var request = await req.Content.ReadAsStringAsync();
            var requestMessage = JsonConvert.DeserializeObject<RequestMessage>(request);
            queue.Add(requestMessage);

            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}")
            };
            resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return resp;
        }
    }
}
