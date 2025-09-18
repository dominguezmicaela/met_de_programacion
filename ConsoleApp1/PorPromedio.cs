//P2E1 clase por promedio
using System;

namespace ConsoleApp1
{//arreglar
    public class PorPromedio : EstrategiaDeComparacion
    {       //CORREGIDO
        public bool sosIgual(Alumno alumno1, Alumno alumno2) { return alumno1.getPromedio() == alumno2.getPromedio(); }//comparo por promedio
        public bool sosMayor(Alumno alumno1, Alumno alumno2) { return alumno1.getPromedio() > alumno2.getPromedio();  }
        public bool sosMenor(Alumno alumno1, Alumno alumno2) { return alumno1.getPromedio() < alumno2.getPromedio();  }
    }
}