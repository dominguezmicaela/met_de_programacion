using System;
using System.Reflection.Emit;
namespace ConsoleApp1
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, string a, int d, int l, float p, float c) : base(n,a, d, l, p, c) { }
        public override int responderPregunta(int pregunta)
        {
            return base.responderPregunta(pregunta);
        }
    }
}