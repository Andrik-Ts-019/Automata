using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Alfabeto
    {
        //Creamos la lista que tendra a nuestro alfabeto
        List<char> alfabeto = new List<char>();

        /*Recibiendo como entrada dos string (Nombre y matricula) la función devuelve una lista de caracteres no repetidos que se encuentran 
          en el nombre y la matrícula sin tomar en cuenta el espacio*/
        public List<char> obtenerAlfabeto(string Nombre, string Matricula)
        {
            alfabeto = quitarEspacio(Nombre, Matricula);
            alfabeto = eliminarRepetido(alfabeto);

            return alfabeto;
        }

        /*Recibiendo como entrada dos string (Nombre y matricula) la función devuelve una lista de caracteres que contiene a Nombre y Matrícula sin tomar
          en cuenta el espacio*/
        public List<char> quitarEspacio(string Nombre, string Matricula)
        {

            //Ingresamos el nombre a la lista alfabeto sin que se repita caracteres y sin contar al espacio
            for (int i = 0; i < Nombre.Length; i++)
            {
                if (!Nombre[i].Equals(' '))
                {
                    alfabeto.Add(Nombre[i]);
                }
            }

            //Ingresamos la matricula a la lista alfabeto
            for (int i = 0; i < Matricula.Length; i++)
            {
                if (!Matricula[i].Equals(' '))
                {
                    alfabeto.Add(Matricula[i]);
                }
            }

            //Regresa la lista de tipo char alfabeto
            return alfabeto;
        }

        /*Recibe como entrada una lista de caracteres y la retorna sin caracteres repetidos*/
        public List<char> eliminarRepetido(List<char> alfabeto)
        {
            for (int i = 0; i < alfabeto.Count; i++)
            {
                for (int j = i + 1; j < alfabeto.Count; j++)
                {
                    try
                    {
                        if (alfabeto[i].Equals(alfabeto[j]))
                        {
                            alfabeto.RemoveAt(j);
                            eliminarRepetido(alfabeto);
                        }
                    }
                    catch (System.ArgumentOutOfRangeException) { continue; }
                }
            }
            return alfabeto;
        }
    }
}
