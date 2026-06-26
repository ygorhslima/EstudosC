using System;
using System.Linq.Expressions;

namespace Aula07_08;

public class Lutador(
    string nome,
    string nacionalidade,
    int idade,
    float altura,
    float peso,
    int vitorias,
    int derrotas,
    int empates
)
{
    public string Nome { get; set; } = nome;
    public string Nacionalidade { get; set; } = nacionalidade;
    public int Idade { get; set; } = idade;
    public float Altura { get; set; } = altura;
    public float Peso { get; set; } = peso;

    protected string Categoria;

    public string GetCategoria()
    {
        return this.Categoria;
    }

    public void SetCategoria(string Categoria)
    {
        if (Peso <= 52.2f)
        {
            this.Categoria = "Inválido";
        }
        else if (Peso <= 70.3f)
        {
            this.Categoria = "Leve";
        }
        else if (Peso <= 83.9f)
        {
            this.Categoria = "Médio";
        }
        else if (Peso <= 120.2f)
        {
            this.Categoria = "Pesado";
        }
        else
        {
            this.Categoria = "Inválido";
        }

    }


    public int Vitorias { get; set; } = vitorias;
    public int Derrotas { get; set; } = derrotas;
    public int Empates { get; set; } = empates;


    public void Apresentar()
    {
        Console.WriteLine($"CHEGOU A HORA! Apresentamos o lutador {Nome}");
        Console.WriteLine($"Diretamente de {Nacionalidade}");
        Console.WriteLine($"Com {Idade} anos");
        Console.WriteLine($"pesando {Peso} Kg");
        Console.WriteLine($"Vitórias: {Vitorias}");
        Console.WriteLine($"Derrotas: {Derrotas}");
        Console.WriteLine($"Empates: {Empates}");
    }

    public void Status()
    {
        Console.WriteLine($"{Nome} é um peso {GetCategoria()}");
        Console.WriteLine($"Ganhou {Vitorias} vezes");
        Console.WriteLine($"Perdeu {Derrotas} vezes ");
        Console.WriteLine($"Empatou {Empates} vezes");
    }

    public void GanharLuta() { Vitorias += 1; }
    public void PerderLuta() { Derrotas += 1; }
    public void EmpatarLuta() { Empates += 1; }
}
