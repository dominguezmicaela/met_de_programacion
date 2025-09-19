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
using System.Collections;

namespace ConsoleApp
{
    public class Conjunto<T>//generalizo
    {
        //atributos
        private List<T> elementos;
        //constructor
        public Conjunto(){ this.elementos = new List<T>(); }
        //metodos
        public bool pertenece(T elem) { return elementos.Contains(elem);}
        public void agregar(T elem)
        {
            if (!pertenece(elem)) { elementos.Add(elem); } // si elementos no contiene a elem  lo agrega 
        
        }
    }
}
