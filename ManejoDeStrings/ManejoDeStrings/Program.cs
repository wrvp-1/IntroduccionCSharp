using System;

namespace ManejoDeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int height = 170;
            int age = 20;
            string name = "Wilson Vasquez";
            string information = " \n The requested info is: \n User name: "+ name + " \n User age: " 
                + age + " \n User heigth: " + height;

            Console.WriteLine(information );


        }
    }
}
