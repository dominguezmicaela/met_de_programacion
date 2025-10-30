using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace ConsoleApp1
{
    public class AlumnoCompuesto: IAlumno
    {

        //Atributos
        private List<IAlumno> hijos;
        //Constructor
        public AlumnoCompuesto() { this.hijos = new List<IAlumno>(); }
        
        //Propiedades
        public string Nombre
        {
            get
            {
                string nombreCompleto = "";
                foreach (IAlumno a in hijos) { nombreCompleto += a.Nombre + " " + a.Apellido; }
                return nombreCompleto;
            }
            set { }
        }
        public string Apellido { 
            get
            {
                string apellido = "";
                foreach (IAlumno a in hijos) { apellido+= a.Apellido; }
                return apellido;
            }
            set{} }
        public int Dni{ get{ return 0; } set{} }
        public int Legajo{ get{return 0; } set{} }
        public float Calificacion { get { return 0; } set { } }
        //promedio gral
        public float Promedio
        {
            get
            {
                float suma = 0;
                foreach (IAlumno a in hijos) { suma+= a.Promedio; }
                float promedioGeneral = suma / hijos.Count;
                return promedioGeneral;
            }
            set { }
        }
        //metodos
        public void agregarHijo(IAlumno a) { this.hijos.Add(a); }
        public void borrarHijo(IAlumno a) { this.hijos.Remove(a); }
        public IAlumno obtenerHijo(IAlumno a){
            if (this.hijos.Contains(a))
            {return a; }
            else{ return null;}
        }

        public string mostrarCalificacion() { }
        /*devuelve la respuesta más votada por todos los componenteshijos del compuesto (en caso de empate entre dos o más respuestas, se elige una de
        ellas al azar)*/
        public int responderPregunta(int pregunta)
        {
            int[] contVotos= new int[3];
            foreach (IAlumno a in hijos)
            {
                int respuesta = a.responderPregunta(pregunta);
                contVotos[respuesta]++;
            }
            //votos es contador  y el indice coincide con la r
            int maxVotos =-1;
            int posMasVotada = -1;
                bool empate = false;
            List<int> empatadas = new List<int>();
            for (int i = 0; i < contVotos.Length; i++)
            {
                if (contVotos[i] > maxVotos)
                {
                    maxVotos = contVotos[i];
                    posMasVotada = i;
                    empate = false;
                }
                else if (contVotos[i] == maxVotos)
                {
                 empatadas.Add(i);
                }
            }
            if (empate)
            {
                Random random = new Random();
                int eleccionAzar = empatadas[random.Next(empatadas.Count)];
                return eleccionAzar;
            }
            else
            {
                return posMasVotada;
            }
        }
        public bool sosIgual(Comparable c)
        {
            
        }
        public bool sosMenor(Comparable c){}
        public bool sosMayor(Comparable c) { }

    }
}