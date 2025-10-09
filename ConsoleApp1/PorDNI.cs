//P2E1 //clase por dni
using System;


namespace ConsoleApp1
{//arreglar

    public class PorDNI: EstrategiaDeComparacion
    {   //corregido
        public bool sosIgual(Comparable c1,Comparable c2) { return ((IAlumno)c1).Dni == ((IAlumno)c2).Dni; }//comparo por dni
        public bool sosMayor(Comparable c1,Comparable c2){ return ((IAlumno)c1).Dni> ((IAlumno)c2).Dni;}
        public bool sosMenor(Comparable c1,Comparable c2){ return ((IAlumno)c1).Dni< ((IAlumno)c2).Dni; }
    }
}