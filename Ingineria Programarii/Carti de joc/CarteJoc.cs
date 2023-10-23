using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingineria_Programarii.Carti_de_joc
{
    public class CarteJoc
    {
        public char culoare { get; set; }
        public int numar { get; set; }


        public override string ToString()
        {
            return $"{culoare} ${numar}";
        }

        public int this[int i]
        {
            get {
                if(i == 0)
                {
                    return numar;
                }
                else if(i == 1)
                {
                    return culoare;
                }else
                {
                    throw new NotImplementedException();
                }
            }
        }


    }
}
// Test + Proiect