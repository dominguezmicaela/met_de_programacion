using System;
using System.Collections;
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
        public float Calificacion
        {
            get { return 0; }
            set { foreach (IAlumno a in hijos){ a.Calificacion = value;}}
        }
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

        public string mostrarCalificacion()
        { string resultado = " ";
            foreach (IAlumno a in hijos){resultado += a.mostrarCalificacion();}
            return resultado;
        }

        public int responderPregunta(int pregunta)
        {
            int[] contVotos= new int[3];
            foreach (IAlumno a in hijos)
            {
                int respuesta = a.responderPregunta(pregunta);
                contVotos[respuesta]++;
            }
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
            if (this.hijos.Contains(c)) { return true; }
            else{return false;}  
            
        }
        public bool sosMenor(Comparable c)
        {
            foreach (IAlumno a in hijos){ if (!a.sosMenor(c)){return false;}}
            return true;
        }
        public bool sosMayor(Comparable c)
        {
            foreach (IAlumno a in hijos){ if (!a.sosMayor(c)){return false;}}
            return true;
        }

    }
}