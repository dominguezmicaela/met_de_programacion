using System;

namespace ConsoleApp1
{
    public class FabricaDePilas : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable(int opcionComp)
        {
            /*la idea es que ya se genere en vez de llenarla  a una pila con 20  eelementos aleatorios  usando objetos de tipo comparable  entonces
            despues en el main simplemente  la informo*/
            Coleccionable pila = new Pila();//creo una pila
            for (int i = 0; i < 20; i++)
            {
                Comparable comp = FabricaDeComparables.crearAleatorio(opcionComp);// alumno o num
                pila.agregar(comp);// voy agreganfo elementos aleatorios si opcionComp=1=> la pila se carga con numeros
            }
            // una vez cargada la retorno
            return pila;
        }
    }
}