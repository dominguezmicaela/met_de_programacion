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
            //voy a informar cada una por separado
            Console.WriteLine("Visualizacion de las colecciones: Ingrese una opcion del menu");
            Console.WriteLine("1. PILA\n2. COLA\n3. COLECCION MULTIPLE\n4. SALIR");
            int opcion = int.Parse(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 1:
                        { informar(pila); break; }
                    case 2:
                        { informar(cola); break; }
                    case 3:
                        { informar(multiple); break; }
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 4);
            
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
        //E6 E9
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
        
    }
}