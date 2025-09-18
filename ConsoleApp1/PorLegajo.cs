//P2E1 //por legajo
using System;

namespace ConsoleApp1
{
    public class PorLegajo : EstrategiaDeComparacion
    {//arreglar
        public bool sosIgual(Alumno alumno1, Alumno alumno2) { return alumno1.getLegajo() == alumno2.getLegajo(); }//comparo por legajo
        //el metodo .compare() devuelve <0 si el primero es menor,0 iguales,>0 si el primero es mayor y agregue to lower para que haga todo en minuscula
        public bool sosMayor(Alumno alumno1, Alumno alumno2) { return alumno1.getLegajo() > alumno2.getLegajo(); }
        public bool sosMenor(Alumno alumno1,Alumno alumno2){ return alumno1.getLegajo() < alumno2.getLegajo(); }
    }
}