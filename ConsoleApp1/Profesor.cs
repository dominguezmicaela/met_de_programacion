using System;
using System.Collections.Concurrent;
namespace ConsoleApp1
{
    public class Profesor : Persona,Observado
    {
        //atributos
        int antiguedad;
        private bool hablando;
        private EstrategiaDeComparacion estrategia;
        List<Observador> observadores;
        //constructor
        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
            this.observadores = new List<Observador>();
        }
        //propiedades
        public int getAntiguedad() { return this.antiguedad; }
        public bool getHablando(){ return this.hablando; }
        //metodos de persona
        //comparo por antiguedad//GENERALIZAR USANDO ESTRATEGIAS DE COMPARACION//
        public override bool sosIgual(Comparable c) { return estrategia.sosIgual(this, (Profesor)c); }
        public override bool sosMayor(Comparable c) { return estrategia.sosMayor(this, (Profesor)c); }
        public override bool sosMenor(Comparable c) { return estrategia.sosMenor(this, (Profesor)c); }


        //metodos propios de profesor
        public void hablarALaClase()
        {
            hablando = true;
            Console.WriteLine("Hablando de algun tema");
            notificar();
        }
        public void escribirEnElPizzaron()
        {
            hablando = false;
            Console.WriteLine("Escribiendo en el pizzarron");
        }
        public void agregarObservador(Observador o){this.observadores.Add(o);}
        public void quitarObservador(Observador o){ this.observadores.Remove(o);}
        public void notificar()
        {
            foreach (Observador o in observadores) {
                o.actualizar(this);
            }
            
        }
        public override string ToString() => string.Format("[Profesor: Nombre={0}, Dni={1}, Antiguedad={2}]", nombre, dni, antiguedad);



    }
}