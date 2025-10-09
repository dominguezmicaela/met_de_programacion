/*Ejercicio 7
Arme los Students con todos los decorados implementado en el ejercicio anterior para que se
impriman de la siguiente manera: recordar filmina de decoradores en capas
****************************************************
* 5) Ratón Pérez (12345/6) 6 (SEIS) (APROBADO) *                  Dlegajo(DNotaLetra)(DEstado(DRecuadro))
****************************************************
Opcional: Haga una subclase de FabricaDeAlumnos, llamada StudentsFactory que instancie los
alumnos decorados y adaptados*/
using System;
namespace ConsoleApp1
{
    public class StudentsFactory:FabricaDeAlumnos
    {
        // Alumno(string n, string a, int d, int l, float p, float c)
        public StudentsFactory()
        {
            this.gen = new GeneradorDeDatosAleatorios();
        }
        public override Comparable crearAleatorio()
        {
            IAlumno a = new Alumno(gen.stringAleatorio(10), gen.stringAleatorio(10), gen.numeroAleatorio(10000000), gen.numeroAleatorio(1000000), gen.numeroAleatorio(11), gen.numeroAleatorio(11));
            //uso los decoradores
            a = new DLegajo(a);
            a = new DNotaLetras(a);
            a = new DEstado(a);
            a = new DRecuadro(a);
            return a;
        }
        public override Comparable crearPorTeclado()
        {
            IAlumno a = new Alumno(lec.stringPorTeclado(), lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado());
            a = new DLegajo(a);
            a = new DNotaLetras(a);
            a = new DEstado(a);
            a = new DRecuadro(a);
            return a;
        }

    }
}