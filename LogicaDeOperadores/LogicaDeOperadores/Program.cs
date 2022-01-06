// See https://aka.ms/new-console-template for more information
Console.WriteLine("**Valores logicos**");

bool value1 = true;
bool value2 = true;
bool value3 = false;

//Operador and &&, or ||, not !

bool result = value1 && value2 && value3;
Console.WriteLine("The result of the logical AND Is: " + result);

bool result2 = value1 || value2 || value3;
Console.WriteLine("The result of the logical OR Is: " +  result2);

bool result3 = !value1;
Console.WriteLine("The result of the logical NOT Is: " + result3 );


//OPERADORES RELACIONALES
/* == Igual a 
 != No Igual a 
 > Mayor que
 < Menor que
>= Mayor o Igual que
<= Menor o Igual Que
 * */
Console.WriteLine("**OPERADORES RELACIONALES**");
int num1= 3;
int num2 = 18;


bool results1 = num1 == num2;
bool results2 = num1 != num2;
bool results3 = num1 > num2;
bool results4 = num1 < num2;
bool results5 = num1 >= num2;
bool results6 = num1 <= num2;

Console.WriteLine("The result of the value1 == value 2 is: " + results1);
Console.WriteLine("The result of the value1 != value 2 is: " + results2);
Console.WriteLine("The result of the value1 > value 2 is: " + results3);
Console.WriteLine("The result of the value1 < value 2 is: " + results4);
Console.WriteLine("The result of the value1 >= value 2 is: " + results5);
Console.WriteLine("The result of the value1 <= value 2 is: " + results6);
