using System;

namespace CreandoMetodos
{
    class  MisMetodos
    {
        public float division(float a, float b)
        {
            float operacion = a / b;
            return operacion;
        }
        public static void Main(string[] args)
        {
            MisMetodos metodos = new MisMetodos();
            float imprimir = metodos.division(10, 2);
            Console.WriteLine("Hola estoy probando mi metodo: " + imprimir);
        }
    }
}
