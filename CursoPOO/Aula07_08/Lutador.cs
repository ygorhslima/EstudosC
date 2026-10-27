using System;

namespace Aula07_08;

public class Lutador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public float Altura { get; set; }
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Empates { get; set; }
    private float peso;

    public float Peso 
    {
        get => peso;
        set 
        {
            peso = value;
            SetCategoria();
        }
    }
    
    public string? Categoria { get; private set; } = "";

    public Lutador(string nome,
                   string nacionalidade,
                   int idade,
                   float altura,
                   float peso,
                   int vitorias,
                   int derrotas,
                   int empates)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Altura = altura;
        Peso = peso;
        Vitorias = vitorias;
        Derrotas = derrotas;
        Empates = empates;
    }

    private void SetCategoria()
    {
        if (Peso < 52.2f)
        {
            Categoria = "Abaixo do Peso, não pode participar do torneio";
        }
        else if (Peso <= 70.3f)
        {
            Categoria = "Leve";
        }
        else if (Peso <= 83.9f)
        {
            Categoria = "Médio";
        }
        else if (Peso <= 120.2f)
        {
            Categoria = "Pesado";
        }
        else
        {
            Categoria = "Inválido";
        }
    }

    public void Apresentar()
    {
        Console.WriteLine($"""
        Lutador: {Nome}
        Origem: {Nacionalidade}
        Idade: {Idade} anos
        Altura: {Altura}m
        Pesando: {Peso}kg
        Ganhou: {Vitorias}
        Perdeu: {Derrotas}
        Empatou: {Empates}
        """);
    }

    public void Status()
    {
        Console.WriteLine($"""
        {Nome} é um peso {Categoria}
        {Vitorias} vitórias
        {Derrotas} derrotas
        {Empates} empates
        """);
    }

    public void GanharLuta() { Vitorias++; }
    public void PerderLuta() { Derrotas++; }
    public void EmpatarLuta() { Empates++; }
}