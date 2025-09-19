using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Alumno : Persona,Comparable
    {
        //atributos
        private int legajo;
        private float promedio;
        private EstrategiaDeComparacion  estrategia;

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
        public override bool sosMenor(Comparable c){ return estrategia.sosMenor(this, (Alumno)c); }//this apunta a la instancia actual de alumno
        public override bool sosMayor(Comparable c){ return estrategia.sosMayor(this, (Alumno)c); }
        //implemento un metodo  para que se pueda cambiar el tipo de estrateg¡ia... por nombre o por dni etc
        public void setEstrategia(EstrategiaDeComparacion nuevaEstrategia){ this.estrategia = nuevaEstrategia; }
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
                    //agrego la estrategia
                    alumno.setEstrategia(estrategia);
                 coleccion.agregar(alumno);
               }
            }

        }


     }
}