using System;

namespace ConsoleApp1
{
    public class IteradorConjunto : Iterador
    {
        //atributos
        private Conjunto<Comparable> conjunto;
        private int posicion;
        //constructor
        public IteradorConjunto(Conjunto<Comparable> conjunto)
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