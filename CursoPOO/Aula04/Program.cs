// See https://aka.ms/new-console-template for more information
using Aula04;

Caneta c1 = new("Bic Cristal", "Azul", 0.5f, 100, true);

Console.WriteLine(c1.GetModelo());
Console.WriteLine(c1.GetCor());
Console.WriteLine(c1.GetCarga());
Console.WriteLine(c1.GetPonta());
Console.WriteLine(c1.ToString());