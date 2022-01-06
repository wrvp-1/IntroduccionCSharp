// See https://aka.ms/new-console-template for more information
Console.WriteLine("BIENVENIDOS A COFFE FRESH");

string[] coffeTypes;
float[] coffePrices;

coffeTypes = new string[]{ "Express", "Largo", "Filtrado", "Latte" };
coffePrices = new float[] { 1.5f, 2.5f, 5.0f, 5.5f };

coffeTypes[1] = "Lungo"; //Aqui modico el arreglo 1 laergo por lungo

for (int i = 0; i < coffeTypes.Length; i++)
    Console.WriteLine("Cofee: " + coffeTypes[i] + "  Precio: $" + coffePrices[i]);
