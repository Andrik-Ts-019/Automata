using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ValidarExpresion
    {
        //Lista que guarda  el la matricula
        public List<char> i = new List<char>();
        //Lista que guarda el nombre
        public List<char> j = new List<char>();
        //Lista que guarda la(s) inicial(es) de(l) (los) apellido(s)
        public List<char> w = new List<char>();
        //Lista que guarda la(s) inicial(es) de(l) (los) apellido(s) demanera inversa
        public List<char> wI = new List<char>();

        public ValidarExpresion(string Nombre, string Apellido, string Matricula)
        {
            Gramatica gramar = new Gramatica();
            this.i = gramar.obtenerMatricula(Matricula);
            this.j = gramar.obtenernombre(Nombre);
            this.w = gramar.obteneriniciales(Apellido,1);
            this.wI = gramar.obteneriniciales(Apellido,2);
        }

        //Verifica que los primeros k espacios sean iguales al contenido de i
        public bool[] validar(string expresion)
        {
            //int posicion = 0;
            bool[] validadores = new bool[5] {false, false, false, false, false};

            Condiciones cond = new Condiciones();
            validadores[0] = cond.empiezaI(expresion,i);

            return validadores;
        }
    }
}