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
            llenar(pila);
            llenar(cola);
            Console.WriteLine("PILA:");
            informar(pila);
            Console.WriteLine("COLA:");
            informar(cola);
        }
        //E5
        static void llenar(Coleccionable col)
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
            try { int numero = int.Parse(Console.ReadLine()); }
            catch (FormatException) { Console.WriteLine("Formato invalido"); }
            catch (OverflowException) { Console.WriteLine("Numero fuera de rango"); }
            if (c.contiene(numero0)) { Console.WriteLine("El elemento leido esta en la coleccion")}
            else { Console.WriteLine("El elemento no esta en la coleeccion")}

        }
}