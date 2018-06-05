
using System;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;

namespace SortArray
{
    public static class SortDataFunction
    {
        [StorageAccount("AzureWebJobsStorage")]
        [FunctionName("SortDataFunction")]
        public static async Task<object> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")]
            HttpRequestMessage req,
            [Table("RandomArrays")] CloudTable randomArraysTable, 
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");


            dynamic requestBody = await req.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<RequestMessage>(requestBody);

            var tableData = await randomArraysTable.ExecuteAsync(TableOperation.Retrieve<RequestModel>(data.Key, data.Key));

            string values = tableData.Result.Value;
            int[] arrayValues = values.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Array.Sort(arrayValues);

            var response = new
            {
                data.Key,
                ArrayOfValues = arrayValues
            };

            var resultant = JsonConvert.SerializeObject(response);

            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(resultant)
            };
            resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return resp;
        }
    }
}
