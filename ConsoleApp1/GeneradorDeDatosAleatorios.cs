using System;


namespace ConsoleApp1
{
    public class GeneradorDeDatosAleatorios
    {

        //P3E2
        //atributos
        private Random random;
        //constructor
        public GeneradorDeDatosAleatorios() { random = new Random(); }
        //metodos
        // un metodo  que me retorne un entero entre 0 y n maximo 
        public int numeroAleatorio(int max) { return random.Next(max); }
        //retorna un string aleatorio de x cantidad de caracteres
        public string stringAleatoriO(int cantidad)
        {
            //defino una constante con los caracteres que se encuentran en el abecedario
            const string caracteres = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            char[] resultado = new char[cantidad]; // porque se puede modificar caracter x car. con los string no se puede
            //recorro el vector
            for (int i = 0; i < cantidad; i++)
            {
                int indice = random.Next(caracteres.Length);
                resultado[i] = caracteres[indice];
            }
            //retorno el resultado casteado a string
            return new string(resultado);
            
            
        }
        

    }
}