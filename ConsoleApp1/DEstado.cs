using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public class DEstado:DecoradorAlumno
    {
        public DEstado(IAlumno adicional):base(adicional){ }

        public override String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            // necesito un condicional aca debo usar comparables
            string estado;
            if (adicional.sosMayor(new Numero(6))) { estado = "Promociona"; }
            else if (adicional.sosMayor(new Numero(4))) { estado = "Aprueba"; }
            else { estado = "desaprueba"; }
            return String.Format("{0} {1} {2}({3})",((Alumno)adicional).getNombre(),((Alumno)adicional).Apellido, ((Alumno)adicional).Calificacion, estado);            
        }

    }
}