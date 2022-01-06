using System;

namespace IfOperacionesMatematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que operacion deseas Realizar elige una Opcion");
            Console.WriteLine("1. Suma ");
            Console.WriteLine("2. Resta ");
            Console.WriteLine("3. Multiplicacion ");
            Console.WriteLine("4. Division ");



            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingresa un numero ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa un numero ");
                float num2 = float.Parse(Console.ReadLine());

                float Suma = num1 + num2;
                Console.WriteLine("El resultado es: " + Suma);


            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingresa un numero ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa un numero ");
                float num2 = float.Parse(Console.ReadLine());

                float Resta = num1 - num2;
                Console.WriteLine("El resultado es: " + Resta);
            }
            if (opcion == 3)
            {
                Console.WriteLine("Ingresa un numero ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa un numero ");
                float num2 = float.Parse(Console.ReadLine());

                float Multi = num1 * num2;
                Console.WriteLine("El resultado es: " + Multi);
            }
            if (opcion == 4)
            {
                Console.WriteLine("Ingresa un numero ");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa un numero ");
                float num2 = float.Parse(Console.ReadLine());

                float Division = num1 / num2;
                Console.WriteLine("El resultado es: " + Division);
            }
            else
            {
                Console.WriteLine("Elige un numero segun la opcion");
            }
        }
    }
}
