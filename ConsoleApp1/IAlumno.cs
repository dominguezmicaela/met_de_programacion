using System;
using System.Collections.Concurrent;
namespace ConsoleApp1
{
    public interface IAlumno : Comparable
    {

        public string mostrarCalificacion();
        public bool sosIgual(Comparable c);
        public bool sosMenor(Comparable c);
        public bool sosMayor(Comparable c);
    }
}