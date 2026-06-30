public class Program
{
    public static void Main(string[] args)
    {
        var ListaContatos = new List<Contato>();
        string resposta = "S";
        while (resposta != "N")
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            ListaContatos.Add(new Contato {
                Nome = nome,
                Telefone = telefone,
                Email = email 
            });

            Console.Write("Quer continuar? [S/N]: ");
            resposta = Console.ReadLine() ?? "";
        }
        
    }
}