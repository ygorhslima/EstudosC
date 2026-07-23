/*
Exercício: Sistema de Gestão de Funcionários (Herança)
O Cenário
Uma empresa possui dois tipos de funcionários: Designers e Gerentes.

Todo funcionário possui Matricula, Nome e SalarioBase.

O Gerente possui um atributo extra chamado Bonus. O salário total dele é o SalarioBase + Bonus.

O Designer possui um atributo extra chamado FerramentaPrincipal (ex: Photoshop, Figma). O salário dele é apenas o SalarioBase.

Estrutura das Classes que você deve criar:
Funcionario (Classe Base): Contém os dados comuns e um método CalcularSalario().

Gerente (Classe Derivada): Herda de Funcionario, adiciona a propriedade Bonus e faz o override (sobrescrita) do método CalcularSalario().

Designer (Classe Derivada): Herda de Funcionario e adiciona a propriedade FerramentaPrincipal.

FuncoesMenuFuncionarios: A classe que vai conter a lista única de funcionários (List<Funcionario>) e os métodos do menu.

O Desafio do Código (Sua base para treinar)
Siga o modelo abaixo para estruturar o seu Program.cs. Note que a lista agora aceita o tipo genérico da classe mãe (Funcionario), o que permite que você guarde tanto Gerentes quanto Designers dentro dela (Polimorfismo).
*/
using Ex05GestaoFuncionarios;
public class Program
{
    public static void Main(string[] args)
    {
        var listaFuncionarios = new List<Funcionario>();
        var funcoesMenu = new FuncoesMenu();
        int entrada = 999;
        
        while (entrada != 0)
        {
            funcoesMenu.Menu();
            Console.Write("Digite sua opção: ");
            if (!int.TryParse(Console.ReadLine(), out entrada))
            {
                Console.WriteLine("por favor, digite um número válido");
                continue;
            }

            switch (entrada)
            {
                case 0: // saindo do sistema
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo do sistema...");
                    Console.ResetColor();
                    break;
                case 1: // cadastrar gerente
                    funcoesMenu.CadastrarGerente(listaFuncionarios);
                    break;
                case 2: // cadastrar designer
                    funcoesMenu.CadastrarDesigner(listaFuncionarios);
                    break;
                case 3: // visualizar todos os dados
                    funcoesMenu.VisualizarTodos(listaFuncionarios);
                    break;
                case 4: // buscar por matrícula
                    funcoesMenu.BuscarPorMatricula(listaFuncionarios);
                    break;
                case 5: // remover funcionário
                    funcoesMenu.RemoverFuncionario(listaFuncionarios);
                    break;
                default:
                    Console.WriteLine("opção inválida, digite somente as opções acima");
                    break;
            }
        }
    }
}