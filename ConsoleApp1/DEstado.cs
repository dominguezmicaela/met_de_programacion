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
            //componente adicional
            if (adicional.Calificacion > 0 && adicional.Calificacion < 4) { calificacion = "desaprueba"; }
            else if (adicional.Calificacion >= 4 && adicional.Calificacion < 7) { calificacion = "aprueba"; }
            else { calificacion = "promociona"; }
                return calificacion;  
        }

    }
}