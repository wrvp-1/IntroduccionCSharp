using System;

namespace cicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int contador = 0;
         
            

            do
            {
                Console.WriteLine("Elige " + contador );
               
                contador++;
             
            } while (contador < 10);
           
        }
    }
}
