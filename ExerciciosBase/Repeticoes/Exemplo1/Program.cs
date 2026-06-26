int pedido, qtdade;
float preco, total;
string data;

total = 0;

Console.Write("Informe o número do pedido (ou 0 para sair): ");
pedido = int.Parse(Console.ReadLine());

while(pedido != 0)
{
    Console.Write("Informe a data: ");
    data = Console.ReadLine();

    Console.Write("Informe o preço unitário: ");
    preco = float.Parse(Console.ReadLine());

    Console.Write("Informe a quantidade: ");
    qtdade = int.Parse(Console.ReadLine());
    
    float valorItem = preco * qtdade; 
    total += valorItem; 
    
    Console.WriteLine($"O valor deste item é: {valorItem}");

    Console.WriteLine("-------------------------------");
    Console.Write("Informe o número do próximo pedido (ou 0 para encerrar): ");
    pedido = int.Parse(Console.ReadLine());
}

Console.WriteLine($"\nO TOTAL GERAL da compra é: {total:F2}");