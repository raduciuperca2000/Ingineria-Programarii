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
             string SecretID = "SID1";
             string AppID = "SID2";


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


        public void SaveInDataverse(string AlogrithmName, double ExecutionTime)
        {
            ServiceClient serviceClient = new(connectionString);


            Entity testEntity = new Entity("cre3f_algorithmrun");
            testEntity["cre3f_name"] = AlogrithmName;
            testEntity["cre3f_executiontime"] = ExecutionTime * 1.0f;
            testEntity["cre3f_os"] = Environment.OSVersion.ToString();
            //testEntity["cre3f_cpuidentifier"] = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            //testEntity["cre3f_cpuidentifier"] = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            //testEntity["cre3f_cpuidentifier"] = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");



            serviceClient.Create(testEntity);



        }

    }
}
