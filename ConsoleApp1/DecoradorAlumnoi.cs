using System;
using System.Reflection;
namespace ConsoleApp1
{
    public abstract class DecoradorAlumno : IAlumno
    {
        //a
        protected IAlumno adicional;
        //constructor
        public DecoradorAlumno(IAlumno  adicional)
        {
            this.adicional = adicional;
        }
        //met
        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }
        public bool sosIgual(Comparable c){ return adicional.sosIgual(c); }
        public bool sosMenor(Comparable c){ return adicional.sosMenor(c); }
        public bool sosMayor(Comparable c){ return adicional.sosMayor(c); }
        
    }
}