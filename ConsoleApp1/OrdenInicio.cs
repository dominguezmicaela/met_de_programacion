using System;
namespace ConsoleApp1
{
    public class OrdenInicio : OrdenEnAula1
    {
        //atributo
        private Aula aula;
        //constructor
        public OrdenInicio(Aula aula) { this.aula = aula; }
        public void ejecutar(){ this.aula.comenzar(); }
    }
}