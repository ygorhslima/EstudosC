Console.Write("Digite seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine($"Seu nome em maiúsculas é: {nome.ToUpper()}");
Console.WriteLine($"Seu nome em minúsculas é: {nome.ToLower()}");
Console.WriteLine($"Seu nome tem ao todo {nome.Length} letras");

string[] partes = nome.Split(' ');
string primeiroNome = partes[0];

Console.WriteLine($"Seu primeiro nome é {primeiroNome} e ele tem {primeiroNome.Length} letras");