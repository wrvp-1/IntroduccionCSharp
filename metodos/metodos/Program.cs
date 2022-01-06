using System;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usemos el metodos Random");

            float[] pricesArray;

            pricesArray = new float[10];
            pricesArray[0] = 1.5f;
            pricesArray[1] = 2.5f;
            pricesArray[2] = 3f;
            pricesArray[3] = 5f;
            pricesArray[4] = 1.5f;

            Random rnd = new Random();
            Console.WriteLine($"{rnd.Next(1, 10)}"); //Argumentos un minimo y un maximo


            Console.WriteLine("**CONCATENANDO STRINGS**");
            String ClassTopic = "Metodos String";
            String School = "Platzi";
            Console.WriteLine("Estoy aprendiendo " + ClassTopic + " En: " + School);


            //Este metodo crea un clon de una variable de tipo string en una variable de tipo objeto
            //Por ello es necesario convertirlo a string utilizando ToString
            Console.WriteLine("Metodo clone()");
            string SchoolClone = School.Clone().ToString();
            Console.WriteLine(SchoolClone);

            //Metodo que sirve para comparar el contenido de dos strings. si son iguales devuelve 0 
            Console.WriteLine("Usando el metodo CompareTo() ");
            Console.WriteLine(ClassTopic.CompareTo(School));
            Console.WriteLine(School.CompareTo(SchoolClone));


            //Este metodo retorna true si el string contiene los mismos carateres que se pongan en los- 
            //argumentos del metodo
            Console.WriteLine("Metodo Contains()");
            Console.WriteLine(School.Contains("Wil"));


            //Similar a Contains() pero para comparar si los caracteres estan al final del string
            Console.WriteLine("Metodo EndsWith()");
            Console.WriteLine(School.EndsWith("zi"));



            //Funciona de la misma manera que EndsWith() pero en este caso comprueba los caractere
            //que estan al principio 
            Console.WriteLine("Metodo StartsWith()");
            Console.WriteLine(School.StartsWith("Pl"));


            //Funciona de forma parecida que CompareTo() pero para indicar si el contenido de 
            //ambos strings retorna True o False
            Console.WriteLine("Metodo Equals() ");
            Console.WriteLine(School.Equals(SchoolClone));


            //Regresa la posición dentro del string del caraccter indicado en el argumento
            Console.WriteLine("Metodo IndexOf()");
            Console.WriteLine(School.IndexOf("a"));


            //Metodo que convierte todo el string en letras minusculas
            Console.WriteLine("Metodo ToLower()");
            Console.WriteLine(ClassTopic.ToLower());


            //Metodo que convierte todo un string en letars mayusculas
            Console.WriteLine("Metodo ToUpper()");
            Console.WriteLine(ClassTopic.ToUpper());


            //Metodo que inserta un nuevo string dentro de otro en la posicion indicada
            //dentro de los argumentos en este caso es en 6 que es la posición despues
            //de la ultima letra de "Platzi"
            Console.WriteLine("Metodo Insert()");
            Console.WriteLine(School.Insert(6, " Es educacion en linea"));


            //Musetra la posicion  siguiente al encontrar el carcter en este caso
            //devuelve la  posicion 5 pues es la ultima posición donde encontro de primero el caracter
            Console.WriteLine("Metodo LastIndexOf()");
            Console.WriteLine(ClassTopic.LastIndexOf("o"));


            //Elimina los caracteres del string a  partir de la posicion que le indiquemos hasta el final
            Console.WriteLine("Metodo Remove()");
            Console.WriteLine(School.Remove(4));

            //Reemplaza todos los caracteres por otro indicado en este caso todas las s seran cambiadas por z
            Console.WriteLine("Metodo Replace()");
            Console.WriteLine(ClassTopic.Replace("s", "z"));


            //Este es un caso especial donde creamos un nuevo string donde guardamos el string separado
            //en trosos por la letra indicada 
            Console.WriteLine("Metodo Split()");
            string[] split = ClassTopic.Split(new char[] { 's' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);


            //Devuelve un trozo de string de acuredo a las posiciones indicadas en los argumentos
            Console.WriteLine("Metodo Substring()");
            Console.WriteLine(ClassTopic.Substring(2,10));

        }


    }

}
