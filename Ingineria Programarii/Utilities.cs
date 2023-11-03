using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingineria_Programarii
{
    public static class Utilities
    {

      public static int[] generateArray(int size, bool sorted = false)
        {
            Random randomGenerator = new Random();
            int[] generatedArray = new int[size];
            generatedArray[0] = randomGenerator.Next(0, 900000000);

            for (int i = 1; i < size; i++)
            {
                if (sorted)
                {
                    generatedArray[i] = generatedArray[i - 1] + randomGenerator.Next(0, 900000000);
                }
                else
                {
                    generatedArray[i] = randomGenerator.Next(0, 900000000);
                }
            }
            return generatedArray;
        }
    }
}
