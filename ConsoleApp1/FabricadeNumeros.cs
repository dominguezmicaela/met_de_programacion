using System;

namespace ConsoleApp1
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        //metodos
        //Utilizo el generador de datos aleatorios
        
        //sobreescribo los metodos de fabrica de comparables

        public override Comparable crearAleatorio()
        {
            return new Numero(gen.numeroAleatorio(100));
        }
        public override Comparable crearPorTeclado()
        {
            return new Numero(lec.numeroPorTeclado());
        }
    }
}