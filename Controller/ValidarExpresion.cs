using System;
using System.Collections.Generic;
using System.Collections;

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

        //Constructor
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
            int posicion = 0;
            bool[] validadores = new bool[5] {false, false, false, false, false};
            Stack pila = new Stack();


            Condiciones cond = new Condiciones();
            //Debe de iniciar con matricula
            validadores[0] = cond.empiezaI( expresion, i);
            posicion = i.Count;

            
            //Debe detener almenos un w dentro de la expresión
            pila = cond.contieneW( expresion, w, posicion);
            if (pila.Count != 0)
            {
                validadores[1] = true;                
            }

            //valida si tiene matricula a casi a mediacion de la expresion
            posicion += pila.Count * w.Count;

            //Variable que guarda el count de la pila pues se me pierde ese valor y la pila se queda sin nada :v
            int aux = pila.Count;

            validadores[2] = cond.medioI( expresion, i, posicion);

            //valida que por cada w haya dos wI
            if (validadores [2] != false)
            {
                posicion += i.Count;
                validadores[3] = cond.contieneWI(expresion, wI, pila, posicion);
            }

            //Valida que la expresion termina con el nombre de tal forma que se repita dos veces consecutivas
            posicion += (aux*w.Count*2);
            validadores[4] = cond.terminaNombre(expresion, j, posicion);

            return validadores;
        }
    }
}