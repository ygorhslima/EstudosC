No C#, **Thread** e **Task** são conceitos fundamentais para lidar com concorrência e paralelismo, mas operam em níveis de abstração completamente diferentes.
### 1. O que é uma Thread?

Uma **Thread** (fio de execução) é a menor unidade de processamento que o sistema operacional consegue gerenciar.

- **Baixo nível:** Ela representa diretamente uma thread física do sistema operacional.
- **Custo alto:** Criar, iniciar e destruir uma Thread consome bastante memória (cada uma aloca cerca de 1MB de pilha) e processamento do SO (troca de contexto).
- **Controle manual:** O desenvolvedor precisa gerenciar manualmente o ciclo de vida, a sincronização (usando travas como `lock`) para evitar condições de corrida, e o encerramento.
### 2. O que é uma Task?

Uma **Task** (representada pelas classes `Task` e `Task<T>`) foi introduzida no .NET para representar uma **unidade de trabalho assíncrona**, e não necessariamente uma thread exclusiva do sistema operacional.

- **Alto nível:** Ela abstrai a complexidade do gerenciamento de threads.
- **ThreadPool:** Por padrão, as Tasks utilizam o **Thread Pool** do .NET, um conjunto de threads pré-criadas e reutilizadas. Isso elimina o custo pesado de criar threads do zero o tempo todo.
- **Suporte a Retorno e Erros:** Diferente das threads tradicionais, uma `Task<T>` armazena facilmente o valor de retorno da operação e propaga exceções de forma limpa.
- **Integração com `async/await`:** É a fundação do modelo moderno de assincronismo no C#.
### Principais Diferenças

| **Característica**   | **Thread (System.Threading.Thread)**            | **Task (System.Threading.Tasks.Task)**          |
| -------------------- | ----------------------------------------------- | ----------------------------------------------- |
| **Nível**            | Baixo nível (ligada ao Sistema Operacional)     | Alto nível (gerenciada pelo ecossistema .NET)   |
| **Custo de criação** | Alto (pesada para o sistema)                    | Baixo (reutiliza threads do _Thread Pool_)      |
| **Retorno de dados** | Difícil de obter diretamente                    | Muito fácil (`Task<T>` traz o resultado)        |
| **Uso recomendado**  | Cenários raros e de computação ultra-específica | Padrão moderno para operações I/O e paralelismo |

Estudo Anterior: [[18 - Programação Assíncrona I (Async, await)]]