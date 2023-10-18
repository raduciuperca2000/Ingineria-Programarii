using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingineria_Programarii
{
     public static class Gauss { 

        /// <summary>
        /// Functia aplica Formula Matematica N(N+1) 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long Formula(int n)
         {
            return ((long)n * ((long)n + 1)) / 2;
        }

        /// <summary>
        /// Functia calculeaza valoarea sumei prin ciclarea fiecarui element si adaugarea valori acestuia la o valoare suma
        /// </summary>
        /// <param name="Numar"></param>
        /// <returns></returns>
       public static long Iterative(int n)
        {
            long suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }
    }

}
