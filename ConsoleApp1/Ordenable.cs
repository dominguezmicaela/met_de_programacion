using System;
namespace ConsoleApp1
{
    public interface Ordenable
    {
        public void setOrdenInicio(OrdenEnAula1 orden);
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        public void setOrdenAulaLlena(OrdenEnAula1 orden);
    }
}