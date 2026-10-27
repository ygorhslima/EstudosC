using System;
namespace Aula07_08;
public class Luta
{
    public Lutador? Desafiado {get;set;}
    public Lutador? Desafiante {get;set;}
    public int Rounds {get;set;}
    public bool Aprovado {get;set;}

    public void Lutar()
    {
        if (Aprovado)
        {
            Console.WriteLine("-=-=-=--=-=-=-=-= DESAFIADO -=-=-=--=-=-=-=-=");
            Desafiado?.Apresentar();
            Console.WriteLine("-=-=-=--=-=-=-=-= DESAFIANTE -=-=-=--=-=-=-=-=");
            Desafiante?.Apresentar();
            
            var random = new Random();
            int vencedor = random.Next(0,2);
            
            switch (vencedor)
            {
                case 0: // empate
                    Console.WriteLine("-=-=-=-=-=- RESULTADO =-=-=-=-=-=");
                    Console.WriteLine("Empatou");
                    
                    Desafiado?.EmpatarLuta();
                    Desafiante?.EmpatarLuta();
                    break;
                case 1: // ganhou desafiado
                    Console.WriteLine("-=-=-=-=-=- RESULTADO =-=-=-=-=-=");
                    Console.WriteLine($"{Desafiado?.Nome} ganhou");
                    Console.WriteLine($"{Desafiante?.Nome} perdeu");
                    
                    Desafiado?.GanharLuta();
                    Desafiante?.PerderLuta();

                    Console.WriteLine($"Agora {Desafiado?.Nome} tem {Desafiado?.Vitorias} vitórias!");
                    break;
                case 2: // ganhou desafiante
                    Console.WriteLine("-=-=-=-=-=- RESULTADO =-=-=-=-=-=");
                    Console.WriteLine($"{Desafiante?.Nome} ganhou");
                    Console.WriteLine($"{Desafiado?.Nome} perdeu");

                    Desafiante?.GanharLuta();
                    Desafiado?.PerderLuta();

                    Console.WriteLine($"Agora {Desafiante?.Nome} tem {Desafiante?.Vitorias} vitórias!");
                    break;
                default:
                    break;
            }
        }
        else
        {
            Console.WriteLine("Luta não pode acontecer");
        }
    }

    public void MarcarLuta(Lutador l1, Lutador l2)
    {
        if((l1.Categoria == l2.Categoria) && (l1 != l2))
        {
            Aprovado = true;
            Desafiado = l1;
            Desafiante = l2;
        }
        else
        {
            Aprovado = false;
            Desafiado = null;
            Desafiante = null;
        }
    }
}
