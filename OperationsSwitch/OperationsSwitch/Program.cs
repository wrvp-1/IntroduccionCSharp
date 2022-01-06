using System;

namespace OperationsSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige  una opcion matematica ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Parametros Operacion = new Parametros(); //Instanciamos la clase parametros para heredar sus datos
                    Operacion.frase();
                   
                    break;
                case 2:
                    Parametros Operacion2 = new Parametros();
                    Operacion2.frase();
                    break;
            }
         

        }
        //Aqui falto crear una clase para instanciar cada operacion
        class Parametros
        {
            public void frase()
            { 
                Console.WriteLine("Ingresa un valor");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa un valor");
                float num2 = float.Parse(Console.ReadLine());

            }
        }

        
    }
}
