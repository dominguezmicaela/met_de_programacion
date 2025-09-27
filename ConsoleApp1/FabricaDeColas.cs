using System;

namespace ConsoleApp1
{
    public class FabricaDeColas : FabricaDeColeccionables
    {
        public override Coleccionable crearColeccionable(int opcionComp)
        {
            Coleccionable cola = new Cola();//creo una cola
            for (int i = 0; i < 20; i++)
            {
                Comparable comp = FabricaDeComparables.crearAleatorio(opcionComp);// alumno o num
                cola.agregar(comp);// voy agreganfo elementos aleatorios si opcionComp=1=> la pila se carga con numeros
            }
            // una vez cargada la retorno
            return cola;
        }
    }
}