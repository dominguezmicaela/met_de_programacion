//clase pila que implementa la interface coleccionable
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Pila : Coleccionable, Iterable,Ordenable
    {
        //atributos
        private List<Comparable> elementos;
        private OrdenEnAula1 ordenInicio, ordenAulaLlena;
        private OrdenEnAula2 ordenLlegaAlumno;
        //constructor 
        public Pila() { this.elementos = new List<Comparable>(); }
        //propiedades
        public List<Comparable> getElementos() { return elementos; }
        //metodos 
        // agregar recibe un comparable y lo agrega a la pila 
        public void agregar(Comparable c)
        {
            this.elementos.Add(c);
            if (this.cuantos() == 1 && this.ordenInicio != null) { this.ordenInicio.ejecutar(); }
            if (this.ordenLlegaAlumno != null) { this.ordenLlegaAlumno.ejecutar(c); }
            if (this.cuantos() == 40 && this.ordenAulaLlena != null) { this.ordenAulaLlena.ejecutar(); }
        }
        //apilar recibe c y lo agrega
        
        public void apilar(Comparable c) { this.elementos.Add(c); }
        
        //cuantos retorna la cantidad de elementos que tiene la pila
        public int cuantos() { return this.elementos.Count; }//devuelve la cantidad de elementos en la pila
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
            else { throw new Exception("Pila vacia"); }
        }
        public Comparable desapilar()
        {
            if (cuantos() > 0)
            {
                Comparable elemento = this.elementos[this.cuantos() - 1];
                this.elementos.RemoveAt(this.cuantos() - 1);
                return elemento;
            }
            else { throw new Exception("Pila vacia"); }
        }
        public Comparable tope()
        {
            if (cuantos() > 0) { return elementos[elementos.Count - 1]; }
            else { throw new Exception("Pila vacia"); }
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
            else { throw new Exception("Pila vacia"); }
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
            else { throw new Exception("Pila vacia"); }
        }
        public bool estaVacia() { return this.cuantos() == 0; }
        public Iterador crearIterador() { return new IteradorPila<Comparable>(this); }
        //metodos de ordenable
        public void setOrdenInicio(OrdenEnAula1 orden){ this.ordenInicio = orden; }
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden){ this.ordenLlegaAlumno = orden; }
        public void setOrdenAulaLlena(OrdenEnAula1 orden){ this.ordenAulaLlena = orden; }
    }
    
}