Console.WriteLine("Que ano quer analisar? Coloque 0 para analisar o ano atual: ");
int ano = int.Parse(Console.ReadLine() ?? string.Empty);
bool EhBissexto = (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0);

if(ano == 0)
{
    ano = DateTime.Now.Year;
}
if (EhBissexto)
{
    Console.WriteLine($"{ano} é BISSEXTO");
}
else
{
    Console.WriteLine($"{ano} NÃO é BISSEXTO");
}