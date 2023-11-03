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
            } while (isSorted == false);
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



        //QuickSort
        public static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }




        //HeapSort

        public static void heapSort<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            buildMaxHeap(array);

            for (int i = heapSize - 1; i >= 1; i--)
            {
                swap(array, i, 0);
                heapSize--;
                sink(array, heapSize, 0);
            }
        }

        public static void buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                sink(array, heapSize, i);
            }
        }

        public static void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
        {
            if (getLeftKidPos(toSinkPos) >= heapSize)
            {
                // No left kid => no kid at all
                return;
            }


            int largestKidPos;
            bool leftIsLargest;

            if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
            {
                largestKidPos = getLeftKidPos(toSinkPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = getRightKidPos(toSinkPos);
                leftIsLargest = false;
            }



            if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
            {
                swap(array, toSinkPos, largestKidPos);

                if (leftIsLargest)
                {
                    sink(array, heapSize, getLeftKidPos(toSinkPos));

                }
                else
                {
                    sink(array, heapSize, getRightKidPos(toSinkPos));
                }
            }

        }

        public static void swap<T>(T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;
        }

        public static int getLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        public static int getRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }


        //Bucket sort


        public static void bucketSort(float[] arr, int n)
        {
            if (n <= 0)
                return;

            // 1) Create n empty buckets
            List<float>[] buckets = new List<float>[n];

            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<float>();
            }

            // 2) Put array elements in different buckets
            for (int i = 0; i < n; i++)
            {
                float idx = arr[i] * n;
                buckets[(int)idx].Add(arr[i]);
            }

            // 3) Sort individual buckets
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }

            // 4) Concatenate all buckets into arr[]
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }




        //BogoSort

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        // To check if array is sorted or not
        public static bool isSorted(int[] a, int n)
        {
            int i = 0;
            while (i < n - 1)
            {
                if (a[i] > a[i + 1])
                    return false;
                i++;
            }
            return true;
        }

        // To generate permutation of the array
        public static void shuffle(int[] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                Swap(ref a[i], ref a[rnd.Next(0, n)]);
        }

        // Sorts array a[0..n-1] using Bogo sort
        public static void bogosort(int[] a, int n)
        {
            // if array is not sorted then shuffle
            // the array again
            while (!isSorted(a, n))
                shuffle(a, n);
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

    