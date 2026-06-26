using System;

namespace Aula04;

public class Caneta(string m,string c, float p, int ca, bool t)
{
    private string Modelo = m;
    private string Cor = c;
    private float Ponta = p;
    private int Carga = ca;
    private bool Tampada = t;


    public string GetModelo() {
        return Modelo;
    }

    public void SetModelo(string Modelo) {
        this.Modelo = Modelo;
    }

    public string GetCor() {
        return Cor;
    }

    public void SetCor(string Cor) {
        this.Cor = Cor;
    }

    public float GetPonta() {
        return Ponta;
    }

    public void SetPonta(float Ponta) {
        this.Ponta = Ponta;
    }

    public int GetCarga() {
        return Carga;
    }

    public void SetCarga(int Carga) {
        this.Carga = Carga;
    }

    public bool IsTampada() {
        return Tampada;
    }

    public void SetTampada(bool Tampada) {
        this.Tampada = Tampada;
    }


    public void Rabiscar()
    {
        Console.WriteLine("Rabiscando");
    }

    public void Tampar()
    {
        Tampada = true;
    }

    public string ToString()
    {
        return $"Modelo: {Modelo}\nCor: {Cor}\nPonta: {Ponta}\nCarga: {Carga}\nTampada: {Tampada}";
    }
}
