using System;

namespace ConsoleApp1
{
    public class DEstado:DecoradorAlumno
    {
        //mantengo adicional desde la instancia anterior
        public DEstado(IAlumno adicional):base(adicional){ }
        //Un decorado que imprima el legajo: Ratón Pérez (12345/6) 6 etsa raro
        public String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            //componente adicional
            return string.Format("{0} ({1})", calificacion, ((Alumno)adicional).Legajo); // nombre apellido calificacion y legajo
        }

    }
}