using System;
using System.Collections.Generic;
using System.Collections;
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

        /*Verifica que los primeros k espacios sean iguales al contenido de i*/
        public bool empiezaI(string expresion, List<char> i)
        {
            try
            {
                for (int k = 0; k < i.Count; k++)
                {
                    if (!expresion[k].Equals(i[k]))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
        }

        /*Devuelve un stack que va aumentando de contenido segun la cantidd de w que se encuentren de forma consecutiva en la expresion*/
        public Stack contieneW(string expresion, List<char> w, int posicion)
        {
            Stack pila2 = new Stack();

            //Indicador que nos dirá cuantas w meter a la pila
            string inicialesapellido = "";

            //recorre toda la expresion buscando cuantas veces se repite w dentro de expresion de manera consecutiva
            for (int i = posicion; i < expresion.Length;)
            {
                try
                {
                    //recorre w y verifica cada 4 caracteres si se encuentra desde i hasta que ya no haya más
                    for (int k = 0; k < w.Count; k++)
                    {
                        if (expresion[i + k].Equals(w[k]))
                        {
                            inicialesapellido += expresion[i + k];

                            //En caso de tener las iniciales consecutivas agregamos una w a la pila
                            if (inicialesapellido.Equals(string.Join("", w)))
                            {
                                pila2.Push("w");
                                inicialesapellido = "";
                            }
                        }
                        else
                        {
                            return pila2;
                        }
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    return pila2;
                }
                i += w.Count;
            }
            return pila2;
        }

        /*Verifica que i se encuentre cerca de la mediacion de la cadena */
        public bool medioI(string expresion, List<char> i, int posicion)
        {
            bool validador2 = false;
            int cont = 0;
            try
            {
                for (int j=posicion; j<posicion+i.Count; j++)
                {
                    if (!expresion[j].Equals(i[cont]))
                    {
                        return validador2;
                    }
                    cont += 1;
                }
                return !validador2;
            }
            catch(System.IndexOutOfRangeException)
            {
                return validador2;
            }
        }

        /*Verifica que setenga wI de tal forma que por cada w haya dos wI*/
        public bool contieneWI(string expresion, List<char> wI, Stack p, int posicion)
        {
            Stack pila2 = new Stack();
            string aux = "";
            pila2 = p;

            if (pila2.Count != 0)
            {
                try
                {
                    int count = posicion + 2 * (p.Count * wI.Count);
                    for (int i = posicion; i < count;)
                    { 
                        for (int j = 0; j < wI.Count; j++)
                        {
                            if (expresion[i + j].Equals(wI[j]))
                            {
                                aux += wI[j];
                                if (aux == string.Join("", wI) + string.Join("", wI))
                                {
                                    pila2.Pop();
                                    aux = "";
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        i += wI.Count;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    return false;
                }
                if (pila2.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /*Varifica que la expresion ingresada termine con el Nombre repetido dos veces de forma consecutiva*/
        public bool terminaNombre(string expresion, List<char> j, int posicion)
        {
            Console.WriteLine("\nValor de posicion: " + posicion);
            if (expresion.Length == posicion + 2 * (j.Count))
            {
                try
                {
                    for (int i = posicion; i < expresion.Length;)
                    {
                        for (int k = 0; k < j.Count; k++)
                        {
                            if (!expresion[i + k].Equals(j[k]))
                            {
                                return false;
                            }
                        }
                        i += j.Count;
                    }
                    return true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}