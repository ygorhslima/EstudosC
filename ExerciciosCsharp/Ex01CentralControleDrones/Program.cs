using Ex01CentralControleDrones.Services;
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
                    //[1] Cadastrar drone
                    gerenciadorDrones.CadastrarDrone();
                    break;
                case 2:
                    //[2] Listar drones
                    gerenciadorDrones.ListarDrones();
                    break;
                case 3:
                    //[3] Pesquisar drone por código
                    gerenciadorDrones.PesquisarDronePorCodigo();
                    break;
                case 4:
                    //[4] Iniciar operação de entrega
                    gerenciadorDrones.IniciarOperacaoDeEntrega();
                    break;
                case 5:
                    // [5] Recarregar bateria
                    gerenciadorDrones.RecarregarBateria();
                    break;
                case 6:
                    //[6] Enviar drone para manutenção
                    gerenciadorDrones.EnviarDroneParaManutencao();
                    break;
                case 7:
                    // [7] Exibir drones com bateria baixa
                    gerenciadorDrones.ExibirDronesComBateriaBaixa();
                    break;
                case 8:
                    // [8] Sair
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("ERRO!");
                    break;
            }
        } while (opcao != 8);
    }
}
