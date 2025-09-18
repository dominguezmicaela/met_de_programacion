//P2E1 //clase por dni
using System;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{//arreglar

    public class PorDNI: EstrategiaDeComparacion
    {   //corregido
        public bool sosIgual(Alumno alumno1,Alumno alumno2) { return alumno1.getDNI() == alumno2.getDNI(); }//comparo por dni
        public bool sosMayor(Alumno alumno1,Alumno alumno2){ return alumno1.getDNI()> alumno2.getDNI();}
        public bool sosMenor(Alumno alumno1,Alumno alumno2){ return  alumno1.getDNI()< alumno2.getDNI(); }
    }
}