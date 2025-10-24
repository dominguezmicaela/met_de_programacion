using System;
namespace ConsoleApp1
{
    public class OrdenAulaLLena: OrdenEnAula1
    {
        //atributo
        private Aula aula;
        //constructor
        public OrdenAulaLLena(Aula a){ this.aula = a; }
        //metodo
        public void ejecutar(){ this.aula.claseLista(); }
    }
}