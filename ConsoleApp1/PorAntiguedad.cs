using System;
namespace ConsoleApp1
{
    public class PorAntiguedad:EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1,Comparable c2) { return ((Profesor)c1).getAntiguedad() == ((Profesor)c2).getAntiguedad(); }//comparo por dni
        public bool sosMayor(Comparable c1,Comparable c2){ return ((Profesor)c1).getAntiguedad()> ((Profesor)c2).getAntiguedad();}
        public bool sosMenor(Comparable c1,Comparable c2){ return ((Profesor)c1).getAntiguedad()< ((Profesor)c2).getAntiguedad(); }
    }
}