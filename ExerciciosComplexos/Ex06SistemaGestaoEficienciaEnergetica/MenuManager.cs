using Ex06SistemaGestaoEficienciaEnergica.Classes;
using Ex06SistemaGestaoEficienciaEnergica.utils;
namespace Ex06SistemaGestaoEficienciaEnergica;

public class MenuManager(List<Dispositivo> listaDispositivo)
{
    private readonly List<Dispositivo> _listaDispositivo = listaDispositivo;
    
    public void ExibirMenuPrincipal()
    {
        bool rodando = true;
        while (rodando)
        {
            Console.Clear();
            Console.WriteLine("--- MENU PRINCIPAL ---");
            Console.WriteLine("1. Adicionar Dispositivo");
            Console.WriteLine("2. Listar Dispositivos");
            Console.WriteLine("3. Ação Específica");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            switch (Console.ReadLine())
            {
                case "1": CadastrarDispositivo(); break;
                case "2" : ListarDispositivos(); break;
                case "3": ExecutarAcaoEspecifica(); break;
                case "0": rodando = false; break;
                default: Console.WriteLine("Opção inválida"); Thread.Sleep(1000); break;
            }
        }
    }
    private void CadastrarDispositivo()
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=- CADASTRAR DISPOSITIVO -=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("1. Lâmpada Inteligente");
        Console.WriteLine("2. Ar-Condicionado");
        Console.WriteLine("3. Carro Elétrico");
        Console.Write("Escolha uma das opções acima: ");
        string tipo = Console.ReadLine() ?? "";
        
        Console.Write("ID: "); string id = Console.ReadLine() ?? "";
        Console.Write("Nome do dispositivo: "); string nome = Console.ReadLine() ?? "";
        Console.Write("Potência (Watts): "); double potencia = double.Parse(Console.ReadLine() ?? "");
        
        Dispositivo? novoDispositivo = tipo switch
        {
            "1" => CriarLampada(id, nome, potencia),
            "2" => CriarArCondicionado(id, nome, potencia),
            "3" => CriarCarroEletrico(id, nome, potencia),
            _ => null
        };

        if (novoDispositivo != null)
        {
            Console.Write("Adicionando dispositivo para a lista...");
            _listaDispositivo.Add(novoDispositivo);
        }
    }
    private void ListarDispositivos()
    {
        Console.Clear();
        Console.WriteLine("====================== LISTAR DISPOSITIVOS ======================");

        if (_listaDispositivo.Count == 0)
        {
            Console.WriteLine("\nERRO! A lista está sem dispositivos cadastrados.");
            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("1. Lâmpada Inteligente");
        Console.WriteLine("2. Ar-Condicionado");
        Console.WriteLine("3. Carro Elétrico");
        Console.Write("\nEscolha uma opção: ");
        var item = Console.ReadLine() ?? "";

        Console.WriteLine("\n-----------------------------------------------------------------");
        switch (item)
        {
            case "1":
                var listLamp = _listaDispositivo.OfType<LampadaInteligente>().ToList();
                ListarLampadas(listLamp);
                break;

            case "2":
                var listAr = _listaDispositivo.OfType<ArCondicionado>().ToList();
                ListarArCondicionado(listAr);
                break;
            case "3":
                var listCar = _listaDispositivo.OfType<CarroEletrico>().ToList(); // Corrigido para .ToList()
                ListarCarroEletrico(listCar);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("\n-----------------------------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
    private void ExecutarAcaoEspecifica() {}

}