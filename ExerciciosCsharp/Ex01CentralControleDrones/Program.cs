using Ex01CentralControleDrones;

public class Program
{
    public static void Main(string[] args)
    {
        GerenciadorDrones gerenciadorDrones = new GerenciadorDrones();
        int opcao = 0;

        do
        {
            Console.WriteLine("""
            ========== CENTRAL DE DRONES ==========
            [1] Cadastrar drone
            [2] Listar drones
            [3] Pesquisar drone por código
            [4] Iniciar operação de entrega
            [5] Recarregar bateria
            [6] Enviar drone para manutenção
            [7] Exibir drones com bateria baixa
            [8] Sair
            """);
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine() ?? "");

            switch (opcao)
            {
                case 1:
                    gerenciadorDrones.CadastrarDrone();
                    break;
                case 2:
                    gerenciadorDrones.ListarDrones();
                    break;
                case 3:
                    int codigo;
                    Console.WriteLine("Qual o código do drone?: ");
                    codigo = int.Parse(Console.ReadLine() ?? "");
                    gerenciadorDrones.PesquisarDronePorCodigo(codigo);
                    break;
                case 4:
                    gerenciadorDrones.ExibirDronesComBateriaBaixa();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    break;
            }
        } while (opcao != 8);

    }
}
