using System;
using System.Runtime.CompilerServices;
namespace ConsoleApp1
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        //Atributos
        private Aula aula;
        //Constructor
        public OrdenLlegaAlumno(Aula a) { this.aula = a; }
        //Metodos
        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((Alumno)c);
        }
    }
}