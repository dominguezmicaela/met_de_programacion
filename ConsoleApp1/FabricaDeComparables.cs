using System;
namespace ConsoleApp1
{
    public abstract class FabricaDeComparables
    {
        //metodos 
        // aca deberia entonces tener un switch que instancie una vez segun un caso
        protected GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos lec = new LectorDeDatos();
        public static Comparable crearAleatorio(int opcion)
        {

            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: { fabrica = new FabricaDeNumeros(); break; }
                case 2: { fabrica = new FabricaDeAlumnos(); break; }
                case 3: { fabrica = new FabricaDeProfesores(); break; }
                case 4: { fabrica = new FabricaDeAlumnosMuyEstudiosos(); break; }
                case 5: { fabrica = new StudentsFactory(); break; }
                case 6: { fabrica = new FabricaDeAlumnosProxy(); break; }
                case 7: { fabrica = new FabricaDeAlumnoCompuesto(); break; }
                
                default: { Console.WriteLine("Opcion invalida"); break; }
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
                case 3: { fabrica = new FabricaDeProfesores(); break; }
                case 4: { fabrica = new FabricaDeAlumnosMuyEstudiosos(); break; }
                case 5: { fabrica = new StudentsFactory(); break; }
                case 6: { fabrica = new FabricaDeAlumnosProxy(); break; }
                case 7: { fabrica = new FabricaDeAlumnoCompuesto(); break; }
                default: { Console.WriteLine("Opcion invalida"); break; }
            }
            return fabrica.crearPorTeclado();
        
        }
        //devuelve un comparable generado aleatoriamente
        public abstract Comparable crearAleatorio();
        //devuelve un comparable donde los datos se ingresan por teclado
        public abstract Comparable crearPorTeclado();

    }
}