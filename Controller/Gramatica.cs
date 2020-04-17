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
            j = alf.quitarEspacio(Matricula,"");
            return i;
        }

        public List<char> obtenernombre(string Nombre)
        {
            for (int i=0; i<Nombre.Length; i++)
            {
                if (!Nombre[i].Equals(' '))
                {
                    j.Add(Nombre[i]);
                }
                else
                {
                    break;
                }
            }
            return j;
        }

        public List<char> obteneriniciales(string Nombre)
        {
            for (int i=Nombre.Length; i>=0; i--)
            {

            }
            return w;
        }
    }
}
