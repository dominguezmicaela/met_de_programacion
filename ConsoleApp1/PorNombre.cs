//P2E1 ///clase por nombre
using System;

namespace ConsoleApp1
{//arreglar
    public class PorNombre : EstrategiaDeComparacion
    {   
        public bool sosIgual(Comparable c1, Comparable c2) { return ((IAlumno)c1).Nombre== ((IAlumno)c2).Nombre; }// persona hereda nombre y dni a profesor y alumno
        public bool sosMayor(Comparable c1, Comparable c2){ return string.Compare(((IAlumno)c1).Nombre.ToLower(), ((IAlumno)c2).Nombre.ToLower()) > 0; }
        public bool sosMenor(Comparable c1, Comparable c2){ return string.Compare(((IAlumno)c1).Nombre.ToLower(),((IAlumno)c2).Nombre.ToLower()) < 0; }
    }
}