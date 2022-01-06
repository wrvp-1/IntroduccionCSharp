using System;

namespace Ciclo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimamos la tabla de 10");
            int iter = 1;
            int tabla = 10;
            while (iter <11)
            {
                int result = tabla * iter;
                Console.WriteLine(tabla+" * "+ iter+"= "+ result);
                iter++;

            }
            
        }
    }
}
