using System;
namespace ConsoleApp1
{
    public class FabricaDeColeccionMultiples : FabricaDeColeccionables
    {
        //metodos
        public override Coleccionable crearColeccionable(int opcionComp)
        {
            // creo una pila llena y una cola llena y las uso para crear un objeto multiple y luego lo retorno
            Pila pila = (Pila)new FabricaDePilas().crearColeccionable(opcionComp);// debo castear porque no generalize en  coleccion multiple
            Cola cola = (Cola)new FabricaDeColas().crearColeccionable(opcionComp);
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            return multiple;
        }
    }
}