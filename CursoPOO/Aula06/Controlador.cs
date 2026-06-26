using System;

namespace Aula06;

public interface Controlador
{
    void Ligar();
    void Desligar();
    void AbrirMenu();
    void FecharMenu();
    void MaisVolume();
    void MenosVolume();
    void LigarMudo();
    void DesligarMudo();
    void Play();
    void Pause();
}
