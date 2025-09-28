//P2E1 //por legajo
using System;

namespace ConsoleApp1
{
    public class PorLegajo : EstrategiaDeComparacion
    {//arreglar
        public bool sosIgual(Comparable c1,Comparable c2) { return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo(); }//comparo por legajo

        public bool sosMayor(Comparable c1, Comparable c2){ return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo(); }
        public bool sosMenor(Comparable c1, Comparable c2){ return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo(); }
    }
}