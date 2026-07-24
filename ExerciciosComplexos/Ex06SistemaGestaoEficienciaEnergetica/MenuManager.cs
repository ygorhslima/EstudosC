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
                case "2" : ExibirDispositivos(); break;
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
        
        // instanciando o objeto de criação dos dispositivos
        CriarDispositivo cd = new CriarDispositivo();
        Dispositivo? novoDispositivo = tipo switch
        {
            "1" => cd.CriarLampada(id, nome, potencia),
            "2" => cd.CriarArCondicionado(id, nome, potencia),
            "3" => cd.CriarCarroEletrico(id, nome, potencia),
            _ => null
        };

        if (novoDispositivo != null)
        {
            Console.Write("Adicionando dispositivo para a lista...");
            _listaDispositivo.Add(novoDispositivo);
        }
    }
    private void ExibirDispositivos()
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
        
        ListarDispositivos ld = new ListarDispositivos();
        switch (item)
        {
            case "1":
                var listLamp = _listaDispositivo.OfType<LampadaInteligente>().ToList();
                ld.ListarLampadas(listLamp);
                break;
            case "2":
                var listAr = _listaDispositivo.OfType<ArCondicionado>().ToList();
                ld.ListarArCondicionado(listAr);
                break;
            case "3":
                var listCar = _listaDispositivo.OfType<CarroEletrico>().ToList(); // Corrigido para .ToList()
                ld.ListarCarroEletrico(listCar);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("\n-----------------------------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    private void ExecutarAcaoEspecifica()
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=- SELECIONE UM DISPOSITIVO -=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("1. Alterar Cor da Temperatura de uma Lâmpada Inteligente");
        Console.WriteLine("2. Alterar o Modo ECO do Ar-Condicionado");
        Console.WriteLine("3. Exibir quanto falta de carga no Carro Elétrico");
        Console.Write("Escolha uma das opções acima: ");
        string item = Console.ReadLine() ?? "";
        switch (item)
        {
          case "1":
              Console.Clear();
              Console.WriteLine("ID da Lâmpada: ");
              string idLamp = Console.ReadLine() ?? "";
              var dispositivoEncontrado = _listaDispositivo.FirstOrDefault(item => item.Id == idLamp);
              if (dispositivoEncontrado is LampadaInteligente lampadaAlvo)
              {
                  Console.WriteLine($"Lâmpada encontrada: {lampadaAlvo.Nome} digite uma nova temperatura da cor (K): ");
                  if (int.TryParse(Console.ReadLine(), out int novaTempCor))
                  {
                      lampadaAlvo.TemperaturaCor = novaTempCor;
                      Console.WriteLine("\nTemperatura da cor alterada com sucesso!");
                  }
              }
              break;
          case "2":
              Console.Clear();
              Console.WriteLine("ID do Ar-Condicionado: ");
              string idArCond = Console.ReadLine() ?? "";
              var dispositivoEncontrado2 = _listaDispositivo.FirstOrDefault(item => item.Id == idArCond);
              if (dispositivoEncontrado2 is ArCondicionado ar)
              {
                    ar.ModoECO = true;
                    Console.WriteLine($"\nModo ECO alterado com sucesso! Novo estado: {(ar.ModoECO ? "Ativado" : "Desativado")}");
              }
              break;
          case "3":
              Console.Clear();
              Console.Write("Digite o ID do Carro Elétrico: ");
              string idCar = Console.ReadLine() ?? "";

              if (_listaDispositivo.FirstOrDefault(d => d.Id == idCar) is CarroEletrico carroAlvo)
              {
                  Console.WriteLine($"\n--- STATUS DE CARGA ---");
                  Console.WriteLine($"Veículo: {carroAlvo.Nome}");
                  Console.WriteLine($"Bateria Total: {carroAlvo.CapacidadeBateria} kWh");
                  Console.WriteLine($"Carga Atual: {carroAlvo.PercentualCarga}%");
              }
              else
              {
                  Console.WriteLine("\nNenhum Carro Elétrico encontrado com esse ID.");
              }

              Console.WriteLine("\nPressione qualquer tecla para continuar...");
              Console.ReadKey();
              break;
        }
    }

}