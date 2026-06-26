int cont = 0;
float media = 0f, alto = 0f, pesado = 0f, soma=0;
string nalto="", npesado="";

Console.WriteLine("Informe o nome do atleta ou FIM para encerrar: ");
string nome = Console.ReadLine();

while (nome != "FIM")
{
    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Peso: ");
    float peso = float.Parse(Console.ReadLine());

    Console.Write("Altura: ");
    float altura = float.Parse(Console.ReadLine());

    Console.Write("Sexo: ");
    string sexo = Console.ReadLine();

    soma += idade;
    cont += 1;

    if (sexo == "M" && altura > alto)
    {
        alto = altura;
        nalto = nome;
    }
    if (sexo == "F" && peso > pesado)
    {
        pesado = peso;
        npesado = nome;
    }


    Console.WriteLine("Informe o nome do atleta ou FIM para encerrar: ");
    nome = Console.ReadLine();
}
Console.WriteLine($"o nome do atleta mais alto é {nalto}");
Console.WriteLine($"o nome da atleta mais pesada é {npesado}");
