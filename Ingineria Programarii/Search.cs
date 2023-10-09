using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingineria_Programarii
{
    static public class Search
    {
       public static int LinearSearch(int[] initialArray, int searchedItem)
        {

            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i] == searchedItem)
                {
                    return i;
                }
            }
            // Not found case
            return -1;
        }


        public static int BinarySearch(int[] initialArray, int searchedItem)
        {
            //Vectorul trebuie sa fie neaparat sortat


            //Capat start 
            int p = 0;
            //Capat stop
            int u = initialArray.Length - 1;

            while (p <= u)
            {
                int mijloc = (p + u) / 2;
                //`Console.WriteLine("Valoarea mijlocului: " + initialArray[mijloc]);
                if (searchedItem == initialArray[mijloc])
                {
                    return mijloc;
                }
                else if (searchedItem > initialArray[mijloc])
                {
                    p = 1 + mijloc;
                }
                else
                {
                    u = mijloc - 1;
                }
            }

            //case of not found
            return -1;
        }

    }
}
