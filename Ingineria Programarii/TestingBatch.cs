using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URA_Execution_TimeTracker;

namespace Ingineria_Programarii
{
    internal class TestingBatch
    {
        public int batchPhase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="batchPhases"></param>
        public TestingBatch(int batchPhase)
        {
            this.batchPhase = batchPhase;
        }

        public void Run()
        {
            int currentPhase = 0;
            ExecutionTimeTracker executionTimeTracker = new ExecutionTimeTracker();

            Console.WriteLine("\n\n\nTESTING PHASE STARTED");

            do
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine($"PHASE #{currentPhase++} Array Dimension 10^ {currentPhase}");

                int[] generatedArray = new int[(int)Math.Pow(10, currentPhase)];
                int[] usedArray = new int[(int)Math.Pow(10, currentPhase)];
                generatedArray = Utilities.generateArray(generatedArray.Length, false);
                //executionTimeTracker.TrackTimeInTicks(
                //(string algo) => Search.LinearSearch(generatedArray, generatedArray[3]), "Linear Seach");

                //executionTimeTracker.TrackTimeInTicks(
                //    (string algo) => Search.BinarySearch(generatedArray, generatedArray[3]), "Binary Search");


                Array.Copy(generatedArray,usedArray, generatedArray.Length);

                executionTimeTracker.TrackTimeInTicks(
                (string algo) => Sorting.BubbleSort(usedArray),usedArray, "Metoda Bulelor", currentPhase);


                Array.Copy(generatedArray, usedArray, generatedArray.Length);

                executionTimeTracker.TrackTimeInTicks(
                    (string algo) => Sorting.SelectionSort(usedArray), usedArray, "Metoda Sortari prin selectie", currentPhase);


                Array.Copy(generatedArray, usedArray, generatedArray.Length);

                executionTimeTracker.TrackTimeInTicks(
                (string algo) => Sorting.CoutingSort(usedArray,  usedArray.Max()), usedArray, "Sortarea cu vector de frecventa", currentPhase);

                Array.Copy(generatedArray, usedArray, generatedArray.Length);

                executionTimeTracker.TrackTimeInTicks(
                (string Algo) => Sorting.MergeSort(usedArray, 0, usedArray.Length - 1), usedArray, "Merge Sort", currentPhase);



            } while (currentPhase <= this.batchPhase);
        }
    }
}
