using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Theta.BC.Utilities
{
    public static class ConvertToJsonGeneric
    {
        [FunctionName("ConvertToJsonGeneric")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            StreamReader csvReader = new StreamReader(req.Body);
            Token currentToken = null;
            List<Token> result = new List<Token>();

            while (!csvReader.EndOfStream)
            {               
               string line = csvReader.ReadLine();
               if (!string.IsNullOrEmpty(line))
               {
                   if (line.Contains("Group"))
                   {
                       if (currentToken != null)
                       {
                           result.Add(currentToken);
                       }

                       currentToken = new Token();
                       currentToken.Group = line.Split(':')[1];
                   }
                   else if(line.Contains("Fields"))
                   {
                        string fieldLine = csvReader.ReadLine();
                        while (!(string.IsNullOrEmpty(fieldLine) || csvReader.EndOfStream))
                        {
                           Record rec = new Record();
                           rec.Fields.AddRange(fieldLine.Split('|'));
                           currentToken.Records.Add (rec);
                           fieldLine = csvReader.ReadLine();
                        }

                   }
               }
               
            }

            return new OkObjectResult(result);
        }
    }

    public class Token
    {
        public string Group { get; set; }
        public List<Record> Records {get; set; }

        public Token()
        {
            Records = new List<Record>();
        }
    }

    public class Record
    {
        public List<string> Fields {get; set; }

        public Record()
        {
            Fields = new List<string>();
        }
    }
}
