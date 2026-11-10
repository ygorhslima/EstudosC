Os operadores no C# são símbolos que instruem o compilador a realizar operações matemáticas, relacionais ou lógicas específicas.
## 1. Operadores Aritméticos

Utilizados para realizar cálculos matemáticos.

| **Operador** | **Nome**              | **Exemplo**              | **Descrição**                                                                           |
| ------------ | --------------------- | ------------------------ | --------------------------------------------------------------------------------------- |
| `+`          | Adição / Concatenação | `int r = 10 + 5;`        | Soma dois valores numéricos ou junta textos (_strings_).                                |
| `-`          | Subtração             | `int r = 10 - 5;`        | Subtrai o operador direito do esquerdo.                                                 |
| `*`          | Multiplicação         | `int r = 10 * 5;`        | Multiplica dois valores.                                                                |
| `/`          | Divisão               | `double r = 10.0 / 4.0;` | Divide o operador esquerdo pelo direito. _(Divisão de inteiros ignora casas decimais)_. |
| `%`          | Módulo (Resto)        | `int r = 10 % 3;`        | Retorna o resto da divisão inteira ($10 \div 3 = 3$ com resto $1$).                     |
| `++`         | Incremento            | `x++;` ou `++x;`         | Adiciona $1$ à variável.                                                                |
| `--`         | Decremento            | `x--;` ou `--x;`         | Subtrai $1$ da variável.                                                                |

## 2. Operadores Relacionais (Comparação)

Comparam dois valores e sempre retornam um resultado booleano (`true` ou `false`).

| **Operador** | **Nome**         | **Exemplo** | **Resultado do Exemplo** |
| ------------ | ---------------- | ----------- | ------------------------ |
| `==`         | Igual a          | `5 == 5`    | `true`                   |
| `!=`         | Diferente de     | `5 != 3`    | `true`                   |
| `>`          | Maior que        | `5 > 10`    | `false`                  |
| `<`          | Menor que        | `3 < 8`     | `true`                   |
| `>=`         | Maior ou igual a | `5 >= 5`    | `true`                   |
| `<=`         | Menor ou igual a | `4 <= 2`    | `false`                  |

## 3. Operadores Lógicos

Utilizados para combinar ou inverter expressões booleanas.

| **Operador** | **Nome**         | **Exemplo**          | **Descrição**                                                                          |
| ------------ | ---------------- | -------------------- | -------------------------------------------------------------------------------------- |
| `&&`         | E lógico (_AND_) | `(x > 0) && (y > 0)` | Retorna `true` apenas se **todas** as condições forem verdadeiras. Usa curto-circuito. |
| `\|`         | OU lógico (_OR_) | `(x > 0) \| (y > 0)` | Retorna `true` se **pelo menos uma** das condições for verdadeira. Usa curto-circuito. |
| `!`          | Negação (_NOT_)  | `!(x > 0)`           | Inverte o resultado lógico (transfoma `true` em `false` e vice-versa).                 |

## Observações Adicionais

- **Curto-circuito (**_**Short-circuiting**_**):** Para `&&`, se o primeiro termo for `false`, o segundo nem é avaliado. Para `||`, se o primeiro termo for `true`, o segundo não é avaliado.

- **Precedência:** Operadores aritméticos possuem precedência sobre os relacionais, e estes possuem precedência sobre os lógicos. Use parênteses `()` para forçar a ordem de avaliação desejada.


Estudo Anterior: [[02 - Variáveis, constantes e tipos primitivos]]
Próximo estudo: [[04 - Condições]]
