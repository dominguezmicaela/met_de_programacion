/*Ejercicio 12
Implemente la clase Alumno que sea subclase de Persona:
Alumno  Persona (hereda todo lo de persona y debo sobrescribir los metodos abstractos)
legajo  Es una variable que almacena un
número
promedio  Es una variable que almacena un
número
constructor(n, d, l, p)  Es el constructor de la clase
que recibe un nombre “n”, un DNI “d”,
un legajo “l” y un promedio “p” y los
almacena en las variables
correspondientes.
getLegajo  Devuelve la variable legajo
getPromedio  Devuelve la variable promedio*/
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Alumno : Persona
    {
        //atributos
        private int legajo;
        private float promedio;

        // constructor que debe recibir legajo y promedio pero que ademas tambien recibe los atrutos de persona
        public Alumno(string n, int d, int l, float p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }
        //propiedades
        public int getLegajo() { return this.legajo; }
        public float getPromedio() { return this.promedio; }
        //metodos de persona que debo sobrescribir
        public override bool sosIgual(Comparable c)
        {
            Alumno alumno = (Alumno)c;//casteo
            return this.getDNI() == alumno.getDNI();//comparo por dni

        }
        public override bool sosMenor(Comparable c)
        {
            Alumno alumno = (Alumno)c;
            return this.getDNI() < alumno.getDNI();
        }
        public override bool sosMayor(Comparable c)
        {
            Alumno alumno = (Alumno)c;
            return this.getDNI() > alumno.getDNI();
        }
     }
}