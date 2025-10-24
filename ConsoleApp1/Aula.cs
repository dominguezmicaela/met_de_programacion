using System;
namespace ConsoleApp1{
    public class Aula
    {
        //atributos
        private Teacher teacher;
        //metodos
        public void comenzar()
        {
            Console.WriteLine("COMIENZA LA CLASE");
            teacher = new Teacher();
        }
        //nuevoAlumno(Alumno)  Agrega al teacher el alumno recibido como parámetro usando el método goToClass.
        public void nuevoAlumno(IAlumno a)
        {
            Student student = new AlumnoAdapter(a);
            teacher.goToClass(student);
        }
        public void claseLista(){ teacher.teachingAClass(); }
    }
}