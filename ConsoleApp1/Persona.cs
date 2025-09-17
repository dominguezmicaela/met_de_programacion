/*Ejercicio 11
Implemente la clase abstracta Persona:
Persona
nombre  Es una variable que almacena un
string
dni  Es una variable que almacena un
numero
constructor(n, d)  Es el constructor de la clase que
recibe un nombre “n” y un DNI “d” y los
almacena en las variables
correspondientes.
getNombre  Devuelve la variable nombre
getDNI  Devuelve la variable dni
Haga que la clase Persona implemente la interface Comparable. Compare las personas por dni
o por nombre, según prefiera.
*/
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public abstract class Persona : Comparable
    {
        //atributos 
        private string nombre;
        private int dni;
        //Constructor
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        //propiedades
        public string getNombre() { return this.nombre; }
        public int getDNI() { return this.dni; }
        //metodo de la clase  ojo  no me tengfo que  confudir en escribir los metodos abstractos deben ir vacios y luego en las subclases se sobrescrien en funcion de lo que se necesite con la palalabra clavbe override  
        public abstract bool sosIgual(Comparable c);
        public abstract bool sosMenor(Comparable c);
        public abstract bool sosMayor(Comparable c);


    }
}