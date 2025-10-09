//P2E1 //por legajo
using System;

namespace ConsoleApp1
{
    public class PorLegajo : EstrategiaDeComparacion
    {//arreglar
        public bool sosIgual(Comparable c1,Comparable c2) { return ((IAlumno)c1).Legajo == ((IAlumno)c2).Legajo; }//comparo por legajo

        public bool sosMayor(Comparable c1, Comparable c2){ return ((IAlumno)c1).Legajo > ((IAlumno)c2).Legajo; }
        public bool sosMenor(Comparable c1, Comparable c2){ return ((IAlumno)c1).Legajo < ((IAlumno)c2).Legajo; }
    }
}