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

        public int minimo()
        {
            if (pila.cuantos() > 0 && cola.cuantos() > 0)
            {
                Comparable minPila = pila.minimo();
                Comparable minCola = cola.minimo();
                if (minPila.sosMenor(minCola)) { return ((Numero)minPila).Valor; }
                else { return ((Numero)minCola).Valor; }
            }
            else
            {
                if (pila.cuantos() > 0) { return ((Numero)pila.minimo()).Valor; }
                else
                {
                    if (cola.cuantos() > 0) { return ((Numero)cola.minimo()).Valor; }
                    else { throw new Exception("Ambas colecciones vacias"); }
                }
            }

        }
        //maximo  Devuelve el elemento de mayor valor entre ambos coleccionables
        public int maximo()
        {
            if (pila.cuantos() > 0 && cola.cuantos() > 0)
            {
                Comparable maxPila = pila.maximo();
                Comparable maxCola = cola.maximo();
                if (maxPila.sosMayor(maxCola)) { return ((Numero)maxPila).Valor; }
                else { return ((Numero)maxCola).Valor; }
            }
            else
            {
                if (pila.cuantos() > 0) { return ((Numero)pila.maximo()).Valor; }
                else
                {
                    if (cola.cuantos() > 0) { return ((Numero)cola.maximo()).Valor; }
                    else { throw new Exception("Ambas colecciones vacias"); }
                }
            }

        }
        //agregar no hace nada   
        public void agregar(Comparable c) { return; }
        //contiene  Devuelve verdadero si el comparable recibid por parámetro está incluido en alguna de las dos colecciones o en ambas y falso en caso contrario
        public bool contiene(Comparable c) { return (pila.contiene(c) || cola.contiene(c)); } //true si lo contiene en alguna de las dos


    }
}