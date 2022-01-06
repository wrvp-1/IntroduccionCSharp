using System;

namespace SentenciaIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           int anyValue = 6;
            String messaje = "";

            if (anyValue != 7)
            {
                messaje = "El valor no es 7";
            }
            else
            {
                messaje= "El valor si es 7";
            }
            Console.WriteLine($"The answer is:  {messaje}");

           

        }
    }
}
