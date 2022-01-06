using System;

namespace SwitchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona la soda que deseas");
            String caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "coca":
                    Console.WriteLine("cola soda -$ 2 USD");
                    break;

                case "limon":
                    Console.WriteLine("soda de $1 USD");
                    break;

                case "Naranja":
                    Console.WriteLine("Soda de $1.5 USD");
                    break;

                case "manzana":
                    Console.WriteLine("Soda de $2 USD");
                    break;

                default:
                    Console.WriteLine("ERROR no eligio una bebida");
                    break;
            }
        }
    }
}
