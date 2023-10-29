using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingineria_Programarii
{
    public class Sorting
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputArray"></param>
        public static void BubbleSort(int[] inputArray)
        {
            bool isSorted;


            do
            {
                isSorted = true;
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i] > inputArray[i + 1]) {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[i + 1];
                        inputArray[i + 1] = temp;
                        isSorted = false;
                    }
                }
            } while (isSorted = false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputArray"></param>
        public static void SelectionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Folosim o valoare intermediara pentru a facilita o singura inlocuire in ciclul iterativ
        /// </summary>
        /// <param name="inputArray"></param>
        public static void SelectionSortImproved(int[] inputArray)
        {
            int jMinim;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                jMinim = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[jMinim] > inputArray[j])
                    {
                        jMinim = j;
                    }
                }
                int temp = inputArray[i];
                inputArray[i] = inputArray[jMinim];
                inputArray[jMinim] = temp;
            }
        }

        /// <summary>
        /// Example Input { 1, 3, 6, 3, 2, 7, 8, 9 }
        /// // Vector de frecventa
        //                      0 1 2 3 4 5 6 7 8 9
        //                      0 1 1 2 0 0 1 1 1 1
        //  Presupunem ca lucram pe N
        //  Complexitate O(N)
        /// </summary>
        /// <param name="inputArray"></param>
        public static void CoutingSort(int[] inputArray, int maxValue, bool showOutput = false)
        {
            int[] vectorFrecventa = new int[maxValue + 1];

            for (int i = 0; i < inputArray.Length; i++)
            {
                vectorFrecventa[inputArray[i]]++;
            }
            for (int i = 0; i <= maxValue; i++)
            {
                while (vectorFrecventa[i]-- > 0)
                {
                    if (showOutput)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }


        public static int[] MergeSort(int[] inputArray, int left, int right)
        {
            // 1. Find the midle of the array
            // Left + Right /2 

            int mid = (left + right) / 2;

            if (left < right)
            {
                MergeSort(inputArray, left, mid);
                MergeSort(inputArray, mid + 1, right);

                int[] leftArray = new int[mid - left + 1];
                int[] rightArray = new int[right - mid];
                Array.Copy(inputArray, left, leftArray, 0, leftArray.Length);
                Array.Copy(inputArray, mid + 1, rightArray, 0, rightArray.Length);

                int[] sorted = Interclasare.InterclasareInt(leftArray, rightArray);

                Array.Copy(sorted, 0, inputArray, left, sorted.Length);
            }
            return inputArray;

        }
        /// <summary>
        /// Sortare pe cozi
        /// </summary>
        /// <param name="inputArray"></param>
        //public static void DistributionSort(int[] inputArray)
        //{

        //    int p = 0;
        //    int k = 3;
        //    int putere = 1;

        //    List<int>[] cozi = new List<int>[10];

        //    for (int i = 0; i < cozi.Length; i++)
        //    {
        //        cozi[i] = new List<int>();
        //    }

        //    for (int j = 0; j < k; j++)
        //    {

        //        int modulo = (int)Math.Pow(10, j);
        //        foreach (int i in inputArray)
        //        {
        //            cozi[i / modulo % 10].Add(i);
        //        }

        //        foreach (List<int> i in cozi)
        //        {

        //            foreach (int j in i)
        //            {
        //                Console.WriteLine($"Elemetul {j}");
        //                inputArray[p++] = j;
        //            }
        //            i.Clear();


        //        }


        //        putere = putere * 10;
        //    }
        //}

    } 
}



//int[] x = { 123, 234, 651, 645, 861, 255, 907 };
//int k = 3;

//List<int>[] cozi = new List<int>[10];

//// Initializing empty lists
//for (int i = 0; i < 10; i++)
//{
//    cozi[i] = new List<int>();
//}

//int putere = 1;
//for (int j = 0; j < k; j++)
//{
//    foreach (int i in x)
//    {
//        cozi[i / putere % 10].Add(i);
//    }

//    int p = 0;
//    foreach (List<int> i in cozi)
//    {
//        foreach (int z in i)
//        {
//            Console.Write(z + " ");
//            x[p++] = z;
//        }
//    }
//    Console.WriteLine();

//    for (int i = 0; i < 10; i++)
//    {
//        cozi[i].Clear();
//    }

    