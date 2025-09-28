//P2E1 clase por promedio
using System;

namespace ConsoleApp1
{//arreglar
    public class PorPromedio : EstrategiaDeComparacion
    {    
        public bool sosIgual(Comparable c1, Comparable c2){ return ((Alumno)c1).getPromedio() == ((Alumno)c2).getPromedio(); }//comparo por promedio
        public bool sosMayor(Comparable c1, Comparable c2) { return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();  }
        public bool sosMenor(Comparable c1,Comparable c2) { return ((Alumno)c1).getPromedio() <((Alumno)c2).getPromedio();  }
    }
}