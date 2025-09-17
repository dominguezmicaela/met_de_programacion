/*Ejercicio 9
Modifique el módulo main para crear una ColeccionMultiple e informe con esta colección.
main
pila = new Pila()
cola = new Cola()
multiple = new ColeccionMultiple(pila, cola)
llenar(pila)
llenar(cola)
informar(pila)
informar(cola)
informar(multiple)*/

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //E7
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            llenar(pila);
            llenar(cola);
            Console.WriteLine("PILA:");
            informar(pila);
            Console.WriteLine("COLA:");
            informar(cola);
            Console.WriteLine("Coleccion multiple:");
            informar(multiple);
        }
        //Zona de metodos

        //E5
        public static void llenar(Coleccionable col)
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                int valor = rand.Next(1, 101); // Valores entre 1 y 100
                Numero comparable = new Numero(valor);
                col.agregar(comparable);
            }
        }
        //E6
        public static void informar(Coleccionable c)
        {
            Console.WriteLine("Cantidad de elementos: {0}", c.cuantos());
            Console.WriteLine("Minimo: {0}", c.minimo());
            Console.WriteLine("Maximo: {0}", c.maximo());
            Console.WriteLine("Ingrese un numero a buscar: ");
            try
            {
                Comparable numero = new Numero(int.Parse(Console.ReadLine()));
                if (c.contiene(numero)) { Console.WriteLine("El elemento leido esta en la coleccion"); }
                else { Console.WriteLine("El elemento no esta en la coleeccion"); }
            }
            catch (Exception) { Console.WriteLine("Ingreso invalido"); }

        }
        //E9
        //Agrego el metodo informar que recibe una c. multiple y muestra la info
        public static void informar(ColeccionMultiple cm)
        {
            Console.WriteLine("Cant de elementos: {0}", cm.cuantos());
            Console.WriteLine("Min {0}", cm.minimo());
            Console.WriteLine("Max {0}", cm.maximo());
            // asumo que informar debe ser similar al anterior por lo tanto agrego la busquedad del elemento
            Console.WriteLine("Ingrese un numero a buscar: ");
            try
            {
                Comparable numero = new Numero(int.Parse(Console.ReadLine())); // creo un numero comparaable
                if (cm.contiene(numero)) { Console.WriteLine("El elemento leido esta en la coleccion"); }
                else { Console.WriteLine("El elemento no esta en la coleeccion"); }
            }
            catch (Exception) { Console.WriteLine("Ingreso invalido"); }

        }
    }
}