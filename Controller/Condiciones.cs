using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Condiciones
    {
        public bool EnAlfabeto(string verificar, List<char> alfabeto)
        {
            int cont = 0;

            for (int i = 0; i < verificar.Length; i++)
            {
                for (int j = 0; j < alfabeto.Count; j++)
                {
                    if (alfabeto[j].Equals(verificar[i]))
                    {
                        cont += 1;
                    }
                }
            }

            if (cont == verificar.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
