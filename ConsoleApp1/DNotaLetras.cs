using System;
namespace ConsoleApp1
{
    public class DNotaLetras : DecoradorAlumno
    {
        //mantengo adicional desde la instancia anterior
        public DNotaLetras(IAlumno adicional) : base(adicional) { }

        public override String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            //componente adicional
            string[] notas = ["cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez"];
            calificacion += "(" + notas[(int)adicional.Calificacion] + ")";
            return calificacion;
        }
    }
}
