using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class TransformandoFahrenheit
    {
        public void MostrarTransformandoFahrenheit()
        {
            // hacer un programa que trasnforme de grados centigrados a grados fahrenheit

            //Varibles
            float gradosC, gradosF;

            //pedimos los °C
            Console.WriteLine("Ingrese los °C:");
            gradosC = Convert.ToSingle(Console.ReadLine());

            //Convertimos los  °C a °F // recordar el 1.8f porque si no ahi un error
            gradosF = (gradosC * 1.8f) + 32;

            //Mostramos el resultado
            Console.WriteLine("{0}  °C = {1} °F", gradosC, gradosF);
        }
    }
}
