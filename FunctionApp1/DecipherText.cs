
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace FunctionApp1
{
    public class RequestMessage
    {
        public string Key { get; set; }
        public string Msg { get; set; }
        public Dictionary<string, int> Cipher { get; set; }
    }

    public static class DecipherText
    {
        [FunctionName("DecipherText")]
        public static async Task<object> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")]
            HttpRequestMessage req, TraceWriter log)
        {
            var finalText = "";
            log.Info("C# HTTP trigger function processed a request.");
      
            var result = await req.Content.ReadAsStringAsync();
            var jsonContent = JsonConvert.DeserializeObject<RequestMessage>(result);

            var resSplitMessageEnumerable = Split(jsonContent.Msg, 2);

            foreach (var str in resSplitMessageEnumerable)
            {
                foreach (var cipher in jsonContent.Cipher)
                {
                    if (str == cipher.Value.ToString())
                    {
                        finalText += cipher.Key;
                    }
                }
            }

            var jsonResponse = new
            {
                key = jsonContent.Key,
                result = finalText
            };

            return jsonResponse != null
                ? (ActionResult)new OkObjectResult(jsonResponse)
                : new BadRequestObjectResult("Please pass a valid key, msg and cipher text in the request body");
        }

        private static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
