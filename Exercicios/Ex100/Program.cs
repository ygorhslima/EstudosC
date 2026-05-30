using System;
using System.Collections.Generic;
using System.Globalization; // OBRIGATÓRIO para usar o CultureInfo

namespace Exercicios.Ex100;

public class Aluno
{
    public string Nome { get; set; } = "";
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }
    public decimal Media => (Nota1 + Nota2) / 2;
}

public class Program
{
    public static void Main(string[] args)
    {
        string resposta = "S";
        List<Aluno> listaAlunos = [];

        // 1. LEITURA DOS DADOS
        while (resposta == "S")
        {
            Aluno aluno = new();
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine() ?? "";

            // Lemos como texto, trocamos vírgula por ponto se houver, e convertemos com InvariantCulture
            Console.Write("Nota 1: ");
            string entradaNota1 = (Console.ReadLine() ?? "0").Replace(",", ".");
            aluno.Nota1 = decimal.Parse(entradaNota1, CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            string entradaNota2 = (Console.ReadLine() ?? "0").Replace(",", ".");
            aluno.Nota2 = decimal.Parse(entradaNota2, CultureInfo.InvariantCulture);

            listaAlunos.Add(aluno);

            Console.Write("Quer Continuar? [S/N] ");
            resposta = (Console.ReadLine() ?? "").ToUpper();
        }

        // 2. EXIBIÇÃO DO BOLETIM (Com alinhamento fixo e ponto forçado)
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($"{"No.",-4} {"NOME",-12} {"MÉDIA",-5}");
        Console.WriteLine("------------------------------------------------");
        for (int i = 0; i < listaAlunos.Count; i++)
        {
            // O "F1" força uma casa decimal e o InvariantCulture garante o PONTO (.)
            string mediaFormatada = listaAlunos[i].Media.ToString("F1", CultureInfo.InvariantCulture);
            
            // O ,-4 e ,-12 fazem o texto ficar alinhado em colunas retinhas
            Console.WriteLine($"{i,-4} {listaAlunos[i].Nome,-12} {mediaFormatada,-5}");
        }
        Console.WriteLine("------------------------------------------------");

        // 3. CONSULTA INDIVIDUAL
        while (true)
        {
            Console.Write("Mostrar notas de qual aluno? (999 interrompe): ");
            int opc = int.Parse(Console.ReadLine() ?? "999");

            if (opc == 999)
            {
                Console.WriteLine("FINALIZANDO...");
                break;
            }

            if (opc >= 0 && opc < listaAlunos.Count)
            {
                // Formatando as notas individuais também com ponto e uma casa decimal
                string n1 = listaAlunos[opc].Nota1.ToString("F1", CultureInfo.InvariantCulture);
                string n2 = listaAlunos[opc].Nota2.ToString("F1", CultureInfo.InvariantCulture);

                Console.WriteLine($"Notas de {listaAlunos[opc].Nome} são [{n1}, {n2}]");
            }
            else
            {
                Console.WriteLine("Opção inválida! Aluno não encontrado");
            }
            Console.WriteLine("------------------------------------------------");
        }
        Console.WriteLine("<<VOLTE SEMPRE>>");
    }
}