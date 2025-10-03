using System;
namespace ConsoleApp1
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
       
        //sobreescribo metodos
        public override Comparable crearAleatorio()
        {
            //hay que corregir
            return new Alumno(gen.stringAleatorio(10),gen.stringAleatorio(10), gen.numeroAleatorio(10000000), gen.numeroAleatorio(1000000), gen.numeroAleatorio(11),gen.numeroAleatorio(11));
        }
        public override Comparable crearPorTeclado()
        {
            return new Alumno(lec.stringPorTeclado(),lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
        }

    }
        
    
}