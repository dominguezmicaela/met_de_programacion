//P2E1 //clase por dni
using System;


namespace ConsoleApp1
{//arreglar

    public class PorDNI: EstrategiaDeComparacion
    {   //corregido
        public bool sosIgual(Comparable c1,Comparable c2) { return ((Persona)c1).getDNI() == ((Persona)c2).getDNI(); }//comparo por dni
        public bool sosMayor(Comparable c1,Comparable c2){ return ((Persona)c1).getDNI()> ((Persona)c2).getDNI();}
        public bool sosMenor(Comparable c1,Comparable c2){ return ((Persona)c1).getDNI()< ((Persona)c2).getDNI(); }
    }
}