using System;

namespace leeDatosUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el area A de un rectangulo: ");
            float sideA = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el area B de un rectangulo: ");
            float sideB = float.Parse(Console.ReadLine());


            float area = sideA * sideB;
            Console.WriteLine("El area del rectangulo es: " + area);


        }
    }
}
