using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Alumno : Persona, Comparable,Observador,IAlumno
    {
        //atributos
        protected int legajo;
        protected float promedio;
        protected EstrategiaDeComparacion estrategia;
        protected float calificacion;
        protected string apellido;
        protected GeneradorDeDatosAleatorios gen;


        // constructor que debe recibir legajo y promedio pero que ademas tambien recibe los atribtos de persona
        public Alumno(string n, string a, int d, int l, float p, float c) : base(n, d)
        {
            this.apellido = a;
            this.legajo = l;
            this.promedio = p;
            this.calificacion = c;
            this.estrategia = new PorNombre();//estrategia por defecto
            this.gen = new GeneradorDeDatosAleatorios();
            
        }
        //propiedades
        public string Apellido{get{ return apellido; }set{ apellido = value; }}
        public int Legajo { get { return this.legajo; } set { legajo = value; } }
        public float Promedio{get{ return this.promedio; } set{ promedio =value; }}
        public float Calificacion{get{ return this.calificacion; }set{calificacion = value; } }
        //modifico estos metodos
        public override bool sosIgual(Comparable c) { return estrategia.sosIgual(this, (Alumno)c); }
        public override bool sosMenor(Comparable c) { return estrategia.sosMenor(this, (Alumno)c); }//this apunta a la instancia actual de alumno
        public override bool sosMayor(Comparable c) { return estrategia.sosMayor(this, (Alumno)c); }
        //implemento un metodo  para que se pueda cambiar el tipo de estrateg¡ia... por nombre o por dni etc
        public void setEstrategia(EstrategiaDeComparacion nuevaEstrategia) { this.estrategia = nuevaEstrategia; }
        //implemento dos metodos P3E11
        public void prestarAtencion(){ Console.WriteLine("Prestando atencion...."); }
        public void distraerse(){
            //elegir aleatoriamente una frase de un arrglo
            Random rand = new Random();
            string[] distracciones = ["Mirando celular","Dibujando en el margen de la carpeta", "tirando aviones de papel"];
            Console.WriteLine(distracciones[rand.Next(0,2)]);
        }
        public void actualizar(Observado o)
        {
            if (((Profesor)o).getHablando())
            {
                this.prestarAtencion();
            }
            else{ this.distraerse(); }
        }
        //P4E1
        public virtual int responderPregunta(int pregunta){ return gen.numeroAleatorio(3) + 1; }//n aleatorio genera n de 0 a max. incremento 1 para q devuelva 123
        public string mostrarCalificacion(){ return string.Format("[Alumno: Nombre={0}, Apellido={1}, Calificacion={2}]", nombre, apellido,calificacion); }
       override public string ToString()
        {
            return string.Format("[Alumno: Nombre={0}, DNI={1}, Legajo={2}, Promedio={3}]", nombre, dni, legajo, promedio);
        }


     }
}