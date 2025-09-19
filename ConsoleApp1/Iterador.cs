using System;
namespace ConsoleApp1
{
    public interface Iterador
    {
        public void primero();
        public void siguiente();
        public bool fin();
        Iterable actual();

    }
}