using System;


namespace HolaMundo
{
    class Operadores
    {

        public void MostrarOperadores() 
        {

            // Asigna el valor 5 a la variable a
            int a = 5; // Asignación inicial
            a = 10; // Actualización del valor
            Console.WriteLine(a);


            int b = 5;
            b += 3; // a es ahora 8 (equivalente a a = a + 3)
            Console.WriteLine(b);

            int c = 10;
            c -= 3; // a es ahora 7 (equivalente a a = a - 3)
            Console.WriteLine(c);

            int e = 4;
            e *= 6; // a es ahora 24 (equivalente a a = a * 6)
            Console.WriteLine(e);


            int h = 20;
            h /= 4; // a es ahora 5 (equivalente a a = a / 4)

            Console.WriteLine(h);

            int r = 17;
            r %= 5; // a es ahora 2 (equivalente a a = a % 5)

            Console.WriteLine(r);
        }

     
    }
}
