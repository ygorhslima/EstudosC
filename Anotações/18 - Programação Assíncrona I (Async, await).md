O **`async`** e o **`await`** no C# são palavras-chave usadas para implementar a **programação assíncrona** de forma simples e legível. Eles permitem que seu código execute operações demoradas (como consultas a banco de dados, requisições HTTP, leitura/escrita de arquivos) em segundo plano, **sem bloquear a thread principal** da aplicação.
### Como funciona na prática?

Quando você faz uma chamada síncrona para uma API ou banco de dados, a thread fica "congelada" esperando a resposta chegar. Com `async`/`await`:

1. **`async`**: Você marca um método com essa palavra para indicar que ele contém operações assíncronas e que ele próprio poderá usar o `await`.

2. **`await`**: Quando o código chega em uma operação demorada precedida por `await`, a execução daquele método é pausada e o controle é devolvido imediatamente para quem o chamou (por exemplo, liberando a interface gráfica para não travar, ou liberando uma thread do servidor web para atender outra requisição).

3. **Retomada**: Assim que a operação demorada termina, a execução do método continua de onde parou (geralmente em uma thread disponível).

### Exemplo de código

```cs
public async Task<string> ObterDadosDaWebAsync()
{
    HttpClient client = new HttpClient();
    
    // O 'await' aguarda o download terminar sem bloquear a thread
    string resultado = await client.GetStringAsync("https://api.exemplo.com/dados");
    
    return resultado;
}
```

### Principais Benefícios

- **Escalabilidade (em servidores):** Em aplicações web (como ASP.NET Core), o uso de assincronismo evita que threads fiquem ociosas esperando I/O, permitindo que o servidor suporte muito mais requisições simultâneas.
- **Responsividade (em aplicações desktop/mobile):** Impede que a tela "congele" ou pare de responder enquanto o usuário aguarda uma operação pesada.
- **Legibilidade:** Antigamente, código assíncrono exigia o uso complexo de callbacks e eventos (modelo APM ou EAP). O `async`/`await` faz o código parecer sequencial e síncrono, facilitando a leitura e a manutenção.


Estudo Anterior: [[17 - LINQ]]
Próximo Estudo: [[19 - Programação Assíncrona II (Thread, Task)]]
