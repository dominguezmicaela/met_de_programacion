using System;


namespace ConsoleApp1
{
    public class DRecuadro:DecoradorAlumno
    {
        //mantengo adicional desde la instancia anterior
        public DRecuadro(IAlumno adicional):base(adicional){ }
    
        public override String mostrarCalificacion()
        {
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            //componente adicional
            int ancho = calificacion.Length+4;
            string borde = new string('*', ancho);
            return string.Format("{0}\n*{1} *\n{2}",borde,calificacion,borde);//puede fallar xd
        }

    }
}