using System;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp1
{
    public interface Comparable
    {   //Asumo que el parametro es del mismo tipo que la clase que implementa la interfaz
        public bool sosIgual(Comparable c);
        public bool sosMenor(Comparable c);
        public bool sosMayor(Comparable c);
    }
}