using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace URA_Execution_TimeTracker
{
    public class ExecutionTimeTracker
    {

        //static ExecutionTimeTracker()
        //{
        //    DatabaseStorage databaseStorage = new DatabaseStorage();
        //    Console.WriteLine(databaseStorage.WhoAmI()); ;
        //}


        public void TrackTimeInTicks(Action<string> action, int[] inputArray, string executedAlgorithm = "Unknow Algorithm", int phase = -1)
        {
            Console.WriteLine($"[Algoritm : {executedAlgorithm}]" +
                $"");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action(executedAlgorithm);
            stopwatch.Stop();

            DatabaseStorage databaseStorage = new DatabaseStorage();
            string inputArrayJSON = JsonConvert.SerializeObject(inputArray);
            databaseStorage.SaveInDataverse(executedAlgorithm, (double)stopwatch.ElapsedTicks, inputArrayJSON, phase);


            Console.WriteLine($"[Timp executie: \x1b[1m{stopwatch.ElapsedTicks} Ticks\x1b[0m]\n");

            
        }



        


    }
}