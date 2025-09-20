using System;
namespace ConsoleApp1
{
    public class IteradorPila<T> : Iterador where T :Comparable
    {
        //atributos
        private Pila pila;
        private int posicion;
        //constructor
        public IteradorPila(Pila pila) {
            this.pila = pila;
            this.posicion = pila.cuantos() - 1;
       }
        //implemento metodos de Iterador
        public void primero(){ this.posicion = pila.cuantos() - 1; }   //elemento tope    
        public void siguiente(){ this.posicion--; } //de mi tope bajo al siguiente elemento de la pila
        public bool fin() { return pila.estaVacia();}// supongo que cuando esta vacia se pone en true fin tambien
        public Comparable actual() //devuelve el elemen actual en la pos donde esta el iterador
        {
            return pila.getElementos()[posicion];
        }
    }

}