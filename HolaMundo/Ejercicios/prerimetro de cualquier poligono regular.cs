using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Problema2
    {
        public void mostrarProblema2()
        {
            // hacer un programa que calcule el; perimetro de cualquier poligono regular


            // variables
            int numeroLados;
            double tamañoLado, perimetro;

            // Pidiendo el numero de los lados
            Console.WriteLine("Ingrese el numero de los lados: ");
            numeroLados = Convert.ToInt32(Console.ReadLine());

            //Pedimos la medida de los lados
            Console.WriteLine("Ingrese el tamaño de uno de los lados: ");
            tamañoLado = Convert.ToDouble(Console.ReadLine());

            //Clculandop el perimetro
            perimetro = numeroLados * tamañoLado;

            // mostramos el resultado

            Console.WriteLine("El perimetro es: {0}", perimetro);

        }
    }
}
