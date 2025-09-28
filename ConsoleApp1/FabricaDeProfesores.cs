using System;
namespace ConsoleApp1
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
       
        //sobreescribo metodos
        public override Comparable crearAleatorio()
        {
            //(string n, int d, int a)
            return new Profesor(gen.stringAleatorio(10), gen.numeroAleatorio(10000000), gen.numeroAleatorio(50));
        }
        public override Comparable crearPorTeclado()
        {
            return new Profesor(lec.stringPorTeclado(),lec.numeroPorTeclado(),lec.numeroPorTeclado());
        }

    }
        
    
}