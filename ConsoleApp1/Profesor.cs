using System;
namespace ConsoleApp1
{
    public class Profesor : Persona
    {
        //atributos
        int antiguedad;
        //constructor
        public Profesor(string n, int d, int a):base(n,d) { this.antiguedad = a; }
        //propiedades
        public int getAntiguedad() { return this.antiguedad; }
        //metodos de persona
        //comparo por antiguedad
        public override bool sosIgual(Comparable c) { return this.antiguedad == ((Profesor)c).getAntiguedad(); }
        public override bool sosMayor(Comparable c) { return this.antiguedad > ((Profesor)c).getAntiguedad(); }
        public override bool sosMenor(Comparable c) { return this.antiguedad < ((Profesor)c).getAntiguedad(); }
    
      
        //metodos propios de profesor
        public void hablarALaClase() { Console.WriteLine("Hablando de algun tema"); }
        public void escribirEnElPizzaron(){ Console.WriteLine("Escribiendo en el pizzarron"); }
        



    }
}