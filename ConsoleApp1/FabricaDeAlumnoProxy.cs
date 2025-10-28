using System;
namespace ConsoleApp1
{
    public class FabricaDeAlumnosProxy : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new AlumnoProxy(gen.stringAleatorio(5), gen.stringAleatorio(7), gen.numeroAleatorio(9), gen.numeroAleatorio(5), gen.numeroAleatorio(10), gen.numeroAleatorio(10),1);//opcion 1 alumno normal
        }
        public override Comparable crearPorTeclado()
        {
            return new AlumnoProxy(lec.stringPorTeclado(), lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), 1);
        }
    }
}