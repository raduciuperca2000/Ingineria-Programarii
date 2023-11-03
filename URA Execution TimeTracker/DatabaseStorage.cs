using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Rest;
using Microsoft.Xrm.Sdk;

namespace URA_Execution_TimeTracker
{
    internal class DatabaseStorage
    {

        public static string? connectionString { get; set; }
        static DatabaseStorage()
        {
            string InstanceUri = "https://org8e38d34f.crm4.dynamics.com";
            string SecretID = "KzR8Q~zyAKPnQ7d8GHmQ749BrmQipmCE0n_YOcvR";
            string AppID = "cab1054e-f642-4b8f-8bce-c01d99f11049";


            connectionString = $@"AuthType=ClientSecret;
                        SkipDiscovery=true;url={InstanceUri};
                        Secret={SecretID};
                        ClientId={AppID};
                        RequireNewInstance=true";

        }




        public string WhoAmI()
        {
           ServiceClient  serviceClient = new(connectionString);


                if (serviceClient.IsReady)
                {
                    WhoAmIResponse response =
                        (WhoAmIResponse)serviceClient.Execute(new WhoAmIRequest());


                    return $"User ID is {response.UserId}.";


                }
                else
                {
                       return "A web service connection was not established";
                }


        }


        public void SaveInDataverse(string alogrithmName, double executionTime, string inputArray, int phase)
        {
            ServiceClient serviceClient = new(connectionString);


            Entity testEntity = new Entity("cre3f_algorithmrun");
            testEntity["cre3f_name"] = alogrithmName;
            testEntity["cre3f_executiontime"] = executionTime * 1.0f;
            testEntity["cre3f_os"] = Environment.OSVersion.ToString();
            testEntity["cre3f_cpu_identifier"] = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            testEntity["cre3f_cpu_architecture"] = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            testEntity["cre3f_numberofprocessors"] = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");
            testEntity["cre3f_inputarray"] = inputArray;
            testEntity["cre3f_phase"] = phase;



            serviceClient.Create(testEntity);



        }

    }
}
