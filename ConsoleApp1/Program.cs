using System;
using System.Collections;
using System.Collections.Generic;




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher profe = new Teacher();
            cargarAlumnos(profe);
            profe.teachingAClass();

        }

        //Zona de funciones

        public static void  cargarAlumnos(Teacher profe)
        {
            
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();//cargo 10 alumnos
            for (int i = 0; i < 10; i++)
            {
                // IAlumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);//2 alumno
                // alumno = new DLegajo(alumno);
                // alumno = new DNotaLetras(alumno);
                // alumno = new DEstado(alumno);
                // alumno = new DRecuadro(alumno);
                IAlumno alumno = new AlumnoProxy(gen.stringAleatorio(5), gen.stringAleatorio(7), gen.numeroAleatorio(9), gen.numeroAleatorio(5), gen.numeroAleatorio(10), gen.numeroAleatorio(10), 1);
                Student student = new AlumnoAdapter(alumno);
                profe.goToClass(student);
            }
            for (int i = 0; i < 10; i++)
            {
                // IAlumno alumnoEstudioso = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
                // alumnoEstudioso= new DLegajo(alumnoEstudioso);
                // alumnoEstudioso = new DNotaLetras(alumnoEstudioso);
                // alumnoEstudioso = new DEstado(alumnoEstudioso);
                // alumnoEstudioso = new DRecuadro(alumnoEstudioso);
                IAlumno alumnoEstudioso = new AlumnoProxy(gen.stringAleatorio(5), gen.stringAleatorio(7), gen.numeroAleatorio(9), gen.numeroAleatorio(5), gen.numeroAleatorio(10), gen.numeroAleatorio(10),2);
                Student student = new AlumnoAdapter(alumnoEstudioso);
                profe.goToClass(student);
            }
        }

        public static void llenar(Coleccionable col, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                col.agregar(FabricaDeComparables.crearAleatorio(opcion));
            }
        }
        //En  P3E6 me piden utilizar la FabricaDeComparables y sus metodos para simplificar el metodo infromar. Agrego paramtro opcion
        public static void informar(Coleccionable c, int opcion)
        {
            Console.WriteLine("Cantidad de elementos: {0}", c.cuantos());
            Console.WriteLine("Minimo: {0}", c.minimo());
            Console.WriteLine("Maximo: {0}", c.maximo());
            //creo un comparable para ver si e o no e
            Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
            if (c.contiene(comparable)) { Console.WriteLine("El elemento leido esta en la coleccion"); }
            else { Console.WriteLine("El elemento no esta en la coleeccion"); }
            Iterador it = ((Iterable)c).crearIterador();
            for (it.primero(); !it.fin(); it.siguiente())
            {
                Console.WriteLine(it.actual());
            }


        }
        public static void dictadoDeClases(Profesor p)
        {
            for (int i = 0; i < 5; i++)
            {
                p.hablarALaClase();
                p.escribirEnElPizzaron();
            }
        }
        
        
    }
}