using System;
namespace ConsoleApp1
{
    public class PorCalificiacion : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).Calificacion == ((IAlumno)c2).Calificacion;
        }
        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).Calificacion < ((IAlumno)c2).Calificacion;
        }
        public bool sosMayor(Comparable c1, Comparable c2)
        {
             return ((IAlumno)c1).Calificacion > ((IAlumno)c2).Calificacion;

        }
    }
}