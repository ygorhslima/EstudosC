# **Lista de exercícios — Programação Orientada a Objetos com C#**

**Objetivo:** desenvolver a capacidade de construir sistemas utilizando lógica de programação, estruturas de dados e Programação Orientada a Objetos (POO) com C#.

Todos os exercícios seguirão o padrão do seu exemplo: um programa executável pelo terminal, com menu de opções, armazenamento de objetos e métodos responsáveis por cada operação.

## **Regras gerais para todos os exercícios**

- Todos devem ser desenvolvidos em C# usando Console Application.
- Todos devem possuir um menu principal com `do while` e `switch`.
- Cada funcionalidade deverá ser separada em métodos.
- Os dados deverão ser armazenados em arrays ou estruturas de dados, conforme o exercício.
- A criação de objetos deverá ser feita a partir de classes próprias.
- Não utilizar banco de dados neste primeiro momento.
- Não utilizar Windows Forms, interfaces gráficas ou aplicações web.
- Os dados poderão permanecer na memória enquanto o programa estiver executando.

# **Nível 1 — Fundamentos de POO**

EXERCÍCIOS 01 A 05 · DIFICULDADE FÁCIL

O objetivo desta etapa é aprender a transformar problemas em classes e objetos, utilizando métodos, atributos, arrays, condições e repetições.

## **Exercício 01 — Central de Controle de Drones**
**Contexto**

Uma empresa de entregas utiliza drones para transportar encomendas. Você deverá desenvolver um sistema para controlar os equipamentos disponíveis.

**Classe obrigatória:&#x20;**`Drone`

Atributos:

- Código de identificação.
- Modelo.
- Capacidade máxima de carga em kg.
- Nível de bateria.
- Status (Disponível, Em operação ou Em manutenção).
- Quantidade de entregas realizadas.

**Menu do sistema:**

```
========== CENTRAL DE DRONES ==========

[1] Cadastrar drone
[2] Listar drones
[3] Pesquisar drone por código
[4] Iniciar operação de entrega
[5] Recarregar bateria
[6] Enviar drone para manutenção
[7] Exibir drones com bateria baixa
[8] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Cadastrar até 10 drones.
2. Pesquisar um drone pelo código de identificação.
3. Não permitir iniciar uma entrega se a bateria estiver abaixo de 30%.
4. Não permitir iniciar uma operação com drone em manutenção.
5. Ao realizar uma entrega, diminuir 30% da bateria.
6. Aumentar o contador de entregas realizadas.
7. Listar os drones que possuem bateria inferior a 20%.

**Conceitos trabalhados:** classes, objetos, atributos, métodos, arrays de objetos, `if`, `switch`, `for`, `do while`.

## **Exercício 02 — Estação de Monitoramento Climático**
**Contexto**

Uma estação meteorológica possui diversos sensores espalhados pela região. O sistema deverá armazenar e analisar as medições realizadas.

**Classe obrigatória:&#x20;**`SensorClimatico`

Atributos:

- Código do sensor.
- Nome da região.
- Temperatura atual.
- Umidade do ar.
- Velocidade do vento.
- Status do sensor.

**Menu do sistema:**

```
======= MONITORAMENTO CLIMÁTICO =======

[1] Registrar sensor
[2] Listar sensores
[3] Registrar nova medição
[4] Pesquisar sensor por código
[5] Exibir temperaturas acima de 35°C
[6] Exibir regiões com baixa umidade
[7] Identificar maior temperatura registrada
[8] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Permitir cadastrar até 15 sensores.
2. Registrar novas medições para cada sensor.
3. Identificar regiões com temperatura superior a 35°C.
4. Identificar regiões com umidade inferior a 30%.
5. Encontrar o sensor com a maior temperatura.
6. Calcular a média de temperatura de todos os sensores ativos.
7. Impedir medições em sensores desativados.

**Conceitos trabalhados:** classes, objetos, arrays, métodos com retorno, parâmetros, acumuladores, contadores e condições.

## **Exercício 03 — Gerenciador de Expedições Arqueológicas**

