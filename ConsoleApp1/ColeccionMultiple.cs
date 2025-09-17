/*E8 Cree la clase ColeccionMultiple:
ColeccionMultiple
pila  Es una variable que almacena una pila
cola  Es una variable que almacena una cola
constructor(p, c)  Es el constructor de la clase que
recibe un pila “p” y una cola “c” y las
almacena en las variables */
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class ColeccionMultiple : Coleccionable
    {
        //atributos
        private Pila pila;
        private Cola cola;
        // constructor
        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }
        //metodos de coleccionable

        public int cuantos() { return this.pila.cuantos() + this.cola.cuantos(); }

          public Comparable maximo()
        {
            if (this.pila.cuantos() > 0 && this.cola.cuantos() > 0)// me aseguro de que tengan elementos
            {
                Comparable maxPila = this.pila.maximo(); //busco max 
                Comparable maxCola = this.cola.maximo();
                if (maxPila.sosMayor(maxCola)) { return maxPila; } //si el max de la pila es mayor al de la cola devuelvo el de la pila 
                else { return maxCola; }
            }
            else if (this.pila.cuantos() > 0) { return this.pila.maximo(); }// si solo tiene elementos la pila devuelvo el maximo de la pila
            else if (this.cola.cuantos() > 0) { return this.cola.maximo(); }//"""
            else { throw new Exception("Ambas colecciones vacias"); }

        }
        // similar al maximo
        public Comparable minimo()
        {
            if (this.pila.cuantos() > 0 && this.cola.cuantos() > 0)
            {
                Comparable minPila = this.pila.minimo();
                Comparable minCola = this.cola.minimo();
                if (minPila.sosMenor(minCola)) { return minPila; }
                else { return minCola; }
            }
            else if (this.pila.cuantos() > 0) { return this.pila.minimo(); }
            else if (this.cola.cuantos() > 0) { return this.cola.minimo(); }
            else { throw new Exception("Ambas colecciones vacias"); }

        }
        //agregar no hace nada   
        public void agregar(Comparable c) { return; }
        //contiene  Devuelve verdadero si el comparable recibid por parámetro está incluido en alguna de las dos colecciones o en ambas y falso en caso contrario
        public bool contiene(Comparable c) { return (pila.contiene(c) || cola.contiene(c)); } //true si lo contiene en alguna de las dos


    }
}