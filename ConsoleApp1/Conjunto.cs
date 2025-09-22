/*Ejercicio 3
Implemente la clase Conjunto. Un Conjunto es una colección que almacena elementos sin
repetición. Es decir, si se intenta almacenar un elemento que ya está en el conjunto, éste
elemento no se almacena ya que sino estaría repetido.
Esta clase debe contar con los métodos:
agregar(elemento)  el cual agrega el elemento al
conjunto si es que éste no existe
pertenece(elemento)  el cual devuelve true si el
elemento recibido por parámetro ya
está dentro del conjunto, o false
en caso contrario
*/
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Conjunto<T> : Coleccionable, Iterable where T : Comparable//solo puede ser usada con tipod t que implemente la interfaz´comparable
    {
        //atributos
        private List<T> elementos;
        //constructor
        public Conjunto() { this.elementos = new List<T>(); }
        //propiedades
        public List<T> getElem() { return elementos; }
        //metodos
        public bool pertenece(T elem)
        {
            foreach (T e in elementos)
            {
                if (e.sosIgual(elem)) { return true; }
            }
            return false;

        }
        public void agregar(T elem)
        {
            if (!pertenece(elem)) { elementos.Add(elem); } // si elementos no contiene a elem  lo agrega 
        }

        //metodos de la clase coleccionable´
        public int cuantos() { return elementos.Count(); }
        public Comparable maximo()
        {
            // recorro a lista de elementos si el elemento en la pos es mayor que el maximo entonces hago swap
            // defino mas coomo el primer elemento de la lista
            if (cuantos() == 0) { return null; }
            else
            {
                T maximo = elementos[0];
                foreach (T elem in elementos)
                {
                    if (elem.sosMayor(maximo)) { maximo = elem; }
                }
                return maximo;
            }

        }
        public Comparable minimo()
        {
            if (cuantos() == 0) { return null; }
            else
            {
                T minimo = elementos[0];
                foreach (T elem in elementos)
                {
                    if (elem.sosMenor(minimo)) { minimo = elem; }
                }
                return minimo;
            }
        }
        public void agregar(Comparable c)
        {
            if (!pertenece((T)c)) { elementos.Add((T)c); } // si elementos no contiene a elem  lo agrega 
        }
        public bool contiene(Comparable c){return elementos.Contains((T)c);}
        public Iterador crearIterador(){return new IteradorConjunto<T>(this);}
    }
}
