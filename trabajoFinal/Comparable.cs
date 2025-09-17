using System;
namespace trabajoFinal
{
    public interface Comparable
    {   //Asumo que el parametro es del mismo tipo que la clase que implementa la interfaz
        bool sosIgual(Comparable c);
        bool sosMenor(Comparable c);
        bool sosMayor(Comparable c);
    }
}