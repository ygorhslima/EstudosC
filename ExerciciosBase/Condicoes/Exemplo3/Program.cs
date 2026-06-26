
void AumentoSalario(float sal, int percentual)
{
    float aumento = sal * (percentual / 100f);
    float reajuste = sal + aumento;
    Console.WriteLine($"O aumento é de {aumento}");
    Console.WriteLine($"o novo salário é {reajuste}");    
}


Console.WriteLine("digite uma opção de cargo:\n[1] Servicos Gerais\n[2] Vigia\n[3] Recepcionista\n[4]Vendedor");

int cargoOpcoes = int.Parse(Console.ReadLine());

Console.Write("Digite o salário: ");
float salario = float.Parse(Console.ReadLine());

switch (cargoOpcoes)
{
    case 1:
        AumentoSalario(salario, 50);
        break;
    case 2:
        AumentoSalario(salario, 30);
        break;
    case 3:
        AumentoSalario(salario, 25);
        break;
    case 4:
        AumentoSalario(salario, 15);
        break;
    default:
        Console.WriteLine("ERRO!");
        break;
}