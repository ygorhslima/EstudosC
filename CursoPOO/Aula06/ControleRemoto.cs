using System;

namespace Aula06;

public class ControleRemoto : Controlador
{
    private int Volume;
    private bool Ligado;
    private bool Tocando;

    public int GetVolume()
    {
        return this.Volume;
    }

    public void SetVolume(int Volume)
    {
        this.Volume = Volume;
    }

    public bool IsLigado()
    {
        return this.Ligado;
    }

    public void SetLigado(bool Ligado)
    {
        this.Ligado = Ligado;
    }

    public bool IsTocando()
    {
        return this.Tocando;
    }

    public void SetTocando(bool Tocando)
    {
        this.Tocando = Tocando;
    }


    public ControleRemoto()
    {
        Volume = 20;
        Ligado = false;
        Tocando = false;
    }



    public void AbrirMenu()
    {
        if (IsLigado())
        {
            Console.WriteLine($"Está ligado?: {IsLigado()}");
            Console.WriteLine($"Está Tocando?: {IsTocando()}");
            for(int i = 0; i <= GetVolume(); i += 10)
            {
                Console.WriteLine("|");
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("ERRO! Ligue a TV");
        }
    }

    public void Desligar()
    {
        SetLigado(false);
    }

    public void DesligarMudo()
    {
        if(IsLigado() && GetVolume() == 0)
        {
            SetVolume(20);
        }
    }

    public void FecharMenu()
    {
        Console.WriteLine("Fechando Menu...");
    }

    public void Ligar()
    {
        SetLigado(true);
    }

    public void LigarMudo()
    {
        if(IsLigado() && GetVolume() > 0)
        {
            SetVolume(0);
        }
    }

    public void MaisVolume()
    {
        if (IsLigado())
        {
            SetVolume(GetVolume() +  5);
        }
    }

    public void MenosVolume()
    {
        if (IsLigado())
        {
            SetVolume(GetVolume() - 5);
        }
    }

    public void Pause()
    {
        if(IsLigado() && IsTocando())
        {
            SetTocando(true);
        }
    }

    public void Play()
    {
        if(IsLigado() && !IsTocando())
        {
            SetTocando(true);
        }
    }
}
