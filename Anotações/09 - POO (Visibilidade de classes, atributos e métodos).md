A **visibilidade** (ou modificadores de acesso) define o nível de segurança e controle sobre quem pode acessar, visualizar ou modificar uma classe, um atributo ou um método dentro de um sistema. Ela é o pilar prático do **encapsulamento**, garantindo que os dados internos de um objeto fiquem protegidos contra alterações acidentadas ou indevidas vindas de fora.

Os níveis de visibilidade mais comuns na programação orientada a objetos (especialmente em linguagens como C# e Java) são:  

- **`public` (Público):** O elemento é visível e acessível de **qualquer lugar** do sistema, seja dentro da própria classe, em subclasses ou em outros projetos e namespaces.

- **`private` (Privado):** O elemento é visível **apenas dentro da própria classe** onde foi declarado. Nenhuma outra classe (nem mesmo suas filhas) consegue enxergá-lo ou modificá-lo diretamente. É o nível máximo de proteção para os atributos de estado.

- **`protected` (Protegido):** O elemento é acessível dentro da própria classe e também em **subclasses** (classes que herdam dela). Permite compartilhar dados ou comportamentos com herdeiros sem expô-los para o restante do mundo externo.

- **`internal` (Interno — muito comum no C#):** O elemento é acessível em qualquer arquivo dentro do **mesmo projeto/assembly**, mas fica invisível para outros projetos externos.
### Como isso se aplica na prática?

- **Visibilidade de Classes:** Controla se a classe em si pode ser instanciada ou herdada por outros módulos do software.

- **Visibilidade de Atributos:** Geralmente mantida como `private` para impedir que dados cruciais de um objeto sejam corrompidos externamente. Para interagir com eles de forma segura, utilizam-se métodos públicos (`getters` e `setters` ou propriedades).

- **Visibilidade de Métodos:** Define quais ações o objeto expõe para o mundo exterior (`public`) e quais são apenas detalhes de funcionamento interno (`private`).

Estudo Anterior: [[08 - POO (Classe e Objeto)]]
Próximo Estudo: [[10 - POO (Métodos Getters e Setters)]]
