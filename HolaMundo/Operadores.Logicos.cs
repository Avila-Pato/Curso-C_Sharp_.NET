using System;

namespace HolaMundo
{
    class Operadores_logicos
    {
        public void MostrarOperadores_logicos()
        {
            int a = 10;
            int b = 20;
            int c = 15;
            int d = 5;

            // AND lógico (&&)
            bool andResult = (a < b) && (c > d);
            Console.WriteLine("AND lógico (&&): " + andResult); // True

            // OR lógico (||)
            bool orResult = (a > b) || (c > d);
            Console.WriteLine("OR lógico (||): " + orResult); // True

            // NOT lógico (!)
            bool notResult = !(a > b);
            Console.WriteLine("NOT lógico (!): " + notResult); // True

            // XOR lógico (^)
            bool xorResult = (a < b) ^ (c < d);
            Console.WriteLine("XOR lógico (^): " + xorResult); // True
        }

    }
}
