using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
namespace ConsoleApp1
{
    public interface IAlumno : Comparable
    {
      
        string Apellido { get; set; }
        int Legajo{ get; set; }
        float Promedio{ get; set; }
        float Calificacion{ get; set; }
        public string mostrarCalificacion();
        public bool sosIgual(Comparable c);
        public bool sosMenor(Comparable c);
        public bool sosMayor(Comparable c);
    }
}