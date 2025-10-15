using System;

namespace ConsoleApp1
{
    public abstract class DecoradorAlumno : IAlumno
    {
        //a
        protected IAlumno adicional;
        //constructor
        public DecoradorAlumno(IAlumno adicional)
        {
            this.adicional = adicional;
        }
        public string Nombre { get { return adicional.Nombre; } set { adicional.Nombre = value; } }
        public string Apellido { get { return adicional.Apellido; } set { adicional.Apellido = value; } }
        public int Dni { get { return adicional.Dni; } set { adicional.Dni = value; } }
        public int Legajo { get { return adicional.Legajo; } set { adicional.Legajo = value; } }
        public float Promedio { get { return adicional.Promedio; } set { adicional.Promedio = value; } }
        public float Calificacion { get { return adicional.Calificacion; } set { adicional.Calificacion = value; } }
        //met
        public virtual string mostrarCalificacion(){ return adicional.mostrarCalificacion();}
        //Correccion casteos
        public bool sosIgual(Comparable c) { return adicional.sosIgual((DecoradorAlumno)c); }
        public bool sosMenor(Comparable c) { return adicional.sosMenor((DecoradorAlumno)c); }
        public bool sosMayor(Comparable c) { return adicional.sosMayor((DecoradorAlumno)c); }
        public int responderPregunta(int pregunta){ return this.adicional.responderPregunta(pregunta); }
         public override string ToString(){return  adicional.ToString();}
        
    }
}