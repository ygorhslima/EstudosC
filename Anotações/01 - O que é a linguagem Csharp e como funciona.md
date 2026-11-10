C# (ou Csharp) é uma linguagem de programação moderna, orientada a objetos e de tipagem estática, criada pela Microsoft por volta do ano 2000, sob a liderança de Anders Hejlsberg. Ela foi projetada para rodar na plataforma .NET.

**Principais características**

- **Orientada a objetos**: usa classes, herança, interfaces e polimorfismo.
- **Tipagem forte e estática**: os erros de tipo são detectados em tempo de compilação.
- **Gerenciamento automático de memória**: um coletor de lixo (garbage collector) libera a memória que não está mais em uso.
- **Multiparadigma**: além de orientação a objetos, suporta programação funcional (lambdas, LINQ, pattern matching) e programação assíncrona com `async`/`await`.
- **Multiplataforma**: com o .NET moderno, roda em Windows, Linux e macOS.

**Para que é usada**

- Aplicações web e APIs (ASP.NET Core)
- Aplicativos desktop (WPF, Windows Forms, MAUI)
- Jogos, principalmente com a engine **Unity**
- Aplicativos móveis (.NET MAUI)
- Serviços em nuvem (Azure), microsserviços e automações


# Como ela funciona

O C# ela funciona em duas etapas: o código é compilado para uma linguagem intermediária e, na hora de executar, é traduzido para código de máquina. Isso é o que permite que o mesmo programa rode em sistemas diferentes.

**1. Você escreve o código C#**

Você escreve arquivos `.cs` com classes, métodos e assim por diante.

**2. O compilador gera código intermediário (IL)**

O compilador (Roslyn) não gera código de máquina direto. Ele produz o **IL** (_Intermediate Language_), um código intermediário que não depende de processador nem de sistema operacional. Esse IL é guardado em um **assembly**, que é um arquivo `.dll` ou `.exe`, junto com metadados sobre os tipos do programa.

**3. O runtime executa o programa (CLR)**

Quando você roda o programa, entra em ação o **CLR** (_Common Language Runtime_), o ambiente de execução do .NET. Ele funciona em forma de comparação com o JVM do Java, ele, assim como o JVM, também é uma máquina virtual, que cuida de:

- **Compilação JIT (Just-In-Time)**: converter o IL em código de máquina nativo no momento da execução, otimizado para o processador onde o programa está rodando. Cada método é compilado na primeira vez que é chamado.
- **Garbage collector**: libera automaticamente a memória de objetos que não são mais usados.
- **Segurança de tipos**: verifica acessos inválidos e lança exceções em vez de deixar o programa corromper a memória.
- **Tratamento de exceções e threads**: gerencia erros e execução paralela.

**Resumo do fluxo**

![[Pasted image 20261110155652.png]]

**A biblioteca de classes (BCL)**

Junto com o runtime vem a _Base Class Library_, um grande conjunto de classes prontas para trabalhar com arquivos, rede, coleções, datas, criptografia, entre outras coisas. Quando você usa `using System;`, está acessando essa biblioteca.

**Na prática**

Com o SDK do .NET instalado, você pode testar tudo isso no terminal:

```bash
dotnet new console -n MeuApp
cd MeuApp
dotnet run
```

O `dotnet run` compila o código para IL e já executa o programa usando o CLR.

Próximo estudo:
[[02 - Variáveis, constantes e tipos primitivos]]
