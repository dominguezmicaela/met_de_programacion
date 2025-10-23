using System;
namespace ConsoleApp1
{
    public class AlumnoProxy:IAlumno
    {
        //atributos
        //debe devolver todos los datos del alumno pero el metodo costoso en donde se crea es en responder pregunta
        private IAlumno alumno=null;
        private string nomProxy;
        private string apeProxy;
        private int dniProxy;
        private int legProxy;
        private float promProxy;
        private float calProxy;
        private int opcion;
        // constructor
        public AlumnoProxy(string n, string a, int d, int l, float p,float c,int o)
        {
            this.nomProxy = n;
            this.apeProxy = a;
            this.dniProxy = d;
            this.legProxy = l;
            this.promProxy = p;
            this.calProxy = c;
            this.opcion = o;

        }
        //propiedades
        public string Nombre { get { return nomProxy; } set {nomProxy=value;} }
        public string Apellido {  get { return apeProxy; } set {apeProxy=value;}}
        public int Dni{  get { return dniProxy; } set {dniProxy=value;}}
        public int Legajo{get { return legProxy; } set {legProxy=value;}}
        public float Promedio{get { return promProxy; } set {promProxy=value;}}
        public float Calificacion { get { return calProxy; } set { calProxy = value; } }

        //metodos
        private void alumnoReal()
        {
            //alumno depende si es muy estudioso o no

            if (opcion == 1)
            {
                if (alumno == null) { alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2); }
            }
            else
            {
                if (alumno == null) { alumno = (IAlumno)FabricaDeComparables.crearAleatorio(4); }
            }
        }
        public string mostrarCalificacion()
        {
            alumnoReal();
            return alumno.mostrarCalificacion();}
        public int responderPregunta(int pregunta)
        {
            alumnoReal();
            return alumno.responderPregunta(pregunta);
        }
        public bool sosIgual(Comparable c)
        {
            alumnoReal();
            return alumno.sosIgual(c);
        }
        public bool sosMenor(Comparable c)
        {
            alumnoReal();
            return alumno.sosMenor(c);
        }
        public bool sosMayor(Comparable c)
        {
            alumnoReal();
            return alumno.sosMayor(c);
        }



    }
}