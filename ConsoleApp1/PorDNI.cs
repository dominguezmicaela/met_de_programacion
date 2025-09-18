//P2E1 //clase por dni
using System;

namespace ConsoleApp1
{
    public class PorDNI: EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno alumno1, Alumno alumno2) { return alumno1.getDNI() == alumno2.getDNI(); }//comparo por dni
        //el metodo .compare() devuelve <0 si el primero es menor,0 iguales,>0 si el primero es mayor y agregue to lower para que haga todo en minuscula
        public bool sosMayor(Alumno alumno1, Alumno alumno2) { return string.Compare(alumno1.getDNI().ToLower(), alumno2.getDNI().ToLower()) > 0; }
        public bool sosMenor(Alumno alumno1,Alumno alumno2){ return string.Compare(alumno1.getDNI().ToLower(), alumno2.getDNI().ToLower()) < 0; }
    }
}