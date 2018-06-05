using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;

namespace SortArray
{
    public class RequestModel : TableEntity
    {
      public string Value { get; set; }
    }
    public static class QueueFunction
    {
        [FunctionName("QueueFunction")]
        public static void Run([QueueTrigger("myqueue-items")]
            RequestMessage myQueueItem,
            [Table("RandomArrays")] CloudTable randomArraysTable,
            TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
            var dataEntry = new RequestModel()
            {
                PartitionKey = myQueueItem.Key,
                RowKey = myQueueItem.Key,
                Value = string.Join(" ",myQueueItem.ArrayOfValues)
            };
            randomArraysTable.ExecuteAsync(TableOperation.Insert(dataEntry));
        }
    }
}
