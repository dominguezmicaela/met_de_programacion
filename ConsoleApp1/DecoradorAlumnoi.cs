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

        
    }
}