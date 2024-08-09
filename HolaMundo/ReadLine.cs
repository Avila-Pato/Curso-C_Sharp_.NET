using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class ReadLine
    {
        public void MostrarReadLine()
        {

            string nombre;
            // Preguntando al usuario 
            Console.WriteLine("Quetal cual es tu nombre?: ");
            nombre = Console.ReadLine();

            //Saludando al usuario
            Console.WriteLine("Hola {0}, es un placer", nombre);
        }
    }
}
