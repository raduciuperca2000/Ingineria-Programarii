using Microsoft.Xrm.Sdk;
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


        public void TrackTimeInTicks(Action<string> action, string executedAlgorithm)
        {
            Console.WriteLine($"[Algoritm : {executedAlgorithm}]" +
                $"");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action(executedAlgorithm);
            stopwatch.Stop();

            DatabaseStorage databaseStorage = new DatabaseStorage();

            databaseStorage.SaveInDataverse(executedAlgorithm, (double)stopwatch.ElapsedTicks);


            Console.WriteLine($"[Timp executie: \x1b[1m{stopwatch.ElapsedTicks} Ticks\x1b[0m]\n");

            
        }



        


    }
}