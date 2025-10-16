using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* prueba fabrica de comparables
             //creo dos pilas
             Pila pilaAlumnos = new Pila();
             Pila pilaDeNumeros = new Pila();
             // muestro opcion numeros
             llenar(pilaDeNumeros, 1);
             informar(pilaDeNumeros, 1);
             Console.WriteLine("");
             //muestro opcion alumnos
             llenar(pilaAlumnos, 2);
             informar(pilaAlumnos, 2);
             */

            //armo un menu para probar fabrica de coleccionables sin las exc porque es solo prueba
            /*Console.WriteLine("elija el tipo de coleccion");
            Console.WriteLine("1.PILA\n2.COLA\n3.COLECCION MULTIPLE\n");
            int opcionColeccion = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora elija el tipo de elemento");
            Console.WriteLine("1.NUMERO\n2.ALUMNO");
            int opcionComparable = int.Parse(Console.ReadLine());
            //Segun la eleccion creo la coleccion con la fabrica
            Coleccionable coleccion = FabricaDeColeccionables.crearColeccionable(opcionColeccion, opcionComparable);
            //informar
            informar(coleccion, opcionComparable);
            // P3E14 
            // creo un profesor
            Profesor profe = (Profesor)FabricadeComparables.crearAleatorio(3);
            for (int i = 0; i < 20; i++)
            {
                Alumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);
                profe.agregarObservador(alumno);
                dictadoDeClases(profe);
            }

            */
            //P4E4
            //creo un profe
            /*Teacher profe = new Teacher();
            cargarAlumnos(profe);
            profe.teachingAClass();*/

            //P4E8
            Coleccionable coleccion = FabricaDeColeccionables.crearColeccionable(1, 5);//5 apunta a students;
            informar(coleccion, 5);



        }

        //Zona de metodos

        public static void  cargarAlumnos(Teacher profe)
        {
            //cargo 10 alumnos
            for (int i = 0; i < 10; i++)
            {
                IAlumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);//2 alumno
                alumno = new DLegajo(alumno);
                alumno = new DNotaLetras(alumno);
                alumno = new DEstado(alumno);
                alumno = new DRecuadro(alumno);
                Student est = new AlumnoAdapter(alumno);
                profe.goToClass(est);
            }
            for (int i = 0; i < 10; i++)
            {
                IAlumno alumnoEstudioso = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
                alumnoEstudioso= new DLegajo(alumnoEstudioso);
                alumnoEstudioso = new DNotaLetras(alumnoEstudioso);
                alumnoEstudioso = new DEstado(alumnoEstudioso);
                alumnoEstudioso = new DRecuadro(alumnoEstudioso);
                
                Student est = new AlumnoAdapter(alumnoEstudioso);
                profe.goToClass(est);
            }
        }

        /*public static void compararDosAlumnos()
        {
            //lleno una pila con 20 alumnos al azar de ahi saco dos
            Pila piladeAlumnos = new Pila();
            llenarAlumnos(piladeAlumnos);
            //desapilo 2  alumnos

            Alumno alumno1 = (Alumno)piladeAlumnos.desapilar();
            Alumno alumno2 = (Alumno)piladeAlumnos.desapilar();

            //ahora le pido al usuario para que me diga por que estrategia los quiere comparar
            Console.WriteLine("Elegir estrategia");
            Console.WriteLine("1.Por DNI\n2.PorLegajo\n 3.Por Promedio");
            int opcion = int.Parse(Console.ReadLine());
            EstrategiaDeComparacion estrategia;
            //selccion
            switch (opcion)
            {
                case 1: estrategia = new PorDNI(); break;
                case 2: estrategia = new PorLegajo(); break;
                case 3: estrategia = new PorPromedio(); break;
                default:
                    {
                        Console.WriteLine("Estrategia es erronea compararemos por defecto por promedio");
                        //debo si o si asignar algo por defecto sino me da error
                        estrategia = new PorPromedio();
                        break;
                    }
            }
            //
            alumno1.setEstrategia(estrategia);
            alumno2.setEstrategia(estrategia);
            //Ahora los muestrp
            Console.WriteLine("Alumno 1 \n{0}", alumno1);
            Console.WriteLine("Alumno 2\n {0}", alumno2);
            Console.WriteLine("Alumno 1 es igual que Alumno2 :{0}", alumno1.sosIgual(alumno2));
            Console.WriteLine("Alumno 1 mayor que Alumno 2: {0}", alumno1.sosMayor(alumno2));
            Console.WriteLine("Alumno 1 menor que Alumno 2:{0}", alumno1.sosMenor(alumno2));

        }*/
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


        }
        /*public static void llenarAlumnos(Coleccionable coleccion)
        {
            //defino una estrategia por default
            EstrategiaDeComparacion estrategia = new PorPromedio();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                {
                    int legajo = rand.Next(1000, 9999);//genera legajo aleatorio entre ese rg
                                                       //genero un promedio aleatorio entre 1 y diez con decimales
                    float promedio = (float)(rand.NextDouble() * 9.0 + 1.0);//rand.NextDouble() genera un número decimal aleatorio entre 0.0 y 1.0 despues se acomoda matematicamente para obtener el rango deseadp
                                                                            // creo un alumno pasandole al constructor los datos generados de forma aleatoria
                    Alumno alumno = new Alumno("Alumno" + (i + 1), rand.Next(10000000, 99999999), legajo, promedio);
                    alumno.setEstrategia(estrategia);
                    coleccion.agregar(alumno);
                }
            }

        }
        public static void imprimirElementos(Coleccionable coleccionable)
        {
            //
            //creo un iterador
            Iterador iterador = ((Iterable)coleccionable).crearIterador();
            //inicio
            iterador.primero();
            while (!iterador.fin())// hacerr hasta que llegue al final
            {
                string actual = iterador.actual().ToString();
                iterador.siguiente();
            }
        }*/
        /*
        public static void cambiarEstrategia(Coleccionable coleccionable, EstrategiaDeComparacion estrategia)
        {
            Iterador iterador = ((Iterable)coleccionable).crearIterador();
            for (iterador.primero(); !iterador.fin(); iterador.siguiente())
            {
                Alumno alumnoActual = (Alumno)iterador.actual();
                alumnoActual.setEstrategia(estrategia);

            }
        }*/
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