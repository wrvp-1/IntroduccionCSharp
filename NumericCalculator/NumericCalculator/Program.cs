// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1;
int number2;

Console.WriteLine("Input the first numbers ");
/*Aqui realisamos una conversion explísita de entero a string  */
number1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input the second numbers ");
number2 = Convert.ToInt32(Console.ReadLine());


int result = number1 * number2;
Console.WriteLine("The Result Is: " + result);