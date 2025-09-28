using System;
namespace ConsoleApp1
{
    public interface Observado
    {
        //metodos 
        public void agregarObservador(Observador o);
         public void quitarObservador(Observador o);
        public void notificar();
    }
}