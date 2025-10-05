using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public class DEstado:DecoradorAlumno
    {
       /* Un decorado que imprima PROMOCIÓN (si la nota es mayor o igual 7), APROBADO (si
        la nota está entre 4 y 7 ó DESAPROBADO (si la nota es menor a 4):
        Ratón Pérez 6 (APROBADO)*/
        public DEstado(IAlumno adicional):base(adicional){ }

        public String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            // necesito un condicional aca debo usar comparables
            string estado;
            if (adicional.sosMayor(new Numero(6))) { estado = "Promociona"; }
            else if (adicional.sosMayor(new Numero(4))) { estado = "Aprueba"; }
            else { estado = "desaprueba"; }
            return String.Format("Estado del alumno{0}", estado);            
        }

    }
}