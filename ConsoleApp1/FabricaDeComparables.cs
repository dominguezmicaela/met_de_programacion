using System;
namespace ConsoleApp1
{
    public abstract class FabricaDeComparables
    {
        //metodos 
        // aca deberia entonces tener un switch que instancie una vez segun un caso
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: { fabrica = new FabricaDeNumeros(); break; }
                case 2: { fabrica = new FabricaDeAlumnos(); break; }
                default:{ Console.WriteLine("Opcion invalida"); break; }
            }
            return fabrica.crearAleatorio();
        
        }
        //lo mismo para el otro metodo
         public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: { fabrica = new FabricaDeNumeros(); break; }
                case 2: { fabrica = new FabricaDeAlumnos(); break; }
                default:{ Console.WriteLine("Opcion invalida"); break; }
            }
            return fabrica.crearPorTeclado();
        
        }
        //devuelve un comparable generado aleatoriamente
        public abstract Comparable crearAleatorio();
        //devuelve un comparable donde los datos se ingresan por teclado
        public abstract Comparable crearPorTeclado();

    }
}