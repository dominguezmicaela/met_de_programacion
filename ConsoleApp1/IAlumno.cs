using System;

namespace ConsoleApp1
{
    public interface IAlumno : Comparable
    {
        string Nombre{ get; set; }
        string Apellido { get; set; }
        int Dni{ get; set; }
        int Legajo{ get; set; }
        float Promedio{ get; set; }
        float Calificacion{ get; set; }
        public string mostrarCalificacion();
        public int responderPregunta(int pregunta);
        
    }
}