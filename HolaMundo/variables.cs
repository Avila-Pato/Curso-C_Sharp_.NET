using System;

namespace HolaMundo
{
    class Variables
    {
        // Método dentro de la clase para mostrar el precio de la camisa
        public void MostrarVariables()
        {
            string colorCamisa = "AZUL";
            double precioCamisa = 392;
            Console.WriteLine("El precio de la camisa es: {0} y " +
                "su color de camisa es {1}" , precioCamisa, colorCamisa);
            Console.WriteLine(colorCamisa);
           
            
        }
    }
}

