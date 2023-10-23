using System;
using System.Diagnostics;

namespace URA_Execution_TimeTracker
{
    public class ExecutionTimeTracker
    {


        public void TrackTimeInTicks(Action<string> action, string executedAlgorithm)
        {
            Console.WriteLine($"[Algoritm : {executedAlgorithm}]" +
                $"");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action(executedAlgorithm);
            stopwatch.Stop();

            Console.WriteLine($"[Timp executie: \x1b[1m{stopwatch.ElapsedTicks} Ticks\x1b[0m]\n");
        }


        // 
        


    }
}