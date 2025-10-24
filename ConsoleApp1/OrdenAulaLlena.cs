using System;
namespace ConsoleApp1
{
    public class OrdenAulaLLena: OrdenEnAula1
    {
        //atributo
        private Aula aula;
        public void ejecutar(){ this.aula.claseLista(); }
    }
}