// cola que implementa la interface coleccionable
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Cola : Coleccionable,Iterable,Ordenable
    {
        //atributos
        private List<Comparable> elementos;
        private OrdenEnAula1 ordenInicio, ordenAulaLlena;
        private OrdenEnAula2 ordenLlegaAlumno;
        //constructor
        public Cola() { this.elementos = new List<Comparable>(); }
        //propiedades
        public List<Comparable> getElementosCola() { return elementos; }
        //metdos de la interface coleccionable y los propios de la cola
        public void agregar(Comparable c) {
            this.elementos.Add(c);
            if (this.cuantos() == 1 && this.ordenInicio != null) { this.ordenInicio.ejecutar(); }
            if (this.ordenLlegaAlumno != null) { this.ordenLlegaAlumno.ejecutar(c); }
            if(this.cuantos()==40 && this.ordenAulaLlena!= null){ this.ordenAulaLlena.ejecutar(); } }
        public int cuantos() { return this.elementos.Count; }
        public bool contiene(Comparable c)
        {
            if (this.cuantos() > 0)
            {
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.sosIgual(c)) { return true; }
                }
                return false;
            }
            else { throw new Exception("Cola vacia"); }
        }
        public void encolar(Comparable c){ this.elementos.Add(c);}// encolar recibe c y lo agrega
        public void desencolar()
        {
            if (cuantos() > 0) { this.elementos.RemoveAt(0); }
            else { throw new Exception("Cola vacia"); }
        }
        public Comparable minimo()
        {
            if (this.cuantos() > 0)
            {
                Comparable min = this.elementos[0];
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.sosMenor(min)) { min = elem; }
                }
                return min;
            }
            else { throw new Exception("Cola vacia"); }
        }
        public Comparable maximo()
        {
            if (this.cuantos() > 0)
            {
                Comparable max = this.elementos[0];
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.sosMayor(max)) { max = elem; }
                }
                return max;
            }
            else { throw new Exception("Cola vacia"); }
        }
        public bool estaVacia() { return this.cuantos() == 0; }
        public Iterador crearIterador() { return new IteradorCola<Comparable>(this); }
        public void setOrdenInicio(OrdenEnAula1 orden){ this.ordenInicio = orden; }
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden){ this.ordenLlegaAlumno = orden; }
        public void setOrdenAulaLlena(OrdenEnAula1 orden){ this.ordenAulaLlena = orden; }
        
    }
}