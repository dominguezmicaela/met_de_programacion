//clase pila que implementa la interface coleccionable
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Pila : Coleccionable
    {
        //atributos
        private List<Comparable> elementos;
        //constructor 
        public Pila() { this.elementos = new List<Comparable>(); }
        //metodos 
        // agregar recibe un comparable y lo agrega a la pila 
        public void agregar(Comparable c) { this.elementos.Add(c); }
        //apilar recibe c y lo agrega
        public void apilar(Comparable c) { this.elementos.Add(c); }
        //cuantos retorna la cantidad de elementos que tiene la pila
        public int cuantos() { return this.elementos.Count; }//devuelve la cantidad de elementos en la pila
        public bool contiene(Comparable c)
        {
            if (this.cuantos() > 0)
            {
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.sosIgual(c)) { return true; }
                }
                return false;
            }
            else { throw new Exception("Pila vacia"); }
        }
        public Comparable desapilar()
        {
            if (cuantos() > 0)
            {   Comparable elemento = this.elementos[this.cuantos() - 1];
                this.elementos.RemoveAt(this.cuantos() - 1);
                return elemento;
            }
            else { throw new Exception("Pila vacia"); }
        }
        public Comparable minimo()
        {
            if (this.cuantos() > 0)
            {
                Comparable min = this.elementos[0];
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.sosMenor(min)) { min = elem; }
                }
                return min;
            }
            else { throw new Exception("Pila vacia"); }
        }

        public Comparable maximo()
        {
            if (this.cuantos() > 0)
            {
                Comparable max = this.elementos[0];
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.sosMayor(max)) { max = elem; }
                }
                return max;
            }
            else { throw new Exception("Pila vacia"); }
        }
        public bool estaVacia() { return this.cuantos() == 0; }
    }
    
}