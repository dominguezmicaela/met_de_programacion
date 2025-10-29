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
            int[] votos= new int[3];
            foreach (IAlumno a in hijos)
            {
                int respuesta = a.responderPregunta(pregunta);
                switch (respuesta)
                {
                    case 0: { votos[0]++; break; }
                    case 1: { votos[1]++; break; }
                    case 2: { votos[2]++; break; }
                }
            }
            //busqueda r mas votada
            int maxVotos = votos[0];
            int posMasVotada = 0;
            for (int i = 1; i < votos.Length; i++)
            {
                if (votos[i] > maxVotos)
                {
                    maxVotos = votos[i]; 
                    posMasVotada = i;
                }
                else
                {
                    return maxVotos;
                }
            }
            
            
            

        }
         public bool sosIgual(Comparable c){}
        public bool sosMenor(Comparable c){}
        public bool sosMayor(Comparable c) { }

    }
}