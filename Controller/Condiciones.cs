using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Condiciones
    {
        
        //Verifica que se todos los caracteres ingresados pertenescan al alfabeto que recibe de entrada
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

        /*Aprovecha el try y catch para saber si matricula está constituida de puros números, si esto es verdadero retorna true, en caso contrario retorna 
          false*/
        public bool validadorMatricula(string Matricula)
        {
            try
            {
                int mat = int.Parse(Matricula);
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
        }

        //Verifica que los primeros k espacios sean iguales al contenido de i
        public bool empiezaI(string expresion, List<char> i)
        {
            bool validador1 = false;

            try
            {
                for (int k = 0; k < i.Count; k++)
                {
                    if (!expresion[k].Equals(i[k]))
                    {
                        return validador1;
                    }
                }
                return !validador1;
            }
            catch (System.IndexOutOfRangeException)
            {
                return validador1;
            }
        }
    }
}
