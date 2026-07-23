public class Program
{
    public static void Main(string[] args)
    {
        Pessoa user = new Pessoa("joão","joao@gmail.com");
        try
        {
            user.Senha = "fraca";
        }catch(Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
        user.Senha = "SenhaSegura123";
        Console.WriteLine("Senha definida com sucesso");
        Console.WriteLine($"Verificação (123): {user.VerificarSenha("123")}");
        Console.WriteLine($"Verificacao (senhamaislongaainda): {user.VerificarSenha("SenhaSegura123")}");
    }    
}