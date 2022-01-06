using System;
/*Programa que permite el registro de 10 usuarios, primero preguntaremos si el usuario ya esta registrado
 * si es verdad pediremos que valide su usuario y si al validar no existe en nuestro array le diremos
 * que su usuario no existe que puede registrarse
*/

namespace registroDeUsuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] userName = new String[10] {"","", "", "", "", "", "", "", "", ""};
            int arrayindex = 0; 
            bool userType;
            Console.WriteLine("Bienvenido al restaurante ");

            while (arrayindex < 10)
            { //Mientras los usuarios regitados no sean mayor a tamaño del array procede el ciclo
                /*if (arrayindex == 10)
                {
                    Console.WriteLine("El restaurante se lleno ");
                    Environment.Exit(0);
                }*/
                Console.WriteLine("Si su usuario esta registrado escriba true sino escriba false");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType == true)
                {
                    Console.WriteLine("Hola tu usuario esta registrado escriba cual es su usuario");
                    String userToSerch = Console.ReadLine();
                    Console.WriteLine("Has Ingresado"+ userToSerch);
                    int index = Array.IndexOf(userName, userToSerch);//forma de buscar datos de un array y nos devuelve la posicion
                    //En caso de no encontrar los datos este metodo devuelve -1
                    if(index == -1) 
                    {
                        Console.WriteLine("No hemos encontrado tu usuario! Intenta de nuevo sino regístrate");
                     
                    }
                    else
                    {  //si encontramos el usuario lo mostramos buscando el indice encontrado en el array userName
                        Console.WriteLine("BIENVENIDO: "+ userName[index]);
                    }
                }
                else if(userType == false)
                {
                    Console.WriteLine("Por favor Registra tu usuario");
                    userName[arrayindex] = Console.ReadLine();
                    Console.WriteLine("Usuario registrado correctamente "+
                        "Su usuario es: "+ userName[arrayindex]);
                    arrayindex++;
                }
            }
            Console.WriteLine("El restaurante se lleno ");
            int auxIndex = 0;
            foreach(String element in userName)
            {
                Console.WriteLine("el numero: {0} y usuarios: {1} ", auxIndex+1, userName[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
