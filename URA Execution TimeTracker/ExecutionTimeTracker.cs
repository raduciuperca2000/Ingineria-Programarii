using System;
using System.Diagnostics;

namespace URA_Execution_TimeTracker
{
    public class ExecutionTimeTracker
    {
        public delegate long AlogirthmLong(int x);


        public void TrackTimeInTicks(AlogirthmLong action ,  int x)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action(x);
            stopwatch.Stop();

            Console.WriteLine($"Timpul de executie {stopwatch.ElapsedTicks} Ticks");
        }


        public void TrackTimeInTicks(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action();
            stopwatch.Stop();

            Console.WriteLine($"Timpul de executie {stopwatch.ElapsedTicks} Ticks");
        }



        public void TrackTimeInMiliseconds(AlogirthmLong action, int x)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action(x);
            stopwatch.Stop();

            Console.WriteLine($"Timpul de executie {stopwatch.ElapsedMilliseconds} Miliseconds");
        }

        


    }
}