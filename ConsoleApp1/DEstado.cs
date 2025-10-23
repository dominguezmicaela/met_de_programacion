using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public class DEstado:DecoradorAlumno
    {
        public DEstado(IAlumno adicional):base(adicional){ }

        public override String mostrarCalificacion()
        {
           string resultado = base.mostrarCalificacion();

            if (adicional.Calificacion < 4)
                resultado += " (DESAPROBADO)";
            else if (adicional.Calificacion >= 4 && adicional.Calificacion < 7)
                resultado += " (APROBADO)";
            else
                resultado += " (PROMOCION)";

            return resultado;
        }

    }
}