using System;
namespace ConsoleApp1
{
    public class AlumnoAdapter : Student
    {
        //atributos
        private Alumno alumno;
        //Constructor
        public AlumnoAdapter(Alumno a) { this.alumno = a; }
        //METODOS	
        public string getName() { return  this.alumno.getNombre(); }
		public int yourAnswerIs(int question){ return this.alumno.responderPregunta(question); }
		public  void setScore(int score){ this.alumno.Calificacion = score; ; }
		public string showResult(){ return this.alumno.mostrarCalificacion(); }
        public bool equals(Student student){return alumno.sosIgual(((AlumnoAdapter)student).alumno);}
		public bool lessThan(Student student) { return alumno.sosMenor(((AlumnoAdapter)student).alumno); }
		public bool greaterThan(Student student){ return alumno.sosMayor(((AlumnoAdapter)student).alumno); }
    }
}