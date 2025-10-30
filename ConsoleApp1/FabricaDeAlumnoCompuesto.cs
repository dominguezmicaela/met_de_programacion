using System;
namespace ConsoleApp1
{
    public class FabricaDeAlumnoCompuesto:FabricaDeComparables
    {

       
        public override Comparable crearAleatorio()
        {
            AlumnoCompuesto alumnoCompuesto = new AlumnoCompuesto();
            for (int i = 0; i < 5; i++)
            {
                IAlumno hijo = new AlumnoProxy(gen.stringAleatorio(5), gen.stringAleatorio(7), gen.numeroAleatorio(9), gen.numeroAleatorio(5), gen.numeroAleatorio(10), gen.numeroAleatorio(10), 1);
                alumnoCompuesto.agregarHijo(hijo);
            }
            return alumnoCompuesto;
                
        }
        public override Comparable crearPorTeclado()
        {
            AlumnoCompuesto alumnoCompuesto = new AlumnoCompuesto();
            for (int i = 0; i < 5; i++)
            {
                IAlumno hijo = new AlumnoProxy(lec.stringPorTeclado(), lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), 1);
                alumnoCompuesto.agregarHijo(hijo);
            }
            return alumnoCompuesto;
        }

    }
}