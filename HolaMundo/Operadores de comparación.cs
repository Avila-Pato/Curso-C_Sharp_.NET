using System;

namespace HolaMundo
{
    class Operadores_de_comparacion
    {
        public void MostrarOperadores_de_comparacion()
        {
            int a = 10;
            int b = 20;

            // Igual a
            Console.WriteLine("a == b: " + (a == b)); // False

            // Diferente de
            Console.WriteLine("a != b: " + (a != b)); // True

            // Mayor que
            Console.WriteLine("a > b: " + (a > b)); // False

            // Menor que
            Console.WriteLine("a < b: " + (a < b)); // True

            // Mayor o igual que
            Console.WriteLine("a >= b: " + (a >= b)); // False

            // Menor o igual que
            Console.WriteLine("a <= b: " + (a <= b)); // True
        }

    }
}
