/*Ejercicio 3
Implemente la siguiente interface que representa objetos que almacenan comparables:
Coleccionable
cuantos  Devuelve la cantidad de elementos
comparables que tiene el coleccionable
minimo  Devuelve el elemento de menor valor
de la colección
maximo  Devuelve el elemento de mayor valor
de la colección
agregar(Comparable)  Agrega el comparable recibido por
parámetro a la colección que recibe el
mensaje
contiene(Comparable)  Devuelve verdadero si el
comparable recibido por parámetro está
incluido en la colección y falso en
caso contrario*/

using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        public void agregar(Comparable c);
        public bool contiene(Comparable c);
    }
}