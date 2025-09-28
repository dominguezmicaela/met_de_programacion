using System;
namespace ConsoleApp1
{
    public interface Observado
    {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}