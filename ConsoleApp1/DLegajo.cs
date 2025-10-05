using System;

namespace ConsoleApp1
{
    public class DLegajo:DecoradorAlumno
    {
        //mantengo adicional desde la instancia anterior
        public DLegajo(IAlumno adicional):base(adicional){ }
        //Un decorado que imprima el legajo: Ratón Pérez (12345/6) 6 etsa raro
        public String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            //componente adicional
            return string.Format("{0}{1}({2}/{3}){4}", ((Alumno)adicional).getNombre(), ((Alumno)adicional).Apellido, ((Alumno)adicional).Legajo, ((Alumno)adicional).Calificacion, ((Alumno)adicional).Calificacion);
        }

    }
}