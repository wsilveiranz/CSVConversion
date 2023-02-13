using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Theta.BC.Utilities.Models;

namespace Theta.BC.Utilities
{
    public static class ConvertCsvToItrReport
    {
        [FunctionName("ConvertCsvToItrReport")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            ItrReport result = new ItrReport();
            result.FileName= req.Query["filename"];
            
            StreamReader csvReader = new StreamReader(req.Body);
            string currentGroup = "";

            while (!csvReader.EndOfStream)
            {               
               string line = csvReader.ReadLine();
               if (!string.IsNullOrEmpty(line))
               {
                   if (line.Contains("Group"))
                   {
                       currentGroup = line.Split(':')[1];
                   }
                   else if(line.Contains("Fields"))
                   {
                        string fieldLine = csvReader.ReadLine();
                        while (!(string.IsNullOrEmpty(fieldLine) || csvReader.EndOfStream))
                        {
                            switch(currentGroup)
                            {
                                case "PATIENT" :
                                    result.PATIENT.Add(new Patient(fieldLine));
                                    break;
                                case "STUDY" :
                                    result.STUDY.Add(new Study(fieldLine));
                                    break;                                
                                case "PI" :
                                    result.PI.Add(new Pi(fieldLine));
                                    break;                                
                                case "PD" :
                                    result.PD.Add(new Pd(fieldLine));
                                    break;                                
                                case "ID" :
                                    result.ID.Add(new Id(fieldLine));
                                    break;                                
                                case "PN" :
                                    result.PN.Add(new Pn(fieldLine));
                                    break;                                
                                case "CD" :
                                    result.CD.Add(new Cd(fieldLine));
                                    break;                                
                                case "CA" :
                                    result.CA.Add(new Ca(fieldLine));
                                    break;                                
                                case "ME" :
                                    result.ME.Add(new Me(fieldLine));
                                    break;                                
                                case "METOTAL" :
                                    result.METOTAL.Add(new MeTotal(fieldLine));
                                    break;                                
                                case "CONT1" :
                                    result.CONT1.Add(new Cont1(fieldLine));
                                    break;                                
                                case "CAV" :
                                    result.CAV.Add(new Cav(fieldLine));
                                    break;                                
                                default: break;
                            }
                           fieldLine = csvReader.ReadLine();
                        }

                   }
               }
               
            }

            if (result.STUDY.Count > 0)
            {
                result.StudyDate = result.STUDY[0].STUDATE;
                result.RefNo = result.STUDY[0].REFNO;
            }
            
            return new OkObjectResult(result);
        }
    }
}
