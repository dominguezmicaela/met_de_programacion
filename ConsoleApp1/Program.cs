using System;
using System.Collections;
using System.Collections.Generic;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //E7
            /*
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            llenar(pila);
            llenar(cola);
            //voy a informar cada una por separado
            Console.WriteLine("Visualizacion de las colecciones: Ingrese una opcion del menu");
            Console.WriteLine("1. PILA\n2. COLA\n3. COLECCION MULTIPLE\n4. COMPARAR DOS ALUMNOS\n5. SALIR");
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
                    case 4:
                        {
                            compararDosAlumnos(); break;
                        }
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 5);

        
        */
            //PRACTICA 2 E7
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto<Comparable> conjunto= new Conjunto<Comparable>();
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            imprimirElementos(pila);
            imprimirElementos(cola);
            imprimirElementos(conjunto);


        }
        
        //Zona de metodos

        public static void compararDosAlumnos()
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

        }
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
        //llenar va en program
        public static void llenarAlumnos(Coleccionable coleccion)
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
        //agrego metodo imporimir elementos
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
        }
        
    }
}