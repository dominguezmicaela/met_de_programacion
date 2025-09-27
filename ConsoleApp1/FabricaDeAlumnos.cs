using System;
namespace ConsoleApp1
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
       
        //sobreescribo metodos
        public override Comparable crearAleatorio()
        {
            //(string n, int d, int l, float p)
            return new Alumno(gen.stringAleatoriO(10), gen.numeroAleatorio(10000000), gen.numeroAleatorio(1000000), gen.numeroAleatorio(10));
        }
        public override Comparable crearPorTeclado()
        {
            return new Alumno(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
        }

    }
        
    
}