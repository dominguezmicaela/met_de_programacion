using System;

namespace ConsoleApp1
{
    public class IteradorConjunto<T>: Iterador where T:Comparable
    {
        //atributos
        private Conjunto<T> conjunto;
        private int posicion;
        //constructor
        public IteradorConjunto(Conjunto<T> conjunto)
        {
            this.conjunto = conjunto;
            this.posicion = 0;

        }
        //metodos
        public void primero() { this.posicion = 0; }
        public void siguiente() { this.posicion++; }
        public bool fin() { return posicion >= conjunto.cuantos(); }
        public Comparable actual(){ return conjunto.getElem()[posicion]; }

    }
    
}