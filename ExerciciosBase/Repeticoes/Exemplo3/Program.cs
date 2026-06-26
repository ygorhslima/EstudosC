Console.Write("Digite um valor: ");
int num = int.Parse(Console.ReadLine());

int fat = 1;

for (int cont = num; cont > 1; cont -= 1) { fat *= cont; }

Console.WriteLine($"O fatorial é {fat}");