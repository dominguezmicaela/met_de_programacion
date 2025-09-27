using System;

namespace ConsoleApp1
{
    public abstract class FabricaDeColeccionables
    {
        public abstract Coleccionable crearColeccionable(int opcionComp);
        public static Coleccionable crearColeccionable(int opcionColeccion, int opcionComp) {
            switch (opcionColeccion)
            {
                case 1: return new FabricaDePilas().crearColeccionable(opcionComp);break;
                case 2 : return new FabricaDeColas().crearColeccionable(opcionComp);break;
                case 3: return new FabricaDeColeccionMultiples().crearColeccionable(opcionComp);break;
                default: {throw new Exception("Opción de colección inválida");; break; }
            }
        }
        
    }
}