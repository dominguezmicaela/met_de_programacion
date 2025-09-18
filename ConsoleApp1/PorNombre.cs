//P2E1 ///clase por nombre
using System;

namespace ConsoleApp1
{
    public class PorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Alumno alumno1, Alumno alumno2) { return alumno1.getNombre() == alumno2.getNombre(); }//comparo por nombre
        //el metodo .compare() devuelve <0 si el primero es menor,0 iguales,>0 si el primero es mayor y agregue to lower para que haga todo en minuscula
        public bool sosMayor(Alumno alumno1, Alumno alumno2) { return string.Compare(alumno1.getNombre().ToLower(), alumno2.getNombre().ToLower()) > 0; }
        public bool sosMenor(Alumno alumno1,Alumno alumno2){ return string.Compare(alumno1.getNombre().ToLower(), alumno2.getNombre().ToLower()) < 0; }
    }
}