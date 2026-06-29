public class Pessoa(string nome, string email)
{
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    private string _senha;
    public string Senha
    {
        set
        {
            if(value.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(value, @"[0-9]"))
            {
                _senha = value; 
            }
            else
            {
                throw new ArgumentException("A senha deve ter 8+ Caracteres, 1 maiúcula e 1 número");
            }
        }
    }

    public bool VerificarSenha(string tentativa) => _senha == tentativa;
    public string ToString()
    {
        return $"{Nome}: Nome\nEmail: {Email}";
    }
}
