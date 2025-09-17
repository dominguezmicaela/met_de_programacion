/*Ejercicio 2
Implemente la clase Numero:
Numero
valor  Es una variable que almacena un
número entero
constructor(v)  Es el constructor de la clase que
recibe un valor “v” y lo almacena en la
variable “valor”
getValor  Devuelve la variable “valor”
Haga que la clase Numero implemente la interface Comparable.
Nota: Si se implementa en C#, en los tres métodos a implementar, se deberá castear el
parámetro recibido a Numero.*/
using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    public class Numero : Comparable //hago que la clase número implemente la interfaz comparable
    {
        //atributos
        private int valor;
        //constructor
        public Numero(int v) { this.valor = v; }
        //propiedades
        public int Valor { get { return this.valor; } }
        //métodos de la interfaz comparable
        public bool sosIgual(Comparable c)
        {
            //casteo el parametro recibido a numero
            Numero num = (Numero)c;
            //comparo
            return (this.valor == num.Valor);//devulve true si son iguales y false si no 
        }
        public bool sosMenor(Comparable c)
        {
            // casteo
            Numero num = (Numero)c;
            //comparo 
            return (this.valor < num.Valor);
        }
        public bool sosMayor(Comparable c)
        {
            //casteo
            Numero num = (Numero)c;
            //comparo
            return (this.valor > num.Valor);
        }
        public override string ToString(){return valor.ToString();}

    }
}