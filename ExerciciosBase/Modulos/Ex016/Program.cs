Console.Write("Digite um valor: ");
decimal v = decimal.Parse(Console.ReadLine() ?? string.Empty);

decimal porcaoInt = Math.Floor(v);

Console.WriteLine($"O valor digitado foi {v} e a sua porção inteira é {porcaoInt}");