[What is Archaeology? | AMNH](https://images.openai.com/static-rsc-4/y0Q7vs9aA53P9_ot0icp6NzHzV0tsAblkAWXWUW10RyqbBW-DYgflTck753zCWIs1NTnYvBeIZwSB7ihfzm9bIs5M9EHVaE_uDNzDCSqsFUj6c72CwKlIjRsInC_nOfH4p_5s6ZAYzGa6zQbStpgCP14iNoBi1R4kf-RWIjWtSE?purpose=inline)

**Contexto**

Uma equipe de arqueólogos realiza expedições para encontrar artefatos históricos. Você deverá desenvolver um sistema para controlar os objetos encontrados.

**Classe obrigatória:&#x20;**`Artefato`

Atributos:

- Código do artefato.
- Nome.
- Local onde foi encontrado.
- Ano estimado de origem.
- Categoria.
- Nível de importância histórica (1 a 5).

**Menu do sistema:**

```
======= EXPEDIÇÕES ARQUEOLÓGICAS =======

[1] Registrar artefato
[2] Listar artefatos
[3] Pesquisar por código
[4] Pesquisar por categoria
[5] Exibir artefatos mais antigos
[6] Ordenar por importância histórica
[7] Exibir artefatos de um local
[8] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Armazenar até 20 artefatos.
2. Pesquisar artefatos por código.
3. Permitir pesquisa por categoria.
4. Identificar o artefato de origem mais antiga.
5. Ordenar os artefatos por importância histórica.
6. Filtrar os artefatos encontrados em determinada região.
7. Não permitir códigos duplicados.

**Conceitos trabalhados:** classes, objetos, arrays, pesquisa, ordenação, strings e métodos.

## **Exercício 04 — Central de Gerenciamento de Energia**

[𝐋𝐚 𝐢𝐧𝐠𝐞𝐧𝐢𝐞𝐫𝛊́𝐚 𝐞𝐧𝐞𝐫𝐠𝐞́𝐭𝐢𝐜𝐚 𝐧𝐮𝐧𝐜𝐚 𝐡𝐚 𝐬𝐢𝐝𝐨 𝐞𝐬𝐭𝐚́𝐭𝐢𝐜𝐚.   Pero lo que está pasando ahora… es otra liga.  Durante décadas, el valor de un ingeniero estaba claro:… | Jim Novack](https://images.openai.com/static-rsc-4/p6l1FRqiKTSwTOWdT6_qYJAc3VE0n4DTBYW8kNkn1WPUhh-zp9tn0Y6LbSL5q-w4Oo5_v1AP_8-cV8I6uxQAYf9C2LYt-d9xrRk3MBH67QDgQcvr0_vMOmLKAIXcbUenUZaMW9HUtwuKlaoas8LGc56waR4w5tnKcOHKO-hpo18?purpose=inline)

**Contexto**

Uma cidade utiliza diferentes fontes de energia para abastecer seus bairros. O sistema deverá monitorar a produção e o consumo energético.

**Classe obrigatória:&#x20;**`UnidadeEnergetica`

Atributos:

- Código.
- Nome da unidade.
- Tipo de energia.
- Capacidade máxima de produção.
- Produção atual.
- Consumo atual.

**Menu do sistema:**

```
======= CENTRAL DE ENERGIA =======

[1] Cadastrar unidade energética
[2] Listar unidades
[3] Atualizar produção
[4] Atualizar consumo
[5] Consultar saldo energético
[6] Identificar unidades sobrecarregadas
[7] Exibir maior produtora de energia
[8] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Cadastrar até 10 unidades.
2. Atualizar a produção energética.
3. Atualizar o consumo energético.
4. Calcular o saldo de energia de cada unidade.
5. Identificar unidades cujo consumo supera a produção.
6. Identificar unidades que ultrapassaram 90% da capacidade.
7. Encontrar a unidade com maior produção.

**Conceitos trabalhados:** classes, objetos, métodos, cálculos, validações, arrays e estruturas condicionais.

## **Exercício 05 — Sistema de Gerenciamento de Criaturas Fantásticas**

[What's your favorite mythological creature? - GirlsAskGuys](https://images.openai.com/static-rsc-4/rofCzOzMsQOnZqCCsOL8ZKo1h-tEfNSNI1WaPLWq2Y0Mchhjncoo3jqBJMo98qYaH8paAU8-MYkyz0Tu9ZebEJOGENXxbr3A59yFe-HhzcUS0loA0Jeasn31wrWoVXiNb4x_zoHQ4JlZz0Hfro0TVkBHDmAn-oYOEcoeo2BFya8?purpose=inline)

**Contexto**

Um centro de pesquisas fantásticas está catalogando criaturas encontradas em diferentes dimensões. Você deverá desenvolver um sistema para controlar essas criaturas.

**Classe obrigatória:&#x20;**`Criatura`

Atributos:

- Código.
- Nome.
- Espécie.
- Nível de poder.
- Idade.
- Habitat.
- Estado de saúde.

**Menu do sistema:**

```
======= ENCICLOPÉDIA FANTÁSTICA =======

[1] Cadastrar criatura
[2] Listar criaturas
[3] Pesquisar criatura
[4] Atualizar estado de saúde
[5] Alimentar criatura
[6] Exibir criaturas por habitat
[7] Ordenar por nível de poder
[8] Excluir criatura
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Cadastrar até 20 criaturas.
2. Pesquisar por código.
3. Atualizar o estado de saúde.
4. Implementar alimentação, aumentando o nível de energia da criatura.
5. Listar criaturas por habitat.
6. Ordenar por nível de poder.
7. Permitir excluir criaturas cadastradas.
8. Não permitir alimentar criaturas que estejam em estado crítico.

**Conceitos trabalhados:** classes, objetos, construtores, encapsulamento inicial, arrays, métodos e ordenação.

# **Nível 2 — POO intermediária**

EXERCÍCIOS 06 A 10 · DIFICULDADE MÉDIA

Nesta etapa, os exercícios começam a exigir mais organização. Você deverá trabalhar com encapsulamento, construtores, herança, polimorfismo, classes abstratas e interfaces.

## **Exercício 06 — Gerenciador de Equipamentos de Exploração**

[ISPEC PORT IR Portable Fourier Transform Infrared (FTIR) Chemical Identifier - InstrumentHive](https://images.openai.com/static-rsc-4/SCwpgQcro7rTWbm2BklU13M-P80JOgNQLnKuDZghx_Zi6pld2Cg6lJoM-KMWR-VYnm6OpPX5HXxf-iBHrMjh0i98IIJ5FOEfwg_n81gB6K-tnFOg85G0Fw1d9C4_7h90EhSH4cbGdmpGcHBj3R-XmoxW9oxgDxXkxKonT8Tf_F0?purpose=inline)

**Contexto**

Uma organização científica possui diversos equipamentos utilizados em missões de exploração. Cada equipamento possui características e regras próprias de utilização.

**Classes obrigatórias:**

- `Equipamento` (classe base).
- `EquipamentoTerrestre`.
- `EquipamentoAquatico`.
- `EquipamentoAereo`.

**Atributos da classe&#x20;**`Equipamento`**:**

- Código.
- Nome.
- Fabricante.
- Estado de conservação.
- Disponibilidade.

**Atributos específicos:**

- `EquipamentoTerrestre`: tipo de terreno e autonomia.
- `EquipamentoAquatico`: profundidade máxima e resistência à pressão.
- `EquipamentoAereo`: altitude máxima e autonomia de voo.

**Menu do sistema:**

```
======= EQUIPAMENTOS DE EXPLORAÇÃO =======

[1] Cadastrar equipamento terrestre
[2] Cadastrar equipamento aquático
[3] Cadastrar equipamento aéreo
[4] Listar todos os equipamentos
[5] Pesquisar equipamento
[6] Liberar equipamento para missão
[7] Devolver equipamento
[8] Exibir equipamentos indisponíveis
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Criar uma classe base `Equipamento`.
2. Utilizar herança para criar os três tipos de equipamentos.
3. Utilizar construtores para inicializar os atributos.
4. Proteger os atributos utilizando encapsulamento.
5. Não permitir liberar um equipamento que já esteja em missão.
6. Criar um método `ExibirDetalhes()` nas classes.
7. Sobrescrever esse método para apresentar informações específicas de cada equipamento.

**Conceitos trabalhados:** herança, encapsulamento, construtores, `virtual`, `override` e polimorfismo.

## **Exercício 07 — Plataforma de Competições de Robôs**

[Icom IC-705_audio configuration with AI assistance](https://images.openai.com/static-rsc-4/b1YTVgniiwStXdHn4A4-XHXBJ0xgsx8Dh_nskKX8VhGxFaYJrTTp0rDxkYitOskdiQj5jq3ry3Ngk-TaMry1pqpHLUuPraIqUA_RO42kc_eg69KHSwamMo9nMbhgZYM8s0bK5xLKEUfZX6TY-AxOE1l327FbVjhNq3WvNNEdY28?purpose=inline)

**Contexto**

Uma organização promove campeonatos de robôs com diferentes especialidades. Cada robô possui atributos próprios e uma forma diferente de competir.

**Classes obrigatórias:**

- `Robo` (classe abstrata).
- `RoboCombate`.
- `RoboCorrida`.
- `RoboResgate`.

**Atributos da classe&#x20;**`Robo`**:**

- Identificação.
- Nome.
- Fabricante.
- Energia.
- Pontuação.

**Atributos específicos:**

- `RoboCombate`: força e resistência.
- `RoboCorrida`: velocidade máxima.
- `RoboResgate`: capacidade de carga e alcance de operação.

**Menu do sistema:**

```
======= CAMPEONATO DE ROBÔS =======

[1] Cadastrar robô de combate
[2] Cadastrar robô de corrida
[3] Cadastrar robô de resgate
[4] Listar competidores
[5] Executar competição
[6] Recuperar energia dos robôs
[7] Exibir classificação
[8] Pesquisar robô
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. A classe `Robo` deverá ser abstrata.
2. Criar um método abstrato `Competir()`.
3. Cada tipo de robô deverá implementar sua própria competição.
4. O método deverá retornar a pontuação obtida.
5. Cada competição deverá consumir energia.
6. Não permitir competição com energia insuficiente.
7. Exibir a classificação dos robôs em ordem decrescente de pontuação.
8. Utilizar uma coleção de referências do tipo `Robo` para armazenar os diferentes tipos de robôs.

**Conceitos trabalhados:** abstração, herança, polimorfismo, métodos abstratos, sobrescrita e `List<T>`.

## **Exercício 08 — Sistema de Contratação de Serviços Digitais**

[Workar | Intelligent Freelance Marketplace | Hire Remote Freelancers in Budget](https://images.openai.com/static-rsc-4/2ZWnDRfUzqzhhDsf4qspNwbEnb66U_xeM6Wt3544e5KYgFIaH5E0HUjewae3fZC38QsE5tfcXveCzd-7r0W-dSxdTUgbWR7pfYDFlJfJ6wGxu8kgF6XKuz5nK8_x6q507lD9C_cPvT7vupVv4YH8zIg4rHtlSwxmP1KpmTIvsLg?purpose=inline)

**Contexto**

Uma plataforma oferece serviços digitais de diferentes profissionais. Cada profissional possui uma especialidade, um valor de serviço e uma forma própria de calcular o preço final.

**Classes obrigatórias:**

- `Servico` (classe abstrata).
- `ServicoDesign`.
- `ServicoProgramacao`.
- `ServicoConsultoria`.

**Atributos da classe&#x20;**`Servico`**:**

- Código.
- Nome do profissional.
- Descrição.
- Valor base.
- Prazo de entrega.

**Regras específicas:**

- `ServicoDesign`: cobrar um adicional conforme a quantidade de telas produzidas.
- `ServicoProgramacao`: cobrar conforme a quantidade de horas de desenvolvimento.
- `ServicoConsultoria`: cobrar conforme a quantidade de sessões.

**Menu do sistema:**

```
======= PLATAFORMA DE SERVIÇOS =======

[1] Cadastrar serviço de design
[2] Cadastrar serviço de programação
[3] Cadastrar serviço de consultoria
[4] Listar serviços
[5] Calcular preço de um serviço
[6] Pesquisar serviço por código
[7] Exibir serviços por prazo
[8] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Criar uma classe abstrata `Servico`.
2. Implementar o método abstrato `CalcularPreco()`.
3. Cada serviço deverá possuir sua própria regra de cálculo.
4. Utilizar encapsulamento para impedir valores negativos.
5. Armazenar todos os serviços em uma única lista.
6. Exibir o valor calculado de cada serviço.
7. Ordenar os serviços pelo prazo de entrega.

**Conceitos trabalhados:** abstração, polimorfismo, herança, encapsulamento, métodos abstratos e listas.

## **Exercício 09 — Sistema de Controle de Missões Científicas**

[Space Voyage Planning: Tools, Tactics, and Next Missions](https://images.openai.com/static-rsc-4/U0uTXvNv4s5xEknfYcrjiojwAJ4ZcYxiEq3-KPWiFNaQKKmkqFG4jc86Hn5MQMf429rJCPpc4MQ7R9wviwSlTsOPIV0rUNukevl3v-xXf9ceJGCfSQNIKz3k2tdvawk93xVz1HFbc2qEHA6DRkvjNWkbSP0QRMWZjzLxef9Ix1A?purpose=inline)

**Contexto**

Uma agência científica organiza missões de pesquisa em diferentes ambientes. Para realizar uma missão, é necessário selecionar pesquisadores com habilidades específicas.

**Classes obrigatórias:**

- `Pesquisador`.
- `Missao`.
- `Especialidade` (enum).

**Atributos da classe&#x20;**`Pesquisador`**:**

- Matrícula.
- Nome.
- Especialidade.
- Nível de experiência.
- Disponibilidade.

**Atributos da classe&#x20;**`Missao`**:**

- Código.
- Nome.
- Local de exploração.
- Nível de dificuldade.
- Lista de pesquisadores participantes.
- Status da missão.

**Menu do sistema:**

```
======= CENTRAL DE MISSÕES =======

[1] Cadastrar pesquisador
[2] Criar missão
[3] Listar pesquisadores
[4] Listar missões
[5] Adicionar pesquisador à missão
[6] Remover pesquisador da missão
[7] Iniciar missão
[8] Finalizar missão
[9] Consultar equipe de uma missão
[10] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Cada missão deverá possuir sua própria lista de pesquisadores.
2. Um pesquisador não poderá participar de duas missões simultaneamente.
3. Cada missão deverá exigir uma quantidade mínima de participantes.
4. Uma missão somente poderá começar se possuir pesquisadores disponíveis.
5. Pesquisadores deverão ter especialidades específicas.
6. Utilizar `enum` para representar especialidades e status.
7. Criar métodos para adicionar e remover pesquisadores de uma missão.

**Conceitos trabalhados:** classes, objetos, encapsulamento, enum, `List<T>`, associação e composição de comportamentos.

## **Exercício 10 — Central de Distribuição de Recursos**

[Is Amazon Export Not Profitable? How to Maximize Marginal Profit Through Cost Structure Analysis and FBA Tips](https://images.openai.com/static-rsc-4/7z03q5vT79eNM5M88DHfsbNrpr4LE1hb0IpGa10hGl4Prj9cAqgk8hJx5aT6V9zvaMZUp07FJn0qePxr5naRLl5c1stwgVsGdjVxxCkRKmfW1Aahruo1r0YC89RNKu_LutqM_BmMmLqBjpDN7EcGzmBxNgZ2CJfbuUOI5yFEKM8?purpose=inline)

**Contexto**

Uma central de distribuição recebe solicitações de diferentes regiões. Os recursos devem ser organizados e enviados de acordo com a ordem de chegada e a prioridade.

**Classes obrigatórias:**

- `Recurso`.
- `Solicitacao`.
- `CentralDistribuicao`.

**Atributos da classe&#x20;**`Recurso`**:**

- Código.
- Nome.
- Quantidade disponível.
- Categoria.

**Atributos da classe&#x20;**`Solicitacao`**:**

- Código.
- Região solicitante.
- Recurso solicitado.
- Quantidade solicitada.
- Prioridade.

**Menu do sistema:**

```
======= CENTRAL DE DISTRIBUIÇÃO =======

[1] Cadastrar recurso
[2] Registrar solicitação
[3] Listar recursos
[4] Listar solicitações
[5] Processar próxima solicitação
[6] Consultar estoque
[7] Exibir solicitações pendentes
[8] Cancelar solicitação
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Utilizar uma fila (`Queue<Solicitacao>`) para armazenar solicitações.
2. Processar as solicitações respeitando a ordem de chegada.
3. Não permitir atender solicitações sem estoque suficiente.
4. Atualizar automaticamente o estoque após uma distribuição.
5. Permitir cancelar solicitações que ainda não foram processadas.
6. Criar uma classe responsável pelo gerenciamento da distribuição.
7. Exibir o histórico de solicitações atendidas.

**Conceitos trabalhados:** associação entre classes, encapsulamento, composição, filas, coleções e organização de responsabilidades.

# **Nível 3 — POO avançada e integração de conceitos**

EXERCÍCIOS 11 A 15 · DIFICULDADE DIFÍCIL

Agora os exercícios serão mais completos. Você precisará trabalhar com várias classes interagindo entre si, interfaces, relacionamentos, estruturas de dados e regras de negócio.

## **Exercício 11 — Sistema de Gerenciamento de Inteligências Artificiais**

[Best AI Design Tools: Insights & Tips From 50+ Tools](https://images.openai.com/static-rsc-4/iXOzP8XN-JxlfgM03UfBOmGgfCEor5Xb44il5oRMRQUqcdPxWYE-q868hvSmtKnr0VUtoZ7_ayso-BDLcGXMICvPYd5DSy9HV6CZEOr2SemH-Mxfb4fLuP7pta0mRp1uatQmGVWW4Gvt6tWhyTwMHqWwvYAGIXArFHzbI32R67k?purpose=inline)

**Contexto**

Uma empresa desenvolve diferentes inteligências artificiais para executar tarefas específicas. Algumas analisam dados, outras identificam imagens e outras automatizam processos.

**Classes e interfaces obrigatórias:**

- `InteligenciaArtificial` (classe abstrata).
- `IAAnalitica`.
- `IAVisual`.
- `IAAutomacao`.
- `IExecutavel` (interface).

**Atributos da classe&#x20;**`InteligenciaArtificial`**:**

- Código.
- Nome.
- Versão.
- Consumo de processamento.
- Status de funcionamento.

**Comportamentos específicos:**

- `IAAnalitica`: analisar conjuntos de dados.
- `IAVisual`: identificar elementos em imagens.
- `IAAutomacao`: executar tarefas automatizadas.
- `IExecutavel`: definir um contrato para iniciar e interromper a execução.

**Menu do sistema:**

```
======= GERENCIADOR DE IA =======

[1] Cadastrar IA analítica
[2] Cadastrar IA visual
[3] Cadastrar IA de automação
[4] Listar inteligências artificiais
[5] Executar inteligência artificial
[6] Interromper execução
[7] Consultar consumo de processamento
[8] Exibir IAs em funcionamento
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Criar uma classe abstrata para representar as inteligências artificiais.
2. Utilizar uma interface `IExecutavel`.
3. Cada IA deverá implementar seu próprio comportamento.
4. Impedir a execução de uma IA que esteja desligada ou indisponível.
5. Controlar o consumo de processamento.
6. Não permitir ultrapassar o limite de processamento da empresa.
7. Armazenar diferentes tipos de IA em uma única coleção.
8. Utilizar polimorfismo para executar os diferentes comportamentos.

**Conceitos trabalhados:** interfaces, abstração, herança, polimorfismo, encapsulamento e gerenciamento de objetos.

## **Exercício 12 — Sistema de Investigação de Incidentes Digitais**

[Training on Introduction to Computer Forensics and Digital Investigation - ForElite Training Institute](https://images.openai.com/static-rsc-4/saLBp9DzuaVgiwl_0ARwtDx4hwUZnjuyyxie-Fy2HZG1s0As6iLAglnlV6N16O1cUZSimECVFErhAlbbUdLBN9KWrpaVspm4BFVoOBNtqcIEr3fRHXlJCrc4SkjcTEoO52W4Kl1Erv55o3g-iz3sBttmo9xOVk4kezB6xc7Lqrg?purpose=inline)

**Contexto**

Uma equipe de segurança digital investiga incidentes registrados em uma rede. Cada investigação possui evidências que precisam ser armazenadas, analisadas e organizadas.

**Classes obrigatórias:**

- `Investigacao`.
- `Evidencia`.
- `Analista`.
- `Relatorio`.

**Atributos da classe&#x20;**`Evidencia`**:**

- Código.
- Descrição.
- Tipo de evidência.
- Nível de relevância.
- Data de coleta.
- Estado da análise.

**Menu do sistema:**

```
======= INVESTIGAÇÃO DIGITAL =======

[1] Criar investigação
[2] Cadastrar evidência
[3] Listar investigações
[4] Adicionar evidência à investigação
[5] Analisar próxima evidência
[6] Consultar evidências pendentes
[7] Gerar relatório
[8] Consultar histórico de análises
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Cada investigação deverá possuir uma coleção de evidências.
2. Utilizar uma pilha (`Stack<Evidencia>`) para registrar evidências que aguardam análise, considerando a última evidência recebida como a próxima a ser analisada.
3. Criar um histórico das evidências analisadas.
4. Permitir que analistas sejam associados às investigações.
5. Impedir que uma evidência seja analisada duas vezes.
6. Criar um método para gerar relatórios com a quantidade de evidências analisadas e pendentes.
7. Utilizar tratamento de exceções para entradas inválidas.

**Conceitos trabalhados:** composição, associação, pilhas, histórico, encapsulamento, métodos e tratamento de exceções.

## **Exercício 13 — Plataforma de Gerenciamento de Eventos Imersivos**

[Shaping The Future](https://images.openai.com/static-rsc-4/hTLfhvkONZZEAkqPk9AiD_ZD5nYMzW80oKeNbAU1GNrdC-ZYQ6YyYqUFtJnikKK_NjTBZU4YgH74Uuhqg4AZZ45JKlh5F-sAK5fyewKVfXvA7P7MIfxehI0e8GEeovU80-Nzpw_Wh-P4vixaB3zHKUS4IiVR-XsaTfOv3J24XZM?purpose=inline)

**Contexto**

Uma plataforma organiza eventos em ambientes virtuais. Existem diferentes tipos de eventos, participantes, inscrições e limites de capacidade.

**Classes e interfaces obrigatórias:**

- `Evento` (classe abstrata).
- `EventoPalestra`.
- `EventoCompeticao`.
- `EventoExposicao`.
- `Participante`.
- `IInscricao`.

**Atributos da classe&#x20;**`Evento`**:**

- Código.
- Nome.
- Data.
- Capacidade máxima.
- Lista de participantes.
- Status.

**Regras específicas:**

- `EventoPalestra`: possuir duração e palestrante.
- `EventoCompeticao`: possuir modalidade e premiação.
- `EventoExposicao`: possuir quantidade de obras ou apresentações.

**Menu do sistema:**

```
======= EVENTOS IMERSIVOS =======

[1] Cadastrar evento
[2] Cadastrar participante
[3] Inscrever participante
[4] Cancelar inscrição
[5] Listar eventos
[6] Listar participantes de um evento
[7] Exibir eventos lotados
[8] Calcular ocupação dos eventos
[9] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Criar uma classe abstrata `Evento`.
2. Utilizar herança para os diferentes tipos de eventos.
3. Criar uma interface `IInscricao`.
4. Cada evento deverá possuir sua própria lista de participantes.
5. Não permitir inscrições acima da capacidade máxima.
6. Impedir inscrições duplicadas no mesmo evento.
7. Permitir que um participante esteja inscrito em vários eventos.
8. Calcular a porcentagem de ocupação de cada evento.
9. Ordenar eventos pela quantidade de participantes.

**Conceitos trabalhados:** abstração, herança, interfaces, polimorfismo, composição, associação e listas.

## **Exercício 14 — Sistema de Administração de Colônias Subterrâneas**

[억만장자들의 ‘지하 낙원' 인류 종말 대비한 새로운 생존 비즈니스 - 브랜드경제신문](https://images.openai.com/static-rsc-4/oP57hrvBO66afLU46w_WVQTOKeXyXMbf4uNN1FyEHCDFwEaadzd7dAN52j0gm81q1ctuo5HAlGBHiFo9ITaaMdwIQL_GYzc4zOVgv83jwBwj2la3qS_sY2PqBFbCWlxjbJoxrxSd1wKfuIRRmngf66yBYC99gB1jKqeHX-O-0XY?purpose=inline)

**Contexto**

Após uma catástrofe ambiental, diferentes colônias foram construídas no subsolo. Cada colônia precisa administrar moradores, setores, recursos e infraestrutura para sobreviver.

**Classes e interfaces obrigatórias:**

- `Colonia`.
- `Morador`.
- `Setor`.
- `Recurso`.
- `Construcao`.
- `IManutencao`.

**Atributos da classe&#x20;**`Colonia`**:**

- Código.
- Nome.
- Capacidade populacional.
- Lista de moradores.
- Lista de setores.
- Estoque de recursos.

**Atributos da classe&#x20;**`Morador`**:**

- Identificação.
- Nome.
- Idade.
- Profissão.
- Nível de saúde.

**Menu do sistema:**

```
======= ADMINISTRAÇÃO DE COLÔNIAS =======

[1] Criar colônia
[2] Cadastrar morador
[3] Criar setor
[4] Distribuir moradores
[5] Cadastrar recurso
[6] Consumir recurso
[7] Construir infraestrutura
[8] Realizar manutenção
[9] Exibir situação da colônia
[10] Gerar relatório de sobrevivência
[11] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Uma colônia deverá possuir vários setores.
2. Cada setor deverá possuir moradores associados.
3. O estoque de recursos deverá ser administrado pela própria colônia.
4. Não permitir cadastrar moradores acima da capacidade populacional.
5. Permitir consumir recursos de acordo com a necessidade dos setores.
6. Implementar a interface `IManutencao` para construções que necessitam de manutenção.
7. Impedir a construção de infraestrutura quando não houver recursos suficientes.
8. Criar um indicador de sobrevivência baseado em recursos, população e condições da infraestrutura.
9. Gerar relatórios com a situação geral da colônia.

**Conceitos trabalhados:** composição, agregação, associação, interfaces, encapsulamento, listas, cálculos e regras de negócio.

## **Exercício 15 — Plataforma de Gerenciamento de Operações Interplanetárias**

[Futuristic space command center illustration | Free Photo Illustration - rawpixel](https://images.openai.com/static-rsc-4/ac3yyFuXogMe5N7b66XUw-X9icqEr7D1Nop2lAfmbL67lj3oMY-nkp6vPAnXwJcOn-8mM7XiP0-riCPqKrHK87_metqXtwDSP6ib9SjV4YLBX7_i64R9A8y1S6EB75WcHC1IdDIEvTX4qLCTYEsfIjSL7Ab2oXeecE2GyDTT2Yw?purpose=inline)

**Contexto**

Uma organização interplanetária administra diferentes planetas, naves, tripulações e missões espaciais. O sistema deverá controlar toda a operação e garantir que as missões sejam executadas corretamente.

Projeto final

**Classes e interfaces obrigatórias:**

- `Planeta`.
- `Nave` (classe abstrata).
- `NaveExploracao`.
- `NaveTransporte`.
- `NaveCombate`.
- `Tripulante`.
- `Missao`.
- `Recurso`.
- `IOperacional`.

**Atributos da classe&#x20;**`Planeta`**:**

- Código.
- Nome.
- Tipo de ambiente.
- Quantidade de recursos disponíveis.
- Nível de habitabilidade.

**Atributos da classe&#x20;**`Nave`**:**

- Código.
- Nome.
- Capacidade.
- Combustível.
- Integridade.
- Lista de tripulantes.

**Regras específicas das naves:**

- `NaveExploracao`: realiza pesquisas e mapeamentos.
- `NaveTransporte`: transporta recursos e tripulantes.
- `NaveCombate`: realiza operações de defesa.

**Menu do sistema:**

```
======= OPERAÇÕES INTERPLANETÁRIAS =======

[1] Cadastrar planeta
[2] Cadastrar nave
[3] Cadastrar tripulante
[4] Cadastrar missão
[5] Adicionar tripulante à nave
[6] Adicionar nave à missão
[7] Executar missão
[8] Consultar situação das naves
[9] Consultar recursos dos planetas
[10] Exibir histórico de missões
[11] Exibir relatório geral
[12] Sair

Escolha uma opção:
```

**Requisitos obrigatórios:**

1. Criar uma classe abstrata `Nave`.
2. Criar três tipos de naves utilizando herança.
3. Implementar a interface `IOperacional`.
4. Cada tipo de nave deverá executar uma operação específica.
5. Cada nave deverá possuir uma lista de tripulantes.
6. Cada missão deverá possuir um planeta de destino e uma ou mais naves.
7. Não permitir iniciar uma missão sem combustível suficiente.
8. Não permitir tripulantes indisponíveis em uma missão.
9. Controlar o consumo de recursos durante as missões.
10. Registrar o histórico de todas as missões executadas.
11. Implementar tratamento de exceções.
12. Criar relatórios estatísticos sobre as operações realizadas.
13. Ordenar naves por integridade e missões por data.
14. Utilizar diferentes estruturas de dados conforme a necessidade.

**Conceitos trabalhados:** praticamente todos os conceitos estudados anteriormente, integrados em um único sistema.

## **Resumo da progressão dos conteúdos**

Para facilitar seu acompanhamento, esta é a distribuição dos principais conceitos:

| Exercício | Principal aprendizado            |
| --------- | -------------------------------- |
| 01        | Classes, objetos e arrays        |
| 02        | Métodos, parâmetros e retornos   |
| 03        | Pesquisa e ordenação             |
| 04        | Condições e cálculos             |
| 05        | Construtores e encapsulamento    |
| 06        | Herança e sobrescrita            |
| 07        | Abstração e polimorfismo         |
| 08        | Polimorfismo e regras de negócio |
| 09        | Enum e associação                |
| 10        | Filas e gerenciamento            |
| 11        | Interfaces e abstração           |
| 12        | Pilhas e exceções                |
| 13        | Interfaces e relacionamentos     |
| 14        | Composição e agregação           |
| 15        | Integração de todos os conceitos |

## **Minha recomendação de estudo**

Não tente resolver todos de uma vez. Siga esta ordem:

1. Resolva os exercícios de 1 a 5 sem consultar soluções.
2. Nos exercícios de 6 a 10, concentre-se em entender como as classes se relacionam.
3. Nos exercícios de 11 a 15, procure construir sistemas mais organizados, separando as responsabilidades de cada classe.