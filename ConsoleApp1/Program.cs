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
            
        }
        //Zona de metodos
        //metodo para cargar los datos de un alumno
        public static Alumno crearAlumno() {
            Console.WriteLine("Ingrese el nombre del alumno");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el dni del alumno sin puntos");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el legajo");
            int legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el promedio");
            float prom = float.Parse(Console.ReadLine());
            Alumno alumnoCargado = new Alumno(nombre, dni, legajo, prom);
            return alumnoCargado;
                    }
        public static void compararDosAlumnos()
        {
            Console.WriteLine("Ingrese los datos del primer alumno");
            Alumno alumno1 = crearAlumno();
            Console.WriteLine("Ingrese los datos del segundo alumno:");
            Alumno alumno2 = crearAlumno();
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
        
    }
}