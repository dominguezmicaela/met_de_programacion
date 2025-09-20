using System;
namespace ConsoleApp1
{
    public class IteradorCola<T> : Iterador where T : Comparable
    {
        //atributos
        private Cola cola;
        private int posicion;
        //constructor´
        public IteradorCola(Cola cola)
        {
            this.cola = cola;
            this.posicion = 0;

        }
        //metodos que implemento de iterador
        public void primero() { this.posicion = 0; }
        public void siguiente() { this.posicion++; }
        public bool fin() { return cola.estaVacia(); }
        public Comparable actual() { return cola.getElementosCola()[posicion]; }
    }
}