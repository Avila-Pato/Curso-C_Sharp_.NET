using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Problema1
    {
        public void MostrarProblema1()
        {
        //// Realizar un programa de computadora que haga el calculo 
        /// del area y perimetri de un rectangulo
        
            //Variables
            double altura, ancho, area, perimetro;

            //Pidiendo altura y convertimos a double
            Console.WriteLine("Ingrese la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());


            //Pedimos la altura y convertimos en tipo Double
            Console.WriteLine("Ingrese base: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //Calculamos el area
            area = altura * ancho;

            //calculamos el perimetro
            perimetro = 2 * (altura / area);

            // Mostrar resultados en pantalla
            Console.WriteLine("El area es: {0}", area);
            Console.WriteLine("El perimetro es: {0}", perimetro);
        }
    }
}
