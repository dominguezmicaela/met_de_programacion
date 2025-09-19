using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Alumno : Persona, Comparable
    {
        //atributos
        private int legajo;
        private float promedio;
        private EstrategiaDeComparacion estrategia;

        // constructor que debe recibir legajo y promedio pero que ademas tambien recibe los atribtos de persona
        public Alumno(string n, int d, int l, float p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = new PorNombre();//estrategia por defecto
        }
        //propiedades
        public int getLegajo() { return this.legajo; }
        public float getPromedio() { return this.promedio; }
        //modifico estos metodos
        public override bool sosIgual(Comparable c) { return estrategia.sosIgual(this, (Alumno)c); }
        public override bool sosMenor(Comparable c) { return estrategia.sosMenor(this, (Alumno)c); }//this apunta a la instancia actual de alumno
        public override bool sosMayor(Comparable c) { return estrategia.sosMayor(this, (Alumno)c); }
        //implemento un metodo  para que se pueda cambiar el tipo de estrateg¡ia... por nombre o por dni etc
        public void setEstrategia(EstrategiaDeComparacion nuevaEstrategia) { this.estrategia = nuevaEstrategia; }
       override public string ToString() {
      return base.ToString() + string.Format("[Alumno: Legajo={0}, Promedio={1}]", legajo, promedio);}


     }
}