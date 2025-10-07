using System;


namespace ConsoleApp1
{
    public class DOrdenSecuencial:DecoradorAlumno
    {
        //mantengo adicional desde la instancia anterior
        public DOrdenSecuencial(IAlumno adicional):base(adicional){}
        
        public String mostrarCalificacion()
        {   /*preguntar:Un decorado que imprima el número de orden secuencial dentro del
            listado:
            5) Ratón Pérez 6*/
            //comportamiento base
            string calificacion = base.mostrarCalificacion();
            //componente adicional
          
        }

    }
}