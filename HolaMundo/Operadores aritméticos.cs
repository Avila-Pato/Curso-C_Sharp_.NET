using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
     class Operadores_aritméticos
    {
        public void MostrarOperadoresAritmaticos()
        {
            int a = 10;
            int b = 3;

            // Suma
            int suma = a + b;
            Console.WriteLine("Suma: " + suma); // Resultado: 13

            // Resta
            int resta = a - b;
            Console.WriteLine("Resta: " + resta); // Resultado: 7

            // Multiplicación
            int multiplicacion = a * b;
            Console.WriteLine("Multiplicación: " + multiplicacion); // Resultado: 30

            // División
            int division = a / b;
            Console.WriteLine("División: " + division); // Resultado: 3

            // Módulo
            int modulo = a % b;
            Console.WriteLine("Módulo: " + modulo); // Resultado: 1

            // Incremento
            a++;
            Console.WriteLine("Incremento: " + a); // Resultado: 11

            // Decremento
            b--;
            Console.WriteLine("Decremento: " + b); // Resultado: 2
        }
    }
}
