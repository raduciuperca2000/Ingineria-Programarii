using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ingineria_Programarii
{
    public class Interclasare
    {
        public static int[] InterclasareInt(int[] v1, int[] v2)
        {
            int[] returnArray = new int[v1.Length + v2.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < v1.Length && j < v2.Length)
            {
                returnArray[k++] = v1[i] < v2[j] ? v1[i++] : v2[j++];
            }

            while (i < v1.Length)
            {
                returnArray[k++] = v1[i++];
            }

            while (j < v2.Length)
            {
                returnArray[k++] = v2[j++];
            }

            return returnArray;
        }
    }
}
