using System;
namespace ConsoleApp1
{
    public abstract class FabricaDeComparables
    {
        //metodos 
        //devuelve un comparable generado aleatoriamente
        public abstract Comparable CrearAleatorio();
        //devuelve un comparable donde los datos se ingresan por teclado
        public abstract Comparable crearPorTeclado();

    }
}