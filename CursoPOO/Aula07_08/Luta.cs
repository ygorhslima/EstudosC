using System;
using System.Runtime.CompilerServices;

namespace Aula07_08;

public class Luta
{
    Lutador Desafiado;
    Lutador Desafiante;
    int Rounds;
    bool Aprovado;

    public void MarcarLuta(Lutador l1, Lutador l2)
    {
        if(l1.GetCategoria() == l2.GetCategoria() && l1 != l2)
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

    public void Lutar()
    {
        if (Aprovado)
        {
            Console.WriteLine("### DESAFIADO ###");
            Desafiado.Apresentar();
            Console.WriteLine("### DESAFIANTE ###");
            Desafiante.Apresentar();

            Console.WriteLine("-------------------------------------------------");

            Random gerador = new Random();
            int vencedor = gerador.Next(3);
            switch (vencedor)
            {
                case 0:
                    Console.WriteLine("Empatou");
                    Desafiado.EmpatarLuta();
                    Desafiante.EmpatarLuta();
                    break;
                case 1:
                    Console.WriteLine($"Vitoria do {Desafiado.Nome}");
                    Desafiado.GanharLuta();
                    Desafiante.PerderLuta();
                    break;
                case 2:
                    Console.WriteLine($"Vitória do {Desafiante.Nome}");
                    Desafiado.PerderLuta();
                    Desafiante.GanharLuta();
                    break;
                default:
                    Console.WriteLine("ERRO");
                    break;
            }

        }
        else
        {
            Console.WriteLine("Luta não pode ocorrer");
        }
    }
}
