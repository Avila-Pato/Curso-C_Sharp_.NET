using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saludo = "hola Mundo";
            char caracter = 'a';

            double i = 9.3;
            int numero = 0;

            Console.WriteLine(i);
            Console.WriteLine(caracter);
            Console.WriteLine(numero);
            Console.WriteLine(saludo);




            // Crear una instancia de la clase Variables
            Variables variables = new Variables();
            // Llamar al método MostrarPrecio
            variables.MostrarPrecio();



        }
    }
}
