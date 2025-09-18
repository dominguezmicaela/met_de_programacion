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
        //?? no tiene mas sentido aca comparar por promedio PREGUNTRR
        //e15
        public override bool sosIgual(Comparable c)
        {
            Alumno alumno = (Alumno)c;//casteo
            return this.getPromedio() == alumno.getPromedio();//comparo por promedio si son iguales retorna true

        }
        public override bool sosMenor(Comparable c)
        {
            Alumno alumno = (Alumno)c;
            return this.getPromedio() < alumno.getPromedio();
        }
        public override bool sosMayor(Comparable c)
        {
            Alumno alumno = (Alumno)c;
            return this.getPromedio() > alumno.getPromedio();
        }
        //E13Ç
        public void llenarAlumnos(Coleccionable coleccion)
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
               {
                 int legajo = rand.Next(1000, 9999);//genera legajo aleatorio entre ese rg
                 //genero un promedio aleatorio entre 1 y diez con decimales
                 float promedio = (float)(rand.NextDouble() * 9.0 + 1.0);//rand.NextDouble() genera un número decimal aleatorio entre 0.0 y 1.0 despues se acomoda matematicamente para obtener el rango deseadp
                // creo un alumno pasandole al constructor los datos generados de forma aleatoria
                 Alumno alumno = new Alumno("Alumno" + (i + 1), rand.Next(10000000, 99999999), legajo, promedio);
                 coleccion.agregar(alumno);
               }
            }

        }


     }
}