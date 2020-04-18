using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Gramatica
    {
        /*Devuelve la matricula ingresada en una list*/
        public List<char> obtenerMatricula(string Matricula)
        {
            //Variable que guarda la matricula de la persona
            List<char> i = new List<char>();

            Alfabeto alf = new Alfabeto();
            i = alf.quitarEspacio(Matricula,"");
            return i;
        }

        /*Devuelve una list que unicamente contiene el nombre de la persona guardando los primeros caracteres antes de un espacio, sin incluir al espacio, 
          iniciando en la pocision 0*/
        public List<char> obtenernombre(string Nombre)
        {
            //guarda el primer nombre de la persona
            List<char> j = new List<char>();

            for (int i = 0; i<Nombre.Length; i++)
            {
                //Empesamos a recorrer el string Nombre para empezar a guardar en donde no haya espacios
                if (!Nombre[i].Equals(' '))
                {
                    for (int k=i; k<Nombre.Length;k++)
                    {
                        if (!Nombre[k].Equals(' '))
                        {
                            j.Add(Nombre[k]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
            }
            return j;
        }

        /*Devuelve una list que contiene las iniciales de los apellidos valiendose de los espacios, dependiendo del numero que reciba opc devolvera la
          lista de manera normal o invertida*/
        public List<char> obteneriniciales(string Apellido, int opc)
        {
            int i = 0;
             //Variable que guarda las iniciales de los apellidos de la persona
             List<char> w = new List<char>();

            //Recorre el string Apellido hasta que no haya espacio al inicio
            while (Apellido[i].Equals(' '))
            {
                i += 1;
            }

            w.Add(Apellido[i]);

            for (; i < Apellido.Length - 1; i++)
            {
                if (Apellido[i].Equals(' ') && !Apellido[i + 1].Equals(' '))
                {
                    w.Add(Apellido[i + 1]);
                }
            }

            switch (opc)
            {
                case 1:
                    return w;

                case 2:
                    return listaInvertida(w);
                
                default:
                    return null;
            }
        }

        /*Devuelve la list que recibe como parametro de manera invertida*/
        public List<char> listaInvertida(List<char> w)
        {
            List<char> invertido = new List<char>();

            for (int i=0; i<w.Count(); i++)
            {
                invertido.Add(w[w.Count()-1-i]);
            }

            return invertido;
        }
    }
}
