using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Jerarquia_de_operaciones
    {
        public void MostrarJerarquia()
        {
            int a = 10;
            int b = 5;
            int c = 2;

            int resultado = a + b * c / 2 - (a % c); 
            
            // Jerarquía de operaciones
            // Evaluación:
            // Primero se realiza la multiplicación (b * c) = 5 * 2 = 10
            // Luego la división (10 / 2) = 5
            // Después la suma (a + 5) = 10 + 5 = 15
            // Finalmente la resta (15 - (a % c)) = 15 - (10 % 2) = 15 - 0 = 15

            Console.WriteLine(resultado);
        }
    }
}
