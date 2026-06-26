using System;

namespace Aula09;

public interface Publicacao
{
    void Abrir();
    void Fechar();
    void Folhear(int p);
    void AvancarPag();
    void VoltarPag();
}
