using System;


namespace ConsoleApp1
{
    public class DNotaLetras:DecoradorAlumno
    {
        //mantengo adicional desde la instancia anterior
        public DNotaLetras(IAlumno adicional):base(adicional){ }
        
        public override String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            //componente adicional
            string[] notas = ["cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez"];
            //math.Round redondea la calificacion para q coincida con el indice del arreglo de notas
            return string.Format("{0} {1} {2} ({3})", ((Alumno)adicional).getNombre(), ((Alumno)adicional).Apellido, ((Alumno)adicional).Calificacion, notas[(int)Math.Round(((Alumno)adicional).Calificacion)]);
        }

    }
}