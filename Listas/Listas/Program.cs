// See https://aka.ms/new-console-template for more information
Console.WriteLine("**LISTA DE COMPRAS**");

List<string> listadeTacos = new List<string>();

listadeTacos.Add("Cinco tacos de suadero");
listadeTacos.Add("Cinco tacos de Tripa");
listadeTacos.Add("Cinco tacos de pastor");
listadeTacos.Add("4 Coca Colas");


for (int i=0; i < listadeTacos.Count; i++)
{
    Console.WriteLine(listadeTacos[i]);
}

//Aqui vamos a eliminar una parte de nuestra lista de compras
listadeTacos.Remove("Cinco tacos de suadero");
//listadeTacos.RemoveAt(0); // Eliminacion por indice en la lista
listadeTacos.Add("6 COCAS"); //Aqui agregamos un objeto a la lista

for (int i = 0; i < listadeTacos.Count; i++)
{
    Console.WriteLine(listadeTacos[i]);
}

