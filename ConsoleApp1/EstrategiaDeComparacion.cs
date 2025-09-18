//P2_E1
using System;
namespace ConsoleApp1
{  /// 
    public interface EstrategiaDeComparacion
    {   //CORREGIDO
        public bool sosIgual(Alumno a1,Alumno a2);
        public bool sosMenor(Alumno a1,Alumno a2);
        public bool sosMayor(Alumno a1,Alumno a2);
        
        
    }
}