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

        /*Función que recibiendo el Nombre y Matricula devuelve un string que contiene los caracteres no repetidos que componen a Nombre y a Matricula 
          separados por comas*/
        public string alfabetoVisible(string Nombre, string Matricula)
        {
            alfabeto = obtenerAlfabeto(Nombre, Matricula);

            int i, insertComa = 1, insertNum = 0;
            string AlfabetoVisible = "";

            //For para crear una cadena visible en el label
            for (i = 0; i < alfabeto.Count; i++)
            {
                try
                {
                    if (i == alfabeto.Count - 1)
                    {
                        AlfabetoVisible = AlfabetoVisible.Insert(insertNum, alfabeto[i].ToString());
                    }
                    else
                    {
                        AlfabetoVisible = AlfabetoVisible.Insert(insertNum, alfabeto[i].ToString());
                        insertNum += 2;

                        AlfabetoVisible = AlfabetoVisible.Insert(insertComa, ",");
                        insertComa += 2;
                    }

                }
                catch (System.ArgumentOutOfRangeException) { continue; }
            }

            return AlfabetoVisible;
        }

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
    }
}
