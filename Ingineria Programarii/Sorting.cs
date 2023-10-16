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
                for (int i = 0; i< inputArray.Length - 1; i++)
                {
                    if (inputArray[i] > inputArray[i+1]) {
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
            for (int i = 0; i < inputArray.Length -1; i++)
            {
                for(int j = i+1; j < inputArray.Length; j++)
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
        /// </summary>
        /// <param name="inputArray"></param>
        public static void CoutingSort(int[] inputArray, int maxValue, bool showOutput = false)
        {
            int[] vectorFrecventa = new int[maxValue + 1];

            for(int i = 0; i < inputArray.Length; i++)
            {
                vectorFrecventa[inputArray[i]]++; 
            }
            for(int i = 0; i<= maxValue; i++)
            {
                while (vectorFrecventa[i]-- > 0 )
                {
                    if (showOutput)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
