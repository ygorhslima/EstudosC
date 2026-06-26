using System;

namespace Aula12;

public abstract class Animal(
    float peso,
    int idade, 
    int membros
)
{
    protected float Peso = peso;
    protected int Idade = idade;
    protected int Membros = membros;

    public float GetPeso()
    {
        return this.Peso;
    }

    public void SetPeso(float Peso)
    {
        this.Peso = Peso;
    }

    public int GetIdade()
    {
        return this.Idade;
    }

    public void SetIdade(int Idade)
    {
        this.Idade = Idade;
    }

    public int GetMembros()
    {
        return this.Membros;
    }

    public void SetMembros(int Membros)
    {
        this.Membros = Membros;
    }

    public string ToString()
    {
        return $"Peso: {Peso}\nIdade: {Idade}\nMembros: {Membros}";
    }

    public abstract void Locomover();
    public abstract void Alimentar();
    public abstract void EmitirSom();
}
