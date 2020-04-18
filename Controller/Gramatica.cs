using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Gramatica
    {
        //Variable que guarda las iniciales de los apellidos de la persona
        public List<char> w = new List<char>();
        //Variable que guarda la matricula de la persona
        public List<char> i = new List<char>();
        //guarda el primer nombre de la persona
        public List<char> j = new List<char>();

        /*Devuelve la matricula ingresada en una list*/
        public List<char> obtenerMatricula(string Matricula)
        {
            Alfabeto alf = new Alfabeto();
            i = alf.quitarEspacio(Matricula,"");
            return i;
        }

        /*Devuelve una list que unicamente contiene el nombre de la persona guardando los primeros caracteres antes de un espacio, sin incluir al espacio, 
          iniciando en la pocision 0*/
        public List<char> obtenernombre(string Nombre)
        {
            for (int i=0; i<Nombre.Length; i++)
            {
                //Empesamos a recorrer el string Nombre para empezar a guardar en donde no haya espacios
                if (!Nombre[i].Equals(' '))
                {
                    //Para de guardar cuando encuentres el primer espacio o llegues al limite de la cadena
                    while (!Nombre[i].Equals(' ') && i<Nombre.Length)
                    {
                        j.Add(Nombre[i]);
                        i += 1;
                    }
                    break;
                }
            }
            return j;
        }

        /*Devuelve una list que contiene las iniciales de los apellidos valiendose de los espacios*/
        public List<char> obteneriniciales(string Apellido)
        {
            int i = 0;

            //Recorre el string Apellido hasta que no haya espacio al inicio
            while(Apellido[i].Equals(' ')){
                i += 1;
            }

            w.Add(Apellido[i]);

            for (; i<Apellido.Length-1; i++)
            {
                if (Apellido[i].Equals(' ') && !Apellido[i+1].Equals(' '))
                {
                    w.Add(Apellido[i+1]);
                }
            }
            return w;
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

        /*Devuelve una list que contiene al contenido del string, que recibe como parametro, de manera inversa*/
        public List<char> wInvertidoStr(string Apellido)
        {
            List<char> invertido = new List<char>();

            invertido = obteneriniciales(Apellido);
            invertido = listaInvertida(invertido);

            return invertido;
        }
    }
}
