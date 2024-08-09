using System;

namespace HolaMundo
{
    class ConvertToNumber
    {
        public void MostrarConvertToNumber() 
        
        {
            int numero = 123;

            string cadena = Convert.ToString(numero);
            Console.WriteLine("Número como cadena: " + cadena); // Resultado: "123"

            // Convertir una cadena a un número entero .ToInt32
            string cadenaNumero = "456";

            int numeroConvertido = Convert.ToInt32(cadenaNumero);
            Console.WriteLine("Cadena a número: " + numeroConvertido); // Resultado: 456

            // Convertir un número a un tipo de punto flotante
            double doble = Convert.ToDouble(numero);
            Console.WriteLine("Número a doble: " + doble); // Resultado: 123.0

            // Convertir un valor booleano a un entero
            bool booleano = true;

            int entero = Convert.ToInt32(booleano);
            Console.WriteLine("Booleano a entero: " + entero); // Resultado: 1

            // Convertir un valor nulo a un tipo de dato específico
            object valorNulo = null;
            
            int enteroNulo = Convert.ToInt32(valorNulo);
            Console.WriteLine("Valor nulo a entero: " + enteroNulo); // Resultado: 0
        }
    }
}
