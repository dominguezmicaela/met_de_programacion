using System;
using System.Runtime.InteropServices;
namespace ConsoleApp1
{
    public class LectorDeDatos()
    {
        //metodos
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        public string stringPorTeclado()
        {
            // no necesita casteo los datos ingresan de tipo string
            Console.WriteLine("Ingrese una palabra:");
            string pal = Console.ReadLine();
            return pal;
        }
    }
}