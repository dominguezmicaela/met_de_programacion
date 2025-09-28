//P2_E1
using System;
namespace ConsoleApp1
{  /// 
    public interface EstrategiaDeComparacion
    {   //CORREGIDO
        public bool sosIgual(Comparable c1,Comparable c2);
        public bool sosMenor(Comparable c1,Comparable c2);
        public bool sosMayor(Comparable c1,Comparable c2);
        
        
    }
}