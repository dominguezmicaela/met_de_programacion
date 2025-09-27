using System;
using System.Runtime.InteropServices;
namespace ConsoleApp1
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        //metodos
        //Utilizo el generador de datos aleatorios
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();
        //sobreescribo los metodos de fabrica de comparables

        public override Comparable crearAleatorio()
        {
            return new Numero(generador.numeroAleatorio(100));
        }
        public override Comparable crearPorTeclado()
        {
            return new Numero(lector.numeroPorTeclado());
        }
    }
}