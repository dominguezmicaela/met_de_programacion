//P2E1 ///clase por nombre
using System;

namespace ConsoleApp1
{//arreglar
    public class PorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2) { return ((Persona)c1).getNombre() == ((Persona)c2).getNombre(); }// persona hereda nombre y dni a profesor y alumno
        public bool sosMayor(Comparable c1, Comparable c2){ return string.Compare(((Persona)c1).getNombre().ToLower(), ((Persona)c2).getNombre().ToLower()) > 0; }
        public bool sosMenor(Comparable c1, Comparable c2){ return string.Compare(((Persona)c1).getNombre().ToLower(),((Persona)c2).getNombre().ToLower()) < 0; }
    }
}