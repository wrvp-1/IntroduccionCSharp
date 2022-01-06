using System;

namespace squareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //este programa calcula el area de un rectangulo
            Console.WriteLine("Ingresa el area del rectangulo");

            float sideA = float.Parse(Console.ReadLine());

            int sideB = 21;

            // EL AREA DE UN CUADRADO ES A X B

            float area = (sideA * sideB);
            //si podemos multiplicar un int con float siempre que el resultado sea float

            Console.WriteLine("El Resultado es: " + area);
        }
    }
}
