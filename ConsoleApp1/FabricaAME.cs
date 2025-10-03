using System;
namespace ConsoleApp1
{
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            //Alumno(string n, string a, int d, int l, float p, float c) 
            return new AlumnoMuyEstudioso(gen.stringAleatorio(10),gen.stringAleatorio(10), gen.numeroAleatorio(10000000), gen.numeroAleatorio(1000000), gen.numeroAleatorio(11),gen.numeroAleatorio(11));
        }
        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(lec.stringPorTeclado(),lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
        }
    }
}