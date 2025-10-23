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
            string[] enLetras = new string[] { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            string resultado = base.mostrarCalificacion();
            resultado += " (" + enLetras[(int)adicional.Calificacion] + ")";
            return resultado;
        }
    }
}
