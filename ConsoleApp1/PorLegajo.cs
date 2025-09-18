//P2E1 //por legajo
using System;

namespace ConsoleApp1
{
    public class PorLegajo : EstrategiaDeComparacion
    {//arreglar
        public bool sosIgual(Alumno alumno1, Alumno alumno2) { return alumno1.getLegajo() == alumno2.getLegajo(); }//comparo por legajo

        public bool sosMayor(Alumno alumno1, Alumno alumno2) { return alumno1.getLegajo() > alumno2.getLegajo(); }
        public bool sosMenor(Alumno alumno1,Alumno alumno2){ return alumno1.getLegajo() < alumno2.getLegajo(); }
    }
